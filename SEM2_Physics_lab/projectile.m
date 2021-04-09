vp = 5; #wartosc predkosci poczatkowej
alfa = pi/3; #wartosc k¹ta pod jakim wystrzelono pocisk
vy = vp*sin(alfa); #skladowa ygrekowa predkosci
vx = vp*cos(alfa); #skladowa xowa predkosci
g = 9.81;
y0 = 0;
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
  
  t = linspace(0, t_nr, t_nr*1000);
  opt = odeset('Events', @st);
  [t,y] = ode45(@f, t, sp, opt);
  clf;
  
  
  
  
  