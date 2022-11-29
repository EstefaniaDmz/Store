using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proyecto_Final_POO
{
    class Cventas
    {
        public string Fecha, Nombre, FormaPago;
        public int Id, Cantidad;
        public double Precio;
        public int id
        {
            set { value = Id; }
            get { return (Id); }
        }
        public string fecha
        {
            set { value = Fecha; }
            get { return (Fecha); }
        }
        public string nombre
        {
            set { value = Nombre; }
            get { return (Nombre); }
        }
        public int cantidad
        {
            set { value = Cantidad; }
            get { return (Cantidad); }
        }
        public double precio
        {
            set { value = Precio; }
            get { return (Precio); }
        }
        public string formapago
        {
            set { value = FormaPago; }
            get { return (FormaPago); }
        }
        //variable para saber cuánto va a cobrar
        internal static double totalPagar = 0;
        //variable que controla el index
        internal static int indexContador = 0;
        //método para la entrada de datos
        public void AgregarVenta()
        {
            DialogBoxAgregar agregar = new DialogBoxAgregar();
            DialogBoxResultado resul = new DialogBoxResultado();
            if (agregar.ShowDialog() == DialogResult.OK)
            {
                    ContadorDelIndex();
                StreamWriter sw = new StreamWriter("Ventas.txt", true, Encoding.UTF8);
                string cadena = indexContador.ToString() + "," + agregar.fecha + "," + agregar.nombre + "," + agregar.cantidad +
                    "," + agregar.precio;
                totalPagar = agregar.precio * agregar.cantidad;
                resul.ShowDialog();
                if (resul.pago == null)
                {
                    sw.Close();
                    if (MessageBox.Show("Los datos no se guardaron", "Añadir venta", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information) == DialogResult.Retry)
                    {
                        AgregarVenta();
                    }
                }
                else
                {
                    cadena += "," + resul.pago;
                    sw.WriteLine(cadena);
                    MessageBox.Show("Los datos se han agregado correctamente", "Añadir venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sw.Close();
                }
               
            }
        }
        //método para mostrar todos los datos:p
        public void MostrarDatos(ListView caja)
        {
            caja.Items.Clear();
            if (File.Exists("Ventas.txt") == false)
            {
                MessageBox.Show("ERROR: No se han registrado datos todavía", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ListViewItem lsvi;
            string[] lineas = File.ReadAllLines("Ventas.txt");
            for(int i = 0; i < lineas.Length; i++)
            {
                string[] datos = lineas[i].Split(',');
                lsvi = new ListViewItem(datos[0]);
                for (int j = 1; j<datos.Length; j++)
                {
                    lsvi.SubItems.Add(datos[j]);
                }
                caja.Items.Add(lsvi);
            }
        }
        //método para modificar las ventas
        public void ModificarDatos()
        {
            DialogBoxModicaaarrrr modificar = new DialogBoxModicaaarrrr();
            if (modificar.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter("Auxiliar.txt", false, Encoding.UTF8);
                string[] lines = File.ReadAllLines("Ventas.txt");
                for (int i = 0; i < lines.Length; i++)
                {
                    if (i == DialogBoxModicaaarrrr.datoModificar)
                    {
                        string[] datos = lines[i].Split(',');
                        datos[DialogBoxModicaaarrrr.que] = modificar.modificaresto;
                        string cadena = "";
                        for (int j=0; j<(datos.Length -1); j++)
                        {
                            cadena += datos[j] + ',';
                        }
                        cadena += datos[5];
                        lines[i] = cadena;
                    }
                    sw.WriteLine(lines[i]);
                }
                sw.Close();
                MessageBox.Show("Las modificaciones se han hecho correctamente", "Modificar venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                File.WriteAllText("Ventas.txt", string.Empty);
                string pasar = File.ReadAllText("Auxiliar.txt");
                File.WriteAllText("Ventas.txt", pasar);
            }
        }
        //metodo para dar de baja las ventas
        public void EliminarDatos()
        {
            DialogBoxEliminar borrar = new DialogBoxEliminar();
            if (borrar.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter("Auxiliar.txt", false, Encoding.UTF8);
                string[] lineas = File.ReadAllLines("Ventas.txt");
                for (int i = 0; i < lineas.Length; i++)
                {
                    if (i != borrar.eliminar)
                    {
                        sw.WriteLine(lineas[i]);
                    }
                }
                sw.Close();
                File.WriteAllText("Ventas.txt", string.Empty);
                StreamWriter swUno = new StreamWriter("Ventas.txt");
                string[] lineasauxi = File.ReadAllLines("Auxiliar.txt");
                for (int i = 0; i < lineasauxi.Length; i++)
                {
                    string[] datos = lineasauxi[i].Split(',');
                    datos[0] = i.ToString();
                    string cadena = "";
                    for (int j = 0; j < (datos.Length - 1); j++)
                    {
                        cadena += datos[j] + ',';
                    }
                    cadena += datos[5];
                    swUno.WriteLine(cadena);
                }
                swUno.Close();
                MessageBox.Show("La venta se ha eliminado exitosamente", "Eliminar venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //método para buscar
        public void Buscar(ListView caja)
        {
            DialogBoxBuscar buscar = new DialogBoxBuscar();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                caja.Items.Clear();
                ListViewItem lvi;
                bool banderita = false;
                string[] lines = File.ReadAllLines("Ventas.txt");
                for (int i = 0; i<lines.Length; i++)
                {
                    string[] datos = lines[i].Split(',');
                    switch(Form1.buscarQue)
                    {
                        case 1:
                            if (datos[1] == buscar.busqueda)
                            {
                                banderita = true;
                                lvi = new ListViewItem(datos[0]);
                                for (int j = 1; j<datos.Length; j++)
                                {
                                    lvi.SubItems.Add(datos[j]);
                                }
                                caja.Items.Add(lvi);
                            }
                            break;
                        case 2:
                            if (datos[2].ToLower() == buscar.busqueda)
                            {
                                banderita = true;
                                lvi = new ListViewItem(datos[0]);
                                for (int j = 1; j < datos.Length; j++)
                                {
                                    lvi.SubItems.Add(datos[j]);
                                }
                                caja.Items.Add(lvi);
                            }
                            break;
                        case 3:  
                            if (datos[5] == buscar.busqueda && buscar.busqueda != "Otro")
                            {
                                banderita = true;
                                lvi = new ListViewItem(datos[0]);
                                for (int j = 1; j < datos.Length; j++)
                                {
                                    lvi.SubItems.Add(datos[j]);
                                }
                                caja.Items.Add(lvi);
                            }
                            else
                            {
                                if (buscar.busqueda == "Otro" && datos[5] != "Transferencia" && datos[5] != "Tarjeta débito" && datos[5] != "Tarjeta crédito" && datos[5] != "Efectivo")
                                {
                                    banderita = true;
                                    lvi = new ListViewItem(datos[0]);
                                    for (int j = 1; j < datos.Length; j++)
                                    {
                                        lvi.SubItems.Add(datos[j]);
                                    }
                                    caja.Items.Add(lvi);
                                }
                            }
                            break;
                    }
                }
                if (banderita == false)
                {
                    MessageBox.Show("No se encontraron ventas", "Buscar ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    double suma = 0;
                    foreach(ListViewItem item in caja.Items)
                    {
                        suma += (double.Parse(item.SubItems[4].Text) * double.Parse(item.SubItems[3].Text));
                    }
                    lvi = new ListViewItem(string.Empty);
                    lvi.SubItems.Add(string.Empty);
                    lvi.SubItems.Add(string.Empty);
                    lvi.SubItems.Add("Total");
                    lvi.SubItems.Add(suma.ToString());
                    caja.Items.Add(lvi);
                }
            }
        }
        //método para encontrar venta más alta
        public void MostraVentaAlta(ListView caja)
        {
            double mayor = 0 , comparar = 0;
            int i = 0, pos = 0;
            foreach(ListViewItem item in caja.Items)
            {
                comparar = double.Parse(item.SubItems[4].Text) * double.Parse(item.SubItems[3].Text);
                if (comparar > mayor)
                {
                    mayor = comparar;
                    pos = i;
                }
                i++;
            }
            ListViewItem lsvi = caja.Items[pos];
            MessageBox.Show("La venta más alta fue: \nId: " + lsvi.SubItems[0].Text + "\nFecha: " + lsvi.SubItems[1].Text +
                "\nNombre: " + lsvi.SubItems[2].Text + "\nCantidad: " + lsvi.SubItems[3].Text + "\nPrecio: $" + lsvi.SubItems[4].Text +
                "\nForma de pago: " + lsvi.SubItems[5].Text + "\nTotal: $" + mayor, "Venta más alta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //método para mostrar la venta más baja
        public void MostraVentaBaja(ListView caja)
        {
            string[] lines = File.ReadAllLines("Ventas.txt");
            string[] datos = lines[0].Split(',');
            double menor = (double.Parse(datos[4]) * double.Parse(datos[3])), comparar = 0;
            int i = 0, pos = 0;
            foreach (ListViewItem item in caja.Items)
            {
                comparar = double.Parse(item.SubItems[4].Text) * double.Parse(item.SubItems[3].Text);
                if (menor > comparar)
                {
                    menor = comparar;
                    pos = i;
                }
                i++;
            }
            ListViewItem lsvi = caja.Items[pos];
            MessageBox.Show("La venta más baja fue: \nId: " + lsvi.SubItems[0].Text + "\nFecha: " + lsvi.SubItems[1].Text +
                "\nNombre: " + lsvi.SubItems[2].Text + "\nCantidad: " + lsvi.SubItems[3].Text + "\nPrecio: $" + lsvi.SubItems[4].Text +
                "\nForma de pago: " + lsvi.SubItems[5].Text + "\nTotal: $" + menor, "Venta más baja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //método para asignar el index
        public void ContadorDelIndex()
        {
            if (File.Exists("Ventas.txt") == true)
            {
                string[] lineas = File.ReadAllLines("Ventas.txt");
                if (lineas.Length > 0)
                {
                    for (int i = 0; i <lineas.Length; i++)
                    {
                        string[] datos = lineas[i].Split(',');
                        indexContador = int.Parse(datos[0]) + 1;
                    }
                }
            }
            else
            {
                indexContador = 0;
            }
        }
    }
}
