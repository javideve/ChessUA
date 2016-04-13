using System;
using System.Text.RegularExpressions;

namespace UAChess
{
    public class Chess
    {
        # region Constantes

        // Max tableros en historial
        public const int NTABLEROS = 10000;

        # endregion

        # region Atributos

        // Tablero
        public Tablero tablero;

        // Tablero activo
        public int ntablero;

        // Historial de tableros
        public int ntableros;
        public Tablero[] htableros;

        # endregion

        # region Metodos Estaticos

        // Metodo Estatico Vector
        // Inicializa un vector con un numero dado
        static public int[] Vector(int[] vector, int num)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = num;
            }

            return vector;
        }

        // Metodo Estatico Matriz
        // Inicializa una matriz con una dimension y un numero dado
        static public int[][] Matriz(int[][] matriz, int dim, int num)
        {
            for (int i = 0; i < matriz.Length; i++)
            {
                matriz[i] = Vector(new int[dim], num);
            }

            return matriz;
        }

        // Metodo NotacionAlgebraicaL
        // Obtiene notacion algebraica larga de movimiento dado
        static public string NotacionAlgebraicaL(int po, int xo, int yo, int pd, int xd, int yd, int me, int pe, int j, int jm)
        {
            string movimiento = "";

            // Notacion para traducir
            char[] cx = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
            char[] cy = { '1', '2', '3', '4', '5', '6', '7', '8' };
            char[] p = { '\0', 'P', 'N', 'B', 'R', 'Q', 'K' };

            // Pieza a mover
            movimiento += p[Math.Abs(po)] + "" + cx[xo] + "" + cy[yo] + "";

            // Captura
            if (pd != 0) { movimiento += "x" + p[Math.Abs(pd)] + ""; }

            // Destino
            movimiento += cx[xd] + "" + cy[yd] + "";

            // Movimiento ALPASO
            if (me == Tablero.ALPASO)
            {
                movimiento = p[Math.Abs(po)] + "" + cx[xo] + "" + cy[yo] + "x";
                movimiento += cx[xd] + "" + cy[yd];
            }
            // Movimiento ENROQUEC
            else if (me == Tablero.ENROQUEC)
            {
                movimiento = "O-O";
            }
            // Movimiento ENROQUEL
            else if (me == Tablero.ENROQUEL)
            {
                movimiento = "O-O-O";
            }
            // Movimiento CORONA
            else if (me == Tablero.CORONA)
            {
                movimiento += "=" + p[Math.Abs(pe)];
            }

            // Jaque
            if (jm > 0) { movimiento += "#"; }

            // Mate
            else if (j > 0) { movimiento += "+"; }

            return movimiento;
        }

        // Metodo NotacionAlgebraicaC
        // Obtiene notacion algebraica corta de movimiento dado
        static public string NotacionAlgebraicaC(int po, int xo, int yo, int pd, int xd, int yd, int me, int pe, int j, int jm, Tablero tablero)
        {
            string movimiento = "";

            // Notacion para traducir
            char[] cx = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
            char[] cy = { '1', '2', '3', '4', '5', '6', '7', '8' };
            char[] p = { '\0', ' ', 'N', 'B', 'R', 'Q', 'K' };

            // Pieza a mover
            if (po != Pieza.IDPEONB && po != Pieza.IDPEONN)
            {
                movimiento += p[Math.Abs(po)] + "";
            }

            // Ambiguedad pieza a mover
            if (po != Pieza.IDPEONB && po != Pieza.IDPEONN)
            {
                Pieza[] piezas = tablero.ControlCasilla(xd, yd, 0);

                for (int i = 0; i < piezas.Length && piezas[i] != null; i++)
                {
                    if ((piezas[i].x != xo || piezas[i].y != yo) && (piezas[i].tipo == po))
                    {
                        // Resolver con x
                        if (piezas[i].x != xo)
                        {
                            movimiento += cx[xo];
                        }
                        // Resolver con y
                        else if (piezas[i].y != yo)
                        {
                            movimiento += cy[yo];
                        }

                        break;
                    }
                }
            }

            // Captura
            if (pd != 0 || me == Tablero.ALPASO)
            {
                if (po == Pieza.IDPEONB || po == Pieza.IDPEONN)
                {
                    movimiento += cx[xo];
                }

                movimiento += "x";
            }

            // Destino
            movimiento += cx[xd] + "" + cy[yd];

            // Movimiento ENROQUEC
            if (me == Tablero.ENROQUEC)
            {
                movimiento = "O-O";
            }
            // Movimiento ENROQUEL
            else if (me == Tablero.ENROQUEL)
            {
                movimiento = "O-O-O";
            }
            // Movimiento CORONA
            else if (me == Tablero.CORONA)
            {
                movimiento += "=" + p[Math.Abs(pe)];
            }

            // Jaque
            if (jm > 0) { movimiento += "#"; }

            // Mate
            else if (j > 0) { movimiento += "+"; }

            return movimiento;
        }

        // Metodo NotacionDescriptiva
        // Obtiene notacion descriptiva de movimiento dado
        static public string NotacionDescriptiva(int po, int xo, int yo, int pd, int xd, int yd, int me, int pe, int j, int jm)
        {
            string movimiento = "";

            // Notacion para traducir
            char[] cx = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
            char[] cy = { '1', '2', '3', '4', '5', '6', '7', '8' };
            string[] p = { "", "Peón", "Cab.", "Alf.", "Tor.", "Dama", "Rey" };

            // Pieza a mover
            movimiento += p[Math.Abs(po)] + " (" + cx[xo] + "," + cy[yo] + ") ";

            // Captura normal
            if (pd != 0 || me == Tablero.ALPASO)
            {
                movimiento += "capt. a " + p[Math.Abs(pd)] + " ";
            }
            // Captura al paso
            else if (me == Tablero.ALPASO)
            {
                movimiento += "capt. a " + p[Math.Abs(pe)] + " ";
            }
            // Movimiento
            else
            {
                movimiento += "se mueve a ";
            }

            // Destino
            if (me == Tablero.ALPASO && po == Pieza.IDPEONB)
            {
                movimiento += "(" + cx[xd] + "," + cy[yd - 1] + ")";
            }
            else if (me == Tablero.ALPASO && po == Pieza.IDPEONN)
            {
                movimiento += "(" + cx[xd] + "," + cy[yd + 1] + ")";
            }
            else
            {
                movimiento += "(" + cx[xd] + "," + cy[yd] + ")";
            }

            // Movimiento ENROQUEC
            if (me == Tablero.ENROQUEC)
            {
                movimiento = "Rey enroca corto";
            }
            // Movimiento ENROQUEL
            else if (me == Tablero.ENROQUEL)
            {
                movimiento = "Rey enroca largo";
            }
            // Movimiento CORONA
            else if (me == Tablero.CORONA)
            {
                movimiento = "Peón corona en " + p[Math.Abs(pe)] + " (" + cx[xd] + "," + cy[yd] + ")";
            }

            // Jaque
            if (jm > 0) { movimiento += "#"; }

            // Mate
            else if (j > 0) { movimiento += "+"; }

            return movimiento;
        }

        // Metodo VectorNotacion
        // Obtiene vector movimiento de notacion dada
        static public int[] VectorNotacion(string movimiento, int c, Tablero tablero)
        {
            // Vector movimiento
            int po, xo, yo, pd, xd, yd, me, pe;
            po = pd = me = pe = 0;
            xo = yo = xd = yd = -1;

            // Movimiento ESTANDAR
            if (new Regex(@"^([NBRQK]?([a-h1-8])?x?[a-h][1-8](=[NBRQ])?[+#]?)$").Match(movimiento).Success)
            {
                for (int i = 0; i < movimiento.Length; i++)
                {
                    // Pieza

                    // Caballo
                    if (movimiento[i] == 'N')
                    {
                        po = Pieza.IDCABALLOB * c;
                    }
                    // Alfil
                    else if (movimiento[i] == 'B')
                    {
                        po = Pieza.IDALFILB * c;
                    }
                    // Torre
                    else if (movimiento[i] == 'R')
                    {
                        po = Pieza.IDTORREB * c;
                    }
                    // Dama
                    else if (movimiento[i] == 'Q')
                    {
                        po = Pieza.IDDAMAB * c;
                    }
                    // Rey
                    else if (movimiento[i] == 'K')
                    {
                        po = Pieza.IDREYB * c;
                    }

                    // Coordenadas

                    // Coordenada x
                    else if (movimiento[i] >= 'a' && movimiento[i] <= 'h')
                    {
                        if (xo == -1) { xo = movimiento[i] - 'a'; } else
                        if (xd == -1) { xd = movimiento[i] - 'a'; }
                    }

                    // Coordenada y
                    else if (movimiento[i] >= '1' && movimiento[i] <= '8')
                    {
                        if (yo == -1) { yo = movimiento[i] - '1'; } else
                        if (yd == -1) { yd = movimiento[i] - '1'; }
                    }

                    // Movimiento CORONA
                    else if (movimiento[i] == '=')
                    {
                        me = Tablero.CORONA;

                        switch (movimiento[i + 1])
                        {
                            // Caballo
                            case 'N':
                                pe = Pieza.IDCABALLOB * c;
                                break;

                            // Alfil
                            case 'B':
                                pe = Pieza.IDALFILB * c;
                                break;

                            // Torre
                            case 'R':
                                pe = Pieza.IDTORREB * c;
                                break;

                            // Dama
                            case 'Q':
                                pe = Pieza.IDDAMAB * c;
                                break;
                        }

                        i++;
                    }
                }

                // Pieza por defecto
                if (po == 0) { po = Pieza.IDPEONB * c; }

                // Reubicar coordenadas x
                if (xd == -1 && xo != -1) { xd = xo; xo = -1; }

                // Reubicar coordenadas y
                if (yd == -1 && yo != -1) { yd = yo; yo = -1; }

                // Resolver ambiguedad
                if (xo == -1 || yo == -1)
                {
                    Pieza[] piezas = tablero.MovimientosCasilla(xd, yd, c);

                    for (int j = 0; j < piezas.Length && piezas[j] != null; j++)
                    {
                        if (piezas[j].tipo == po && (xo == -1 || piezas[j].x == xo) && (yo == -1 || piezas[j].y == yo))
                        {
                            xo = piezas[j].x; yo = piezas[j].y;
                            break;
                        }
                    }
                }

                // Movimiento ALPASO
                if ((po == Pieza.IDPEONB || po == Pieza.IDPEONN) &&
                    xo != xd && tablero.matriz[xd][yd] == null)
                {
                    me = Tablero.ALPASO;
                    pe = xd;
                }
            }
            // Movimiento ENROQUEC
            else if (movimiento == "O-O")
            {
                if (c == Pieza.BLANCA)
                {
                    po = Pieza.IDREYB;
                    xo = tablero.reyB.x;
                    yo = tablero.reyB.y;

                    pd = 0;
                    xd = 6;
                    yd = 0;

                    me = Tablero.ENROQUEC;
                    pe = Pieza.IDREYB;
                }
                else if (c == Pieza.NEGRA)
                {
                    po = Pieza.IDREYN;
                    xo = tablero.reyN.x;
                    yo = tablero.reyN.y;

                    pd = 0;
                    xd = 6;
                    yd = 7;

                    me = Tablero.ENROQUEC;
                    pe = Pieza.IDREYN;
                }
            }

            // Movimiento ENROQUEL
            else if (movimiento == "O-O-O")
            {
                if (c == Pieza.BLANCA)
                {
                    po = Pieza.IDREYB;
                    xo = tablero.reyB.x;
                    yo = tablero.reyB.y;

                    pd = 0;
                    xd = 2;
                    yd = 0;

                    me = Tablero.ENROQUEL;
                    pe = Pieza.IDREYB;
                }
                else if (c == Pieza.NEGRA)
                {
                    po = Pieza.IDREYN;
                    xo = tablero.reyN.x;
                    yo = tablero.reyN.y;

                    pd = 0;
                    xd = 2;
                    yd = 7;

                    me = Tablero.ENROQUEL;
                    pe = Pieza.IDREYN;
                }
            }

            // Otros
            else if (movimiento != "*" && movimiento != "1-0" && movimiento != "0-1" && movimiento != "1/2-1/2")
            {
                return Chess.Vector(new int[8], -1);
            }

            return new int[8] { po, xo, yo, pd, xd, yd, me, pe };
        }

        # endregion

        # region Metodos Instancia

        // Constructor
        // Construye el ajedrez
        public Chess()
        {
            // Tablero
            tablero = new Tablero();

            // Tablero activo
            ntablero = 0;

            // Historial de tableros
            ntableros = 0; htableros = new Tablero[NTABLEROS];
        }

        // Metodo GuardarTablero
        // Guarda el estado actual del tablero
        public bool GuardarTablero()
        {
            if (ntableros < NTABLEROS)
            {
                htableros[ntableros] = new Tablero(tablero);
                ntablero = ntableros;
                ntableros++;

                return true;
            }

            return false;
        }

        // Metodo CargarTablero
        // Carga el estado dado del tablero
        public bool CargarTablero(int ntablero)
        {
            if (ntablero >= 0 && ntablero < ntableros)
            {
                tablero = new Tablero(htableros[ntablero]);
                this.ntablero = ntablero;

                return true;
            }

            return false;
        }

        // Metodo RestaurarTablero
        // Restaura el estado dado del tablero
        public bool RestaurarTablero(int ntablero)
        {
            if (CargarTablero(ntablero))
            {
                for (int i = ntablero + 1; i < ntableros; i++)
                {
                    htableros[i] = null;
                }

                ntableros = ntablero + 1;

                return true;
            }

            return false;
        }

        # endregion
    }
}