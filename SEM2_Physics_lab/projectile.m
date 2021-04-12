vp = 5; #wartosc predkosci poczatkowej
alfa = 0; #wartosc k¹ta pod jakim wystrzelono pocisk
vy = vp*sin(alfa); #skladowa ygrekowa predkosci
vx = vp*cos(alfa); #skladowa xowa predkosci
g = 9.81;
y0 = 5;
sp = [y0; vy; 0; vx]; #stany poczatkowe
t_nr = (vy +sqrt(2*y0*g+vy^2))/g; #czas ruchu bez oporu powietrza

#eventy
function [v, endp, dir] = st(t, y)
  v = y(1);
  endp = 1;
  dir = -1;
endfunction

#rownania rozn
function dy = f(t, y)
  d = 1.225; #gestosc powietrza w warunkach standardowych
  r = 0.2; #promien pocisku w metrach
  area = pi*r^2/4;#efektywna powierzchnia pocisku, ktora "trze" o gaz (powietrze)
  c = 0.5; #stala oporu dla sfery
  k = 0.5*c*area*d; #opor powietrza
  m = 1; #masa kuli w kilogramach
  g = 9.81;
  dy(1) = y(2);
  dy(2) = -g -k/m * (y(2)*y(2)+y(4)*y(4))^(1/2) * y(2);
  dy(3) = y(4);
  dy(4) = -k/m * (y(2)*y(2)+y(4)*y(4))^(1/2) * y(4);
endfunction
  
#rozwiazania ode
t = linspace(0, t_nr, t_nr*1000);
opt = odeset('Events', @st);
[t,y] = ode45(@f, t, sp, opt);
clf;

#rysowanie wykresu
hold on
  xlabel("Odleglosc [m]");
  ylabel("Wysokosc [m]");
  mY = max(y(:,1));
  mX = y(end, 3);
  y(end,1) = 0;
  note = [sprintf("Maks. wysokosc = %6.3fm", mY);
          sprintf("Maks. zasieg rzut = %6.3fm", mX);
          sprintf("Czas ruchu = %6.3fs", t(end))];
  annotation('textbox', [0.7, 0.8, 0.1, 0.1], 'String', note, 'linestyle', "none", 'fontsize', 14);
  grid on;
  plot(y(:, 3), y(:, 1));
  print -dpng rzut.png;
hold off
  
  