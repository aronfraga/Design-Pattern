using Proxy;

Cuenta c = new Cuenta(1, "Maxi", 100);
ICuenta cuentaProxy = new CuentaProxy(new CuentaBancoB());

cuentaProxy.mostrarSaldo(c);
c = cuentaProxy.depositarDinero(c, 150);
c = cuentaProxy.retirarDinero(c, 80);
cuentaProxy.mostrarSaldo(c);