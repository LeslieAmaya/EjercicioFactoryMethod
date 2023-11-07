using EjercicioFactoryMethod;

BebidaEmbriagante oBebida = Creador.CreadorBebida(Creador.CERVEZA);
Console.WriteLine(oBebida.CuantoMeEmbriagaPorHora());
