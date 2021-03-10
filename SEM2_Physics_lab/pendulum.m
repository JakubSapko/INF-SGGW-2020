#{
  Data initialization:
    - L - vector of pendulum length in meters,
    - T - vector of pendulum period in seconds;
#}
L = [0.5, 0.6, 0.7, 0.8, 0.9, 1.0, 1.1, 1.2, 1.3, 1.4];
T = [1.46, 1.581, 1.674, 1.79, 1.919, 1.968, 2.084, 2.207, 2.299, 2.412];
s = scatter(L, T, "b");
p = polyfit(L, T, 1);
#plot(s);
plot(s, p);