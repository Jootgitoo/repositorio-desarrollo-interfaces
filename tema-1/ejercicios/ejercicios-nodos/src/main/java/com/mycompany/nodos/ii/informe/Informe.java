package com.mycompany.nodos.ii.informe;

public class Informe {
    public final String[] tareas={"administrativo", "empresarial", "personal"};
    private int codigo;
    private String tarea;
    public Informe(int codigo,int indiceTarea){
        this.codigo= codigo;
        this.tarea= this.tareas[indiceTarea];
    }
    public int getCodigo() {
        return codigo;
    }
    public void setCodigo(int codigo) {
        this.codigo = codigo;
    }
    public String getTarea() {
        return tarea;
    }
    public void setTarea(String tarea) {
        this.tarea = tarea;
    }
    public String[] getTareas(){
        return tareas;
    }
    @Override
    public String toString(){
        return "El informe con codigo "+codigo+" tiene la tarea de "+tarea;
    }
}
