theta = [pi/2; 0; -pi/2; 0]; #Stany poczatkowe: theta1, theta1', theta2, theta2'
t = linspace(0, 20, 10000); #Wektor "czasu" od 0s do 20s z 10000 wartosciami

function thetprim = o(t, theta)
  #Sta³e fizyczne
  g = 1.622;
  r = 2;
  l = 3;
  k = 1;

  thetprim = [ theta(2); -g/r * sin(theta(1)) - k * (theta(1) - theta(3)); theta(4); -g/l * sin(theta(3)) - k * (theta(3) - theta(1))];
  
endfunction

#rozwi¹zanie ODE
[t,theta] = ode45(@o,t, theta);

#wykres 1
figure(1)
hold on;
  grid on; 
  title('Wykres zale¿noœci k¹tów wychylenia wahade³ od czasu', 'FontSize', 15);
  xlabel('Czas [s]', 'FontSize', 18);
  ylabel('Wychylenie wahad³a [rad]', 'FontSize', 18);
  plot(t, theta(:,1), 'c;wahad³o 1;', 'LineWidth', 1.3, t, theta(:,3), 'r;wahad³o 2;', 'LineWidth', 1.3 );
  print -dpng obraz1.png;
hold off;

#wykres 2
figure(2)
hold on;
  title('Wykres trajektorii wahad³a nr 1 w przestrzeni fazowej', 'FontSize', 15);
  xlabel('Wychylenie wahad³a [rad]');
  ylabel('Predkosc wahad³a [rad/s]');
  plot(theta(:,1), theta(:,2), 'b');
  print -dpng obraz2.png;
hold off;

#wykres 3
figure(3)
hold on;
  title('Wykres trajektorii wahad³a nr 2 w przestrzeni fazowej', 'FontSize', 15);
  xlabel('Wychylenie wahad³a [rad]');
  ylabel('Predkosc wahad³a [rad/s]');
  plot(theta(:,3), theta(:,4), 'b');
  print -dpng obraz3.png;
hold off;

