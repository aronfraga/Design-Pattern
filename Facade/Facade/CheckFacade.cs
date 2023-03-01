using System.Text;

namespace Patterns.Facade; 

public class CheckFacade {

    private AvionApi avionapi;
    private HotelApi hotelapi;

    public CheckFacade() {
        this.avionapi = new AvionApi();
        this.hotelapi = new HotelApi();
    }

    public void buscar(string fechaIda, string fechaVuelta, string origen, string destino) {
        this.avionapi.buscarVuelos(fechaIda, fechaVuelta, origen, destino);
        this.hotelapi.buscarHotel(fechaIda, fechaVuelta, origen, destino);
    }
}