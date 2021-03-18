#{
  Inicjalizacja danych:
  - L - wektor wartosci dlugosci wahad³a w metrach,
  - T - wektor wartosci okresu wahadla w sekundach
#}
L = [0.5, 0.6, 0.7, 0.8, 0.9, 1.0, 1.1, 1.2, 1.3, 1.4];
T = [1.46, 1.581, 1.674, 1.79, 1.919, 1.968, 2.084, 2.207, 2.299, 2.412];
T = T.^2;
#wartosc g z literatury
g_ref = 9.8123
#polyfit(x, y, n) zwraca wspolczynniki wielomianu stopnia n otrzymane poprze
#minimalizacje metod¹ najmniejszych kwadratów aby dopasowac
# wielomian do danych pomiarowych
P = polyfit(L, T, 1);

#rysowanie dwoch wykresow na jednej figurze
hold on;
title("Punkty pomiarowe wraz z naniesion¹ krzyw¹ najlepszego dopasowania");
xlabel("D³ugoœæ wahad³a [m]");
ylabel("Kwadrat okresu wahad³a [s^{2}]");
scatter(L, T, 10, "b");
plot(L, P(1)*L+P(2), "r");
print -djpg image.jpg;
hold off;

a = P(1);
b = P(2);
printf("Dopasowana funkcja jest postaci: y = %d*x+%d\n", a, b);
g = (4*pi*pi)/a;
printf("Obliczona stala g wynosi: %d \n", g);
delta_g = g_ref - g;
g_ilor = delta_g/g_ref*100;
printf("Delta g: %d Procent: %d \n", delta_g, g_ilor);


newplot();

disp("MANIPULACJA");
T = [1.5, 1.6, 1.7, 1.8, 1.92, 2.0, 2.1, 2.2, 2.3, 2.4];
T = T.^2;
P = polyfit(L, T, 1);


hold on;
title("Punkty pomiarowe wraz z naniesion¹ krzyw¹ najlepszego dopasowania dla zmanipulowanych danych");
xlabel("D³ugoœæ wahad³a [m]");
ylabel("Kwadrat okresu wahad³a [s^{2}]");
scatter(L, T, 10, "b");
plot(L, P(1)*L+P(2), "r");
print -djpg image2.jpg;
hold off;

a = P(1);
b = P(2);
printf("Dopasowana funkcja jest postaci: y = %d*x+%d\n", a, b);
g = (4*pi*pi)/a;
printf("Obliczona stala g wynosi: %d \n", g);
delta_g = g_ref - g;
g_ilor = delta_g/g_ref*100;
printf("Delta g: %d Procent: %d \n", delta_g, g_ilor);

