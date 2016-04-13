using System;
using System.Collections;
using System.Data;
using System.Data.SqlServerCe;

namespace UAChess.Clases
{
    class BBDD
    {
        # region Atributos

        // Conexion bbdd
        public SqlCeConnection conexion;

        // Comando a ejecutar en bbdd
        public SqlCeCommand comando;

        # endregion

        # region Metodos Instancia

        // Constructor
        // Construye conexion bbdd
        public BBDD()
        {
            // Conexion bbdd
            conexion = new SqlCeConnection(UAChess.Properties.Settings.Default.DatabaseConnectionString);

            // Comando a ejecutar en bbdd
            comando = new SqlCeCommand(null, conexion);
        }

        // Metodo ConsultaExisteBD
        // Indica si existe la bbdd dada
        public bool ConsultaExisteBD(string bbdd)
        {
            try
            {
                // Establecer comando
                comando.CommandText = "SELECT * FROM Partidas WHERE BBDD = '" + bbdd + "'";

                // Ejecutar comando
                if (conexion.State != ConnectionState.Open) { conexion.Open(); }

                if (comando.ExecuteReader().Read())
                {
                    if (conexion.State != ConnectionState.Closed) { conexion.Close(); }
                    return true;
                }

                if (conexion.State != ConnectionState.Closed) { conexion.Close(); }

                return false;
            }
            catch
            {
                return true;
            }
        }

        // Metodo ConsultaObtenerPartidas
        // Obtiene las partidas almacenadas
        public ArrayList ConsultaObtenerPartidas()
        {
            try
            {
                ArrayList consulta = new ArrayList();

                // Establecer comando
                comando.CommandText = "SELECT * FROM Partidas";

                // Ejecutar comando
                if (conexion.State != ConnectionState.Open) { conexion.Open(); }

                SqlCeDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    consulta.Add(reader[0].ToString());
                    consulta.Add(reader[1].ToString());
                    consulta.Add(reader[2].ToString());
                    consulta.Add(reader[3].ToString());
                    consulta.Add(reader[4].ToString());
                    consulta.Add(reader[5].ToString());
                    consulta.Add(reader[6].ToString());
                    consulta.Add(reader[7].ToString());
                    consulta.Add(reader[8].ToString());
                    consulta.Add(reader[9].ToString());
                    consulta.Add(reader[10].ToString());
                }

                reader.Close();

                if (conexion.State != ConnectionState.Closed) { conexion.Close(); }

                return consulta;
            }
            catch
            {
                return null;
            }
        }

        // Metodo ConsultaObtenerPartida
        // Obtiene las partidas almacenadas con campos dados
        public ArrayList ConsultaObtenerPartidas(string bbdd, string npartida)
        {
            try
            {
                ArrayList consulta = new ArrayList();

                // Establecer comando
                comando.CommandText = "SELECT * FROM Partidas WHERE BBDD = '" + bbdd + "' AND NPARTIDA = " + npartida;

                // Ejecutar comando
                if (conexion.State != ConnectionState.Open) { conexion.Open(); }

                SqlCeDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    consulta.Add(reader[0].ToString());
                    consulta.Add(reader[1].ToString());
                    consulta.Add(reader[2].ToString());
                    consulta.Add(reader[3].ToString());
                    consulta.Add(reader[4].ToString());
                    consulta.Add(reader[5].ToString());
                    consulta.Add(reader[6].ToString());
                    consulta.Add(reader[7].ToString());
                    consulta.Add(reader[8].ToString());
                    consulta.Add(reader[9].ToString());
                    consulta.Add(reader[10].ToString());
                }

                reader.Close();

                if (conexion.State != ConnectionState.Closed) { conexion.Close(); }

                return consulta;
            }
            catch
            {
                return null;
            }
        }

        // Metodo ConsultaObtenerMovimientos
        // Obtiene los movimientos almacenados
        public ArrayList ConsultaObtenerMovimientos()
        {
            try
            {
                ArrayList consulta = new ArrayList();

                // Establecer comando
                comando.CommandText = "SELECT * FROM Movimientos";

                // Ejecutar comando
                if (conexion.State != ConnectionState.Open) { conexion.Open(); }

                SqlCeDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    consulta.Add(reader[0].ToString());
                    consulta.Add(reader[1].ToString());
                    consulta.Add(reader[2].ToString());
                    consulta.Add(reader[3].ToString());
                    consulta.Add(reader[4].ToString());
                    consulta.Add(reader[5].ToString());
                    consulta.Add(reader[6].ToString());
                    consulta.Add(reader[7].ToString());
                }

                reader.Close();

                if (conexion.State != ConnectionState.Closed) { conexion.Close(); }

                return consulta;
            }
            catch
            {
                return null;
            }
        }

        // Metodo ConsultaObtenerMovimientos
        // Obtiene los movimientos almacenados con campos dados
        public ArrayList ConsultaObtenerMovimientos(string bbdd, string fechaI, string fechaF, string jugador, string eloMin, string eloMax)
        {
            try
            {
                ArrayList consulta = new ArrayList();

                // Establecer comando

                if (jugador != "Todos")
                {
                    comando.CommandText = "SELECT * FROM Movimientos " +
                                          "WHERE BBDD = '" + bbdd + "' AND fecha >= '" + fechaI + "' AND fecha <= '" + fechaF +
                                          "' AND jugador = '" + jugador + "' AND Elo >= " + eloMin + " AND Elo <= " + eloMax;
                }
                else if (jugador == "Todos")
                {
                    comando.CommandText = "SELECT * FROM Movimientos " +
                                          "WHERE BBDD = '" + bbdd + "' AND fecha >= '" + fechaI + "' AND fecha <= '" + fechaF +
                                          "' AND Elo >= " + eloMin + " AND Elo <= " + eloMax;
                }

                // Ejecutar comando
                if (conexion.State != ConnectionState.Open) { conexion.Open(); }

                SqlCeDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    consulta.Add(reader[0].ToString());
                    consulta.Add(reader[1].ToString());
                    consulta.Add(reader[2].ToString());
                    consulta.Add(reader[3].ToString());
                    consulta.Add(reader[4].ToString());
                    consulta.Add(reader[5].ToString());
                    consulta.Add(reader[6].ToString());
                    consulta.Add(reader[7].ToString());
                }

                reader.Close();

                if (conexion.State != ConnectionState.Closed) { conexion.Close(); }

                return consulta;
            }
            catch
            {
                return null;
            }
        }

        // Metodo ConsultaObtenerBDS
        // Obtiene el nombre de las bbdd almacenadas
        public ArrayList ConsultaObtenerBDS()
        {
            try
            {
                ArrayList consulta = new ArrayList();

                // Establecer comando
                comando.CommandText = "SELECT DISTINCT BBDD FROM Partidas";

                // Ejecutar comando
                if (conexion.State != ConnectionState.Open) { conexion.Open(); }

                SqlCeDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    consulta.Add(reader[0].ToString());
                }

                reader.Close();

                if (conexion.State != ConnectionState.Closed) { conexion.Close(); }

                return consulta;
            }
            catch
            {
                return null;
            }
        }

        // Metodo ConsultaObtenerJugadores
        // Obtiene el nombre de los jugadores de la bbdd dada
        public ArrayList ConsultaObtenerJugadores(string bbdd)
        {
            try
            {
                ArrayList consulta = new ArrayList();

                // Establecer comando
                comando.CommandText = "SELECT Blancas FROM Partidas WHERE BBDD = '" + bbdd + "' UNION " +
                                      "SELECT Negras FROM Partidas WHERE BBDD = '" + bbdd + "'";

                // Ejecutar comando
                if (conexion.State != ConnectionState.Open) { conexion.Open(); }

                SqlCeDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    consulta.Add(reader[0].ToString());
                }

                reader.Close();

                if (conexion.State != ConnectionState.Closed) { conexion.Close(); }

                return consulta;
            }
            catch
            {
                return null;
            }
        }

        // Metodo InsertarPartida
        // Inserta partida dada
        public bool InsertarPartida(string bbdd, string npartida, string evento, string sitio, string fecha, string ronda, 
                                    string blancas, string eloBlancas, string negras, string eloNegras, string resultado)
        {
            try
            {
                // Establecer comando
                comando.CommandText = "INSERT INTO Partidas VALUES " +
                                      "('" + bbdd + "', " + npartida + ", '" + evento + "', '" + sitio + "', '" + fecha + "', '" + ronda +
                                      "', '" + blancas + "', " + eloBlancas + ", '" + negras + "', " + eloNegras + ",'" + resultado + "')";

                // Ejecutar comando
                if (conexion.State != ConnectionState.Open) { conexion.Open(); }

                comando.ExecuteNonQuery();

                if (conexion.State != ConnectionState.Closed) { conexion.Close(); }

                return true;
            }
            catch
            {
                return false;
            }
        }

        // Metodo InsertarMovimiento
        // Inserta movimiento dado
        public bool InsertarMovimiento(string bbdd, string npartida, string nmovimiento, string fecha,
                                       string jugador, string elo, string tablero, string movimiento)
        {
            try
            {
                // Establecer comando
                comando.CommandText = "INSERT INTO Movimientos VALUES " +
                                      "('" + bbdd + "', " + npartida + ", " + nmovimiento + ", '" + fecha + "', '"
                                      + jugador + "', " + elo + ", '" + tablero + "', '" + movimiento + "')";

                // Ejecutar comando
                if (conexion.State != ConnectionState.Open) { conexion.Open(); }

                comando.ExecuteNonQuery();

                if (conexion.State != ConnectionState.Closed) { conexion.Close(); }

                return true;
            }
            catch
            {
                return false;
            }
        }

        // Metodo EliminarBDS
        // Elimina todas las bbdd almacenadas
        public bool EliminarBDS()
        {
            try
            {
                // Tabla partidas

                // Establecer comando
                comando.CommandText = "DELETE FROM Partidas";

                // Ejecutar comando
                if (conexion.State != ConnectionState.Open) { conexion.Open(); }

                comando.ExecuteNonQuery();

                if (conexion.State != ConnectionState.Closed) { conexion.Close(); }

                // Tabla movimientos

                // Establecer comando
                comando.CommandText = "DELETE FROM Movimientos";

                // Ejecutar comando
                if (conexion.State != ConnectionState.Open) { conexion.Open(); }

                comando.ExecuteNonQuery();

                if (conexion.State != ConnectionState.Closed) { conexion.Close(); }

                return true;
            }
            catch
            {
                return false;
            }
        }

        // Metodo EliminarBD
        // Elimina la bbdd dada
        public bool BorrarBBDD(string bbdd)
        {
            try
            {
                // Tabla partidas

                // Establecer comando
                comando.CommandText = "DELETE FROM Partidas WHERE BBDD = '" + bbdd + "'";

                // Ejecutar comando
                if (conexion.State != ConnectionState.Open) { conexion.Open(); }

                comando.ExecuteNonQuery();

                if (conexion.State != ConnectionState.Closed) { conexion.Close(); }

                // Tabla movimientos

                // Establecer comando
                comando.CommandText = "DELETE FROM Movimientos WHERE BBDD = '" + bbdd + "'";

                // Ejecutar comando
                if (conexion.State != ConnectionState.Open) { conexion.Open(); }

                comando.ExecuteNonQuery();

                if (conexion.State != ConnectionState.Closed) { conexion.Close(); }

                return true;
            }
            catch
            {
                return false;
            }
        }

        // Metodo BorrarPartida
        // Borra la partida dada
        public bool BorrarPartida(string bbdd, string npartida)
        {
            try
            {
                // Tabla partidas

                // Establecer comando
                comando.CommandText = "DELETE FROM Partidas WHERE BBDD = '" + bbdd + "' AND NPartida = " + npartida;

                // Ejecutar comando
                if (conexion.State != ConnectionState.Open) { conexion.Open(); }

                comando.ExecuteNonQuery();

                if (conexion.State != ConnectionState.Closed) { conexion.Close(); }

                // Tabla movimientos

                // Establecer comando
                comando.CommandText = "DELETE FROM Movimientos WHERE BBDD = '" + bbdd + "' AND NPartida = " + npartida;

                // Ejecutar comando
                if (conexion.State != ConnectionState.Open) { conexion.Open(); }

                comando.ExecuteNonQuery();

                if (conexion.State != ConnectionState.Closed) { conexion.Close(); }

                return true;
            }
            catch
            {
                return false;
            }
        }

        # endregion
    }
}