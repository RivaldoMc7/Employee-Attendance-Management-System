
package app;

public class Checada 
{
    private int id;
    private String hora;
    private String fecha;

    // Constructores
    public Checada() {
    }

    public Checada(int id, String hora, String fecha) {
        this.id = id;
        this.hora = hora;
        this.fecha = fecha;
    }

    
    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getHora() {
        return hora;
    }

    public void setHora(String hora) {
        this.hora = hora;
    }

    public String getFecha() {
        return fecha;
    }

    public void setFecha(String fecha) {
        this.fecha = fecha;
    }
    
    
}//FIN DE MI CLASE 
