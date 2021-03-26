#inicjalizacja danych
E = 5;
R1 = R2 = R4 = 500;
R3 = 500000;
#funkcja linspace(b, l, n) zwraca wektor poziomy z n liniowo rozproszonymi
#danymi miêdzy b a l (dla l>b w kolejnoœci malej¹cej)
R5 = linspace(499, 501, 21);
#wektor SEM
Ev = [0; 0; E];

dU = [];

for i=1:21
  #macierz oporow
  R = [R1+R2+R3, -R3, -R1; -R3, R4+R3+R5(i), -R4; -R1, -R4, R1+R4];
  #rozwiazanie rownania macierzowego
  I=R\Ev;
  
  U = (I(1)-I(2))*R3;
  #U = abs(I(1)-I(2))*R3;
  #dodawanie wyniku U do wektora danych dU (przygotowanie do dopasowania)
  dU = [dU, U];
  printf("Spadek nr: %d: %d [V]\n", i, U);
  #tworzenie wykresu
  title('Spadek napiecia na R3 w zaleznosci od R5');
  xlabel('Opór R5 [\Omega]');
  ylabel('Spadek napiecia [V]');
  plot(R5(i), U, 'o-', 'MarkerSize', 3);
  hold on;
 endfor;

#dopasowanie do danych
P = polyfit(R5, dU, 1);
plot(R5, P(1)*R5+P(2), "r");
printf("Dopasowana funkcja: y=%d*x+%d\n", P(1), P(2));