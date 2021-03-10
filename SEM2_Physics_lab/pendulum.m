#{
  Data initialization:
    - L - vector of pendulum length in meters,
    - T - vector of pendulum period squared in seconds squared;
#}
L = [0.5, 0.6, 0.7, 0.8, 0.9, 1.0, 1.1, 1.2, 1.3, 1.4];
T = [1.46*1.46, 1.581*1.581, 1.674*1.674, 1.79*1.79, 1.919*1.919, 1.968*1.968, 2.084*2.084, 2.207*2.207, 2.299*2.299, 2.412*2.412];
#polyfit(x, y, n) returns coefficients of a polynomial P of degree n
#got by minimization of the least-squares-error of the fit to given points
P = polyfit(L, T, 1);

hold on;
title("Punkty pomiarowe wraz z naniesion¹ krzyw¹ najlepszego dopasowania");
xlabel("D³ugoœæ wahad³a [m]");
ylabel("Kwadrat okresu wahad³a [s]");
scatter(L, T, 10, "b");
plot(L, P(1)*L+P(2), "r");
hold off;

a = P(1);
b = P(2);
printf("Dopasowana funkcja jest postaci: y = %d*x+%d\n", a, b);
g = (4*pi*pi)/a - b;
printf("Obliczona stala g wynosi: %d \n", g);