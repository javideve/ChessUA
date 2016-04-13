using System;

namespace UAChess
{
    public class Pieza
    {
        # region Constantes

        // Max movimientos en historial
        public const int NMOVIMIENTOS = 10000;

        // Color
        public const int BLANCA = 1;
        public const int NEGRA = -1;

        // Peones
        public const int IDPEONB = 1, VALPEONB = 1;
        public const int IDPEONN = -1, VALPEONN = -1;

        public const int PEONTDB = 0, PEONTRB = 1;
        public const int PEONCDB = 2, PEONCRB = 3;
        public const int PEONADB = 4, PEONARB = 5;
        public const int PEONDB = 6, PEONRB = 7;

        public const int PEONTDN = 16, PEONTRN = 17;
        public const int PEONCDN = 18, PEONCRN = 19;
        public const int PEONADN = 20, PEONARN = 21;
        public const int PEONDN = 22, PEONRN = 23;

        // Caballos
        public const int IDCABALLOB = 2, VALCABALLOB = 3;
        public const int IDCABALLON = -2, VALCABALLON = -3;

        public const int CABALLODB = 8, CABALLORB = 9;
        public const int CABALLODN = 24, CABALLORN = 25;

        // Alfiles
        public const int IDALFILB = 3, VALALFILB = 3;
        public const int IDALFILN = -3, VALALFILN = -3;

        public const int ALFILDB = 10, ALFILRB = 11;
        public const int ALFILDN = 26, ALFILRN = 27;

        // Torres
        public const int IDTORREB = 4, VALTORREB = 5;
        public const int IDTORREN = -4, VALTORREN = -5;

        public const int TORREDB = 12, TORRERB = 13;
        public const int TORREDN = 28, TORRERN = 29;

        // Damas
        public const int IDDAMAB = 5, VALDAMAB = 9;
        public const int IDDAMAN = -5, VALDAMAN = -9;

        public const int DAMAB = 14;
        public const int DAMAN = 30;

        // Reyes
        public const int IDREYB = 6, VALREYB = 10000;
        public const int IDREYN = -6, VALREYN = -10000;

        public const int REYB = 15;
        public const int REYN = 31;
        
        # endregion

        # region Atributos

        // Pieza / Posicion
        public int pieza;
        public int x, y;

        // Color / Tipo / Valor
        public int color, tipo, valor;

        // Movimientos control
        // [x, y, ...]
        public int[] controlV;
        public int[][] controlM;

        // Movimientos posibles
        // [po, xo, yo, pd, xd, yd, me, pe, ...]
        public int[] movimientosV;
        public int[][] movimientosM;

        // Historial de movs
        // [po, xo, yo, pd, xd, yd, me, pe, ...]
        public int nmovs;
        public int[] hmovs;

        // Ultimo mov pieza
        public string umov;

        # endregion

        # region Metodos Estaticos

        // Metodo Tipo
        // Obtiene tipo por defecto de la pieza dada
        static public int Tipo(int pieza)
        {
            switch (pieza)
            {
                // Peones
                case PEONTDB:
                    return IDPEONB;

                case PEONTRB:
                    return IDPEONB;

                case PEONCDB:
                    return IDPEONB;

                case PEONCRB:
                    return IDPEONB;

                case PEONADB:
                    return IDPEONB;

                case PEONARB:
                    return IDPEONB;

                case PEONDB:
                    return IDPEONB;

                case PEONRB:
                    return IDPEONB;

                case PEONTDN:
                    return IDPEONN;

                case PEONTRN:
                    return IDPEONN;

                case PEONCDN:
                    return IDPEONN;

                case PEONCRN:
                    return IDPEONN;

                case PEONADN:
                    return IDPEONN;

                case PEONARN:
                    return IDPEONN;

                case PEONDN:
                    return IDPEONN;

                case PEONRN:
                    return IDPEONN;

                // Caballos
                case CABALLODB:
                    return IDCABALLOB;

                case CABALLORB:
                    return IDCABALLOB;

                case CABALLODN:
                    return IDCABALLON;

                case CABALLORN:
                    return IDCABALLON;

                // Alfiles
                case ALFILDB:
                    return IDALFILB;

                case ALFILRB:
                    return IDALFILB;

                case ALFILDN:
                    return IDALFILN;

                case ALFILRN:
                    return IDALFILN;

                // Torres
                case TORREDB:
                    return IDTORREB;

                case TORRERB:
                    return IDTORREB;

                case TORREDN:
                    return IDTORREN;

                case TORRERN:
                    return IDTORREN;

                // Damas
                case DAMAB:
                    return IDDAMAB;

                case DAMAN:
                    return IDDAMAN;

                // Reyes
                case REYB:
                    return IDREYB;

                case REYN:
                    return IDREYN;
            }

            return 0;
        }

        // Metodo Valor
        // Obtiene valor por defecto del tipo de pieza dada
        static public int Valor(int tipo)
        {
            switch (tipo)
            {
                // Peones
                case IDPEONB:
                    return VALPEONB;

                case IDPEONN:
                    return VALPEONN;

                // Caballos
                case IDCABALLOB:
                    return VALCABALLOB;

                case IDCABALLON:
                    return VALCABALLON;

                // Alfiles
                case IDALFILB:
                    return VALALFILB;

                case IDALFILN:
                    return VALALFILN;

                // Torres
                case IDTORREB:
                    return VALTORREB;

                case IDTORREN:
                    return VALTORREN;

                // Damas
                case IDDAMAB:
                    return VALDAMAB;

                case IDDAMAN:
                    return VALDAMAN;

                // Reyes
                case IDREYB:
                    return VALREYB;

                case IDREYN:
                    return VALREYN;
            }

            return 0;
        }

        // Metodo MovControl
        // Almacena dato n en mov control [x, y, ...]
        static private int MovControl(int x, int y, int n, int[] movs)
        {
            movs[n] = x;
            movs[n + 1] = y;

            return n + 2;
        }

        // Metodo ControlPiezaV
        // Obtiene vector control de la pieza dada
        static public int[] ControlPiezaV(int x, int y, int[][] tablero)
        {
            switch (tablero[x][y])
            {
                // Peones
                case IDPEONB:
                    return ControlPeonV(x, y, tablero);

                case IDPEONN:
                    return ControlPeonV(x, y, tablero);

                // Caballos
                case IDCABALLOB:
                    return ControlCaballoV(x, y, tablero);

                case IDCABALLON:
                    return ControlCaballoV(x, y, tablero);

                // Alfiles
                case IDALFILB:
                    return ControlAlfilV(x, y, tablero);

                case IDALFILN:
                    return ControlAlfilV(x, y, tablero);

                // Torres
                case IDTORREB:
                    return ControlTorreV(x, y, tablero);

                case IDTORREN:
                    return ControlTorreV(x, y, tablero);

                // Damas
                case IDDAMAB:
                    return ControlDamaV(x, y, tablero);

                case IDDAMAN:
                    return ControlDamaV(x, y, tablero);

                // Reyes
                case IDREYB:
                    return ControlReyV(x, y, tablero);

                case IDREYN:
                    return ControlReyV(x, y, tablero);

                default:
                    return null;
            }
        }

        // Metodo ControlPeonV
        // Obtiene vector control del peon dado
        static private int[] ControlPeonV(int x, int y, int[][] tablero)
        {
            int n, c; n = c = 0;
            int[] movs = Chess.Vector(new int[2 * 2], -1);

            if (x >= 0 && x <= 7 && y >= 0 && y <= 7 && tablero != null)
            {
                if (tablero[x][y] > 0) { c = BLANCA; } else
                if (tablero[x][y] < 0) { c = NEGRA; }

                // Peon blanco
                if (c == BLANCA)
                {
                    // 1 diagonal izquierda
                    if (x - 1 >= 0 && y + 1 <= 7)
                    {
                        n = MovControl(x - 1, y + 1, n, movs);
                    }

                    // 1 diagonal derecha
                    if (x + 1 <= 7 && y + 1 <= 7)
                    {
                        n = MovControl(x + 1, y + 1, n, movs);
                    }
                }
                // Peon negro
                else if (c == NEGRA)
                {
                    // 1 diagonal izquierda
                    if (x - 1 >= 0 && y - 1 >= 0)
                    {
                        n = MovControl(x - 1, y - 1, n, movs);
                    }

                    // 1 diagonal derecha
                    if (x + 1 <= 7 && y - 1 >= 0)
                    {
                        n = MovControl(x + 1, y - 1, n, movs);
                    }
                }
            }

            return movs;
        }

        // Metodo ControlCaballoV
        // Obtiene vector control del caballo dado
        static private int[] ControlCaballoV(int x, int y, int[][] tablero)
        {
            int n = 0;
            int[] movs = Chess.Vector(new int[8 * 2], -1);

            if (x >= 0 && x <= 7 && y >= 0 && y <= 7 && tablero != null)
            {
                // 2 arriba, 1 izquierda
                if (x - 1 >= 0 && y + 2 <= 7)
                {
                    n = MovControl(x - 1, y + 2, n, movs);
                }

                // 2 arriba, 1 derecha
                if (x + 1 <= 7 && y + 2 <= 7)
                {
                    n = MovControl(x + 1, y + 2, n, movs);
                }

                // 1 arriba, 2 izquierda
                if (x - 2 >= 0 && y + 1 <= 7)
                {
                    n = MovControl(x - 2, y + 1, n, movs);
                }

                // 1 arriba, 2 derecha
                if (x + 2 <= 7 && y + 1 <= 7)
                {
                    n = MovControl(x + 2, y + 1, n, movs);
                }

                // 2 abajo, 1 izquierda
                if (x - 1 >= 0 && y - 2 >= 0)
                {
                    n = MovControl(x - 1, y - 2, n, movs);
                }

                // 2 abajo, 1 derecha
                if (x + 1 <= 7 && y - 2 >= 0)
                {
                    n = MovControl(x + 1, y - 2, n, movs);
                }

                // 1 abajo, 2 izquierda
                if (x - 2 >= 0 && y - 1 >= 0)
                {
                    n = MovControl(x - 2, y - 1, n, movs);
                }

                // 1 abajo, 2 derecha
                if (x + 2 <= 7 && y - 1 >= 0)
                {
                    n = MovControl(x + 2, y - 1, n, movs);
                }
            }

            return movs;
        }

        // Metodo ControlAlfilV
        // Obtiene vector control del alfil dado
        static private int[] ControlAlfilV(int x, int y, int[][] tablero)
        {
            int n = 0;
            int[] movs = Chess.Vector(new int[13 * 2], -1);

            if (x >= 0 && x <= 7 && y >= 0 && y <= 7 && tablero != null)
            {
                // Diagonal arriba izquierda
                for (int i = x - 1, j = y + 1; i >= 0 && j <= 7; i--, j++)
                {
                    n = MovControl(i, j, n, movs);

                    if (tablero[i][j] != 0) { break; }
                }

                // Diagonal arriba derecha
                for (int i = x + 1, j = y + 1; i <= 7 && j <= 7; i++, j++)
                {
                    n = MovControl(i, j, n, movs);

                    if (tablero[i][j] != 0) { break; }
                }

                // Diagonal abajo izquierda
                for (int i = x - 1, j = y - 1; i >= 0 && j >= 0; i--, j--)
                {
                    n = MovControl(i, j, n, movs);

                    if (tablero[i][j] != 0) { break; }
                }

                // Diagonal abajo derecha
                for (int i = x + 1, j = y - 1; i <= 7 && j >= 0; i++, j--)
                {
                    n = MovControl(i, j, n, movs);

                    if (tablero[i][j] != 0) { break; }
                }
            }

            return movs;
        }

        // Metodo ControlTorreV
        // Obtiene vector control de la torre dada
        static private int[] ControlTorreV(int x, int y, int[][] tablero)
        {
            int n = 0;
            int[] movs = Chess.Vector(new int[14 * 2], -1);

            if (x >= 0 && x <= 7 && y >= 0 && y <= 7 && tablero != null)
            {
                // Arriba
                for (int i = y + 1; i <= 7; i++)
                {
                    n = MovControl(x, i, n, movs);

                    if (tablero[x][i] != 0) { break; }
                }

                // Abajo
                for (int i = y - 1; i >= 0; i--)
                {
                    n = MovControl(x, i, n, movs);

                    if (tablero[x][i] != 0) { break; }
                }

                // Izquierda
                for (int i = x - 1; i >= 0; i--)
                {
                    n = MovControl(i, y, n, movs);

                    if (tablero[i][y] != 0) { break; }
                }

                // Derecha
                for (int i = x + 1; i <= 7; i++)
                {
                    n = MovControl(i, y, n, movs);

                    if (tablero[i][y] != 0) { break; }
                }
            }

            return movs;
        }

        // Metodo ControlDamaV
        // Obtiene vector control de la dama dada
        static private int[] ControlDamaV(int x, int y, int[][] tablero)
        {
            int n = 0;
            int[] movs = Chess.Vector(new int[27 * 2], -1);

            if (x >= 0 && x <= 7 && y >= 0 && y <= 7 && tablero != null)
            {
                // Alfil
                int[] controlAlfil = ControlAlfilV(x, y, tablero);

                for (int i = 0; i < controlAlfil.Length && controlAlfil[i] != -1; i += 2)
                {
                    n = MovControl(controlAlfil[i], controlAlfil[i + 1], n, movs);
                }

                // Torre
                int[] controlTorre = ControlTorreV(x, y, tablero);

                for (int i = 0; i < controlTorre.Length && controlTorre[i] != -1; i += 2)
                {
                    n = MovControl(controlTorre[i], controlTorre[i + 1], n, movs);
                }
            }

            return movs;
        }

        // Metodo ControlReyV
        // Obtiene vector control del rey dado
        static private int[] ControlReyV(int x, int y, int[][] tablero)
        {
            int n = 0;
            int[] movs = Chess.Vector(new int[8 * 2], -1);

            if (x >= 0 && x <= 7 && y >= 0 && y <= 7 && tablero != null)
            {
                // 1 arriba
                if (y + 1 <= 7)
                {
                    n = MovControl(x, y + 1, n, movs);
                }

                // 1 abajo
                if (y - 1 >= 0)
                {
                    n = MovControl(x, y - 1, n, movs);
                }

                // 1 izquierda
                if (x - 1 >= 0)
                {
                    n = MovControl(x - 1, y, n, movs);
                }

                // 1 derecha
                if (x + 1 <= 7)
                {
                    n = MovControl(x + 1, y, n, movs);
                }

                // 1 diagonal arriba izquierda
                if (x - 1 >= 0 && y + 1 <= 7)
                {
                    n = MovControl(x - 1, y + 1, n, movs);
                }

                // 1 diagonal arriba derecha
                if (x + 1 <= 7 && y + 1 <= 7)
                {
                    n = MovControl(x + 1, y + 1, n, movs);
                }

                // 1 diagonal abajo izquierda
                if (x - 1 >= 0 && y - 1 >= 0)
                {
                    n = MovControl(x - 1, y - 1, n, movs);
                }

                // 1 diagonal abajo derecha
                if (x + 1 <= 7 && y - 1 >= 0)
                {
                    n = MovControl(x + 1, y - 1, n, movs);
                }
            }

            return movs;
        }

        // Metodo ControlPiezaM
        // Obtiene matriz control de la pieza dada
        static public int[][] ControlPiezaM(int x, int y, int[][] tablero)
        {
            switch (tablero[x][y])
            {
                // Peones
                case IDPEONB:
                    return ControlPeonM(x, y, tablero);

                case IDPEONN:
                    return ControlPeonM(x, y, tablero);

                // Caballos
                case IDCABALLOB:
                    return ControlCaballoM(x, y, tablero);

                case IDCABALLON:
                    return ControlCaballoM(x, y, tablero);

                // Alfiles
                case IDALFILB:
                    return ControlAlfilM(x, y, tablero);

                case IDALFILN:
                    return ControlAlfilM(x, y, tablero);

                // Torres
                case IDTORREB:
                    return ControlTorreM(x, y, tablero);

                case IDTORREN:
                    return ControlTorreM(x, y, tablero);

                // Damas
                case IDDAMAB:
                    return ControlDamaM(x, y, tablero);

                case IDDAMAN:
                    return ControlDamaM(x, y, tablero);

                // Reyes
                case IDREYB:
                    return ControlReyM(x, y, tablero);

                case IDREYN:
                    return ControlReyM(x, y, tablero);

                default:
                    return null;
            }
        }

        // Metodo ControlPeonM
        // Obtiene matriz control del peon dado
        static private int[][] ControlPeonM(int x, int y, int[][] tablero)
        {
            int c = 0;
            int[][] movs = Chess.Matriz(new int[8][], 8, 0);

            if (x >= 0 && x <= 7 && y >= 0 && y <= 7 && tablero != null)
            {
                if (tablero[x][y] > 0) { c = BLANCA; } else
                if (tablero[x][y] < 0) { c = NEGRA; }

                // Peon blanco
                if (c == BLANCA)
                {
                    // 1 diagonal izquierda
                    if (x - 1 >= 0 && y + 1 <= 7)
                    {
                        movs[x - 1][y + 1] = 1;
                    }

                    // 1 diagonal derecha
                    if (x + 1 <= 7 && y + 1 <= 7)
                    {
                        movs[x + 1][y + 1] = 1;
                    }
                }
                // Peon negro
                else if (c == NEGRA)
                {
                    // 1 diagonal izquierda
                    if (x - 1 >= 0 && y - 1 >= 0)
                    {
                        movs[x - 1][y - 1] = 1;
                    }

                    // 1 diagonal derecha
                    if (x + 1 <= 7 && y - 1 >= 0)
                    {
                        movs[x + 1][y - 1] = 1;
                    }
                }
            }

            return movs;
        }

        // Metodo ControlCaballoM
        // Obtiene matriz control del caballo dado
        static private int[][] ControlCaballoM(int x, int y, int[][] tablero)
        {
            int[][] movs = Chess.Matriz(new int[8][], 8, 0);

            if (x >= 0 && x <= 7 && y >= 0 && y <= 7 && tablero != null)
            {
                // 2 arriba, 1 izquierda
                if (x - 1 >= 0 && y + 2 <= 7)
                {
                    movs[x - 1][y + 2] = 1;
                }

                // 2 arriba, 1 derecha
                if (x + 1 <= 7 && y + 2 <= 7)
                {
                    movs[x + 1][y + 2] = 1;
                }

                // 1 arriba, 2 izquierda
                if (x - 2 >= 0 && y + 1 <= 7)
                {
                    movs[x - 2][y + 1] = 1;
                }

                // 1 arriba, 2 derecha
                if (x + 2 <= 7 && y + 1 <= 7)
                {
                    movs[x + 2][y + 1] = 1;
                }

                // 2 abajo, 1 izquierda
                if (x - 1 >= 0 && y - 2 >= 0)
                {
                    movs[x - 1][y - 2] = 1;
                }

                // 2 abajo, 1 derecha
                if (x + 1 <= 7 && y - 2 >= 0)
                {
                    movs[x + 1][y - 2] = 1;
                }

                // 1 abajo, 2 izquierda
                if (x - 2 >= 0 && y - 1 >= 0)
                {
                    movs[x - 2][y - 1] = 1;
                }

                // 1 abajo, 2 derecha
                if (x + 2 <= 7 && y - 1 >= 0)
                {
                    movs[x + 2][y - 1] = 1;
                }
            }

            return movs;
        }

        // Metodo ControlAlfilM
        // Obtiene matriz control del alfil dado
        static private int[][] ControlAlfilM(int x, int y, int[][] tablero)
        {
            int[][] movs = Chess.Matriz(new int[8][], 8, 0);

            if (x >= 0 && x <= 7 && y >= 0 && y <= 7 && tablero != null)
            {
                // Diagonal arriba izquierda
                for (int i = x - 1, j = y + 1; i >= 0 && j <= 7; i--, j++)
                {
                    movs[i][j] = 1;

                    if (tablero[i][j] != 0) { break; }
                }

                // Diagonal arriba derecha
                for (int i = x + 1, j = y + 1; i <= 7 && j <= 7; i++, j++)
                {
                    movs[i][j] = 1;

                    if (tablero[i][j] != 0) { break; }
                }

                // Diagonal abajo izquierda
                for (int i = x - 1, j = y - 1; i >= 0 && j >= 0; i--, j--)
                {
                    movs[i][j] = 1;

                    if (tablero[i][j] != 0) { break; }
                }

                // Diagonal abajo derecha
                for (int i = x + 1, j = y - 1; i <= 7 && j >= 0; i++, j--)
                {
                    movs[i][j] = 1;

                    if (tablero[i][j] != 0) { break; }
                }
            }

            return movs;
        }

        // Metodo ControlTorreM
        // Obtiene matriz control de la torre dada
        static private int[][] ControlTorreM(int x, int y, int[][] tablero)
        {
            int[][] movs = Chess.Matriz(new int[8][], 8, 0);

            if (x >= 0 && x <= 7 && y >= 0 && y <= 7 && tablero != null)
            {
                // Arriba
                for (int i = y + 1; i <= 7; i++)
                {
                    movs[x][i] = 1;

                    if (tablero[x][i] != 0) { break; }
                }

                // Abajo
                for (int i = y - 1; i >= 0; i--)
                {
                    movs[x][i] = 1;

                    if (tablero[x][i] != 0) { break; }
                }

                // Izquierda
                for (int i = x - 1; i >= 0; i--)
                {
                    movs[i][y] = 1;

                    if (tablero[i][y] != 0) { break; }
                }

                // Derecha
                for (int i = x + 1; i <= 7; i++)
                {
                    movs[i][y] = 1;

                    if (tablero[i][y] != 0) { break; }
                }
            }

            return movs;
        }

        // Metodo ControlDamaM
        // Obtiene matriz control de la dama dada
        static private int[][] ControlDamaM(int x, int y, int[][] tablero)
        {
            int[][] movs = Chess.Matriz(new int[8][], 8, 0);

            if (x >= 0 && x <= 7 && y >= 0 && y <= 7 && tablero != null)
            {
                // Alfil
                int[][] controlAlfil = ControlAlfilM(x, y, tablero);

                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (controlAlfil[i][j] != 0)
                        {
                            movs[i][j] = controlAlfil[i][j];
                        }
                    }
                }

                // Torre
                int[][] controlTorre = ControlTorreM(x, y, tablero);

                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (controlTorre[i][j] != 0)
                        {
                            movs[i][j] = controlTorre[i][j];
                        }
                    }
                }
            }

            return movs;
        }

        // Metodo ControlReyM
        // Obtiene matriz control del rey dado
        static private int[][] ControlReyM(int x, int y, int[][] tablero)
        {
            int[][] movs = Chess.Matriz(new int[8][], 8, 0);

            if (x >= 0 && x <= 7 && y >= 0 && y <= 7 && tablero != null)
            {
                // 1 arriba
                if (y + 1 <= 7)
                {
                    movs[x][y + 1] = 1;
                }

                // 1 abajo
                if (y - 1 >= 0)
                {
                    movs[x][y - 1] = 1;
                }

                // 1 izquierda
                if (x - 1 >= 0)
                {
                    movs[x - 1][y] = 1;
                }

                // 1 derecha
                if (x + 1 <= 7)
                {
                    movs[x + 1][y] = 1;
                }

                // 1 diagonal arriba izquierda
                if (x - 1 >= 0 && y + 1 <= 7)
                {
                    movs[x - 1][y + 1] = 1;
                }

                // 1 diagonal arriba derecha
                if (x + 1 <= 7 && y + 1 <= 7)
                {
                    movs[x + 1][y + 1] = 1;
                }

                // 1 diagonal abajo izquierda
                if (x - 1 >= 0 && y - 1 >= 0)
                {
                    movs[x - 1][y - 1] = 1;
                }

                // 1 diagonal abajo derecha
                if (x + 1 <= 7 && y - 1 >= 0)
                {
                    movs[x + 1][y - 1] = 1;
                }
            }

            return movs;
        }

        // Metodo MovMovimientos
        // Almacena dato n en mov movimiento [po, xo, yo, pd, xd, yd, me, pe, ...]
        static private int MovMovimientos(int po, int xo, int yo, int pd, int xd, int yd, int me, int pe, int n, int[] movs)
        {
            movs[n] = po;
            movs[n + 1] = xo;
            movs[n + 2] = yo;
            movs[n + 3] = pd;
            movs[n + 4] = xd;
            movs[n + 5] = yd;
            movs[n + 6] = me;
            movs[n + 7] = pe;

            return n + 8;
        }

        // Metodo MovimientosPiezaV
        // Obtiene vector movimientos de la pieza dada
        static public int[] MovimientosPiezaV(int x, int y, int[] me, int[][] tablero)
        {
            switch (tablero[x][y])
            {
                // Peones
                case IDPEONB:
                    return MovimientosPeonV(x, y, me, tablero);

                case IDPEONN:
                    return MovimientosPeonV(x, y, me, tablero);

                // Caballos
                case IDCABALLOB:
                    return MovimientosCaballoV(x, y, me, tablero);

                case IDCABALLON:
                    return MovimientosCaballoV(x, y, me, tablero);

                // Alfiles
                case IDALFILB:
                    return MovimientosAlfilV(x, y, me, tablero);

                case IDALFILN:
                    return MovimientosAlfilV(x, y, me, tablero);

                // Torres
                case IDTORREB:
                    return MovimientosTorreV(x, y, me, tablero);

                case IDTORREN:
                    return MovimientosTorreV(x, y, me, tablero);

                // Damas
                case IDDAMAB:
                    return MovimientosDamaV(x, y, me, tablero);

                case IDDAMAN:
                    return MovimientosDamaV(x, y, me, tablero);

                // Reyes
                case IDREYB:
                    return MovimientosReyV(x, y, me, tablero);

                case IDREYN:
                    return MovimientosReyV(x, y, me, tablero);

                default:
                    return null;
            }
        }

        // Metodo MovimientosPeonV
        // Obtiene vector movimientos del peon dado
        static private int[] MovimientosPeonV(int x, int y, int[] me, int[][] tablero)
        {
            int n, c; n = c = 0;
            int[] movs = Chess.Vector(new int[8 * 8], 0);

            if (x >= 0 && x <= 7 && y >= 0 && y <= 7 && me != null && tablero != null)
            {
                if (tablero[x][y] > 0) { c = BLANCA; } else
                if (tablero[x][y] < 0) { c = NEGRA; }

                // Peon blanco
                if (c == BLANCA)
                {
                    // 1 arriba
                    if (y + 1 < 7 && tablero[x][y + 1] == 0)
                    {
                        if (!MovimientoJaque(x, y, x, y + 1, Tablero.NORMAL, 0, c, tablero))
                        {
                            n = MovMovimientos(tablero[x][y], x, y, tablero[x][y + 1], x, y + 1, Tablero.NORMAL, 0, n, movs);
                        }
                    }

                    // 2 arriba
                    if (y == 1 && tablero[x][y + 1] == 0 && tablero[x][y + 2] == 0)
                    {
                        if (!MovimientoJaque(x, y, x, y + 2, Tablero.NORMAL, 0, c, tablero))
                        {
                            n = MovMovimientos(tablero[x][y], x, y, tablero[x][y + 2], x, y + 2, Tablero.NORMAL, 0, n, movs);
                        }
                    }

                    // 1 diagonal izquierda
                    if (x - 1 >= 0 && y + 1 < 7 && tablero[x - 1][y + 1] < 0)
                    {
                        if (!MovimientoJaque(x, y, x - 1, y + 1, Tablero.NORMAL, 0, c, tablero))
                        {
                            n = MovMovimientos(tablero[x][y], x, y, tablero[x - 1][y + 1], x - 1, y + 1, Tablero.NORMAL, 0, n, movs);
                        }
                    }

                    // 1 diagonal derecha
                    if (x + 1 <= 7 && y + 1 < 7 && tablero[x + 1][y + 1] < 0)
                    {
                        if (!MovimientoJaque(x, y, x + 1, y + 1, Tablero.NORMAL, 0, c, tablero))
                        {
                            n = MovMovimientos(tablero[x][y], x, y, tablero[x + 1][y + 1], x + 1, y + 1, Tablero.NORMAL, 0, n, movs);
                        }
                    }

                    // 1 arriba (coronacion)
                    if (y + 1 == 7 && tablero[x][y + 1] == 0)
                    {
                        // Caballo
                        if (!MovimientoJaque(x, y, x, y + 1, Tablero.CORONA, IDCABALLOB, c, tablero))
                        {
                            n = MovMovimientos(tablero[x][y], x, y, tablero[x][y + 1], x, y + 1, Tablero.CORONA, IDCABALLOB, n, movs);
                        }

                        // Alfil
                        if (!MovimientoJaque(x, y, x, y + 1, Tablero.CORONA, IDALFILB, c, tablero))
                        {
                            n = MovMovimientos(tablero[x][y], x, y, tablero[x][y + 1], x, y + 1, Tablero.CORONA, IDALFILB, n, movs);
                        }

                        // Torre
                        if (!MovimientoJaque(x, y, x, y + 1, Tablero.CORONA, IDTORREB, c, tablero))
                        {
                            n = MovMovimientos(tablero[x][y], x, y, tablero[x][y + 1], x, y + 1, Tablero.CORONA, IDTORREB, n, movs);
                        }

                        // Dama
                        if (!MovimientoJaque(x, y, x, y + 1, Tablero.CORONA, IDDAMAB, c, tablero))
                        {
                            n = MovMovimientos(tablero[x][y], x, y, tablero[x][y + 1], x, y + 1, Tablero.CORONA, IDDAMAB, n, movs);
                        }
                    }

                    // 1 diagonal izquierda (coronacion)
                    if (x - 1 >= 0 && y + 1 == 7 && tablero[x - 1][y + 1] < 0)
                    {
                        // Caballo
                        if (!MovimientoJaque(x, y, x - 1, y + 1, Tablero.CORONA, IDCABALLOB, c, tablero))
                        {
                            n = MovMovimientos(tablero[x][y], x, y, tablero[x - 1][y + 1], x - 1, y + 1, Tablero.CORONA, IDCABALLOB, n, movs);
                        }

                        // Alfil
                        if (!MovimientoJaque(x, y, x - 1, y + 1, Tablero.CORONA, IDALFILB, c, tablero))
                        {
                            n = MovMovimientos(tablero[x][y], x, y, tablero[x - 1][y + 1], x - 1, y + 1, Tablero.CORONA, IDALFILB, n, movs);
                        }

                        // Torre
                        if (!MovimientoJaque(x, y, x - 1, y + 1, Tablero.CORONA, IDTORREB, c, tablero))
                        {
                            n = MovMovimientos(tablero[x][y], x, y, tablero[x - 1][y + 1], x - 1, y + 1, Tablero.CORONA, IDTORREB, n, movs);
                        }

                        // Dama
                        if (!MovimientoJaque(x, y, x - 1, y + 1, Tablero.CORONA, IDDAMAB, c, tablero))
                        {
                            n = MovMovimientos(tablero[x][y], x, y, tablero[x - 1][y + 1], x - 1, y + 1, Tablero.CORONA, IDDAMAB, n, movs);
                        }
                    }

                    // 1 diagonal derecha (coronacion)
                    if (x + 1 <= 7 && y + 1 == 7 && tablero[x + 1][y + 1] < 0)
                    {
                        // Caballo
                        if (!MovimientoJaque(x, y, x + 1, y + 1, Tablero.CORONA, IDCABALLOB, c, tablero))
                        {
                            n = MovMovimientos(tablero[x][y], x, y, tablero[x + 1][y + 1], x + 1, y + 1, Tablero.CORONA, IDCABALLOB, n, movs);
                        }

                        // Alfil
                        if (!MovimientoJaque(x, y, x + 1, y + 1, Tablero.CORONA, IDALFILB, c, tablero))
                        {
                            n = MovMovimientos(tablero[x][y], x, y, tablero[x + 1][y + 1], x + 1, y + 1, Tablero.CORONA, IDALFILB, n, movs);
                        }

                        // Torre
                        if (!MovimientoJaque(x, y, x + 1, y + 1, Tablero.CORONA, IDTORREB, c, tablero))
                        {
                            n = MovMovimientos(tablero[x][y], x, y, tablero[x + 1][y + 1], x + 1, y + 1, Tablero.CORONA, IDTORREB, n, movs);
                        }

                        // Dama
                        if (!MovimientoJaque(x, y, x + 1, y + 1, Tablero.CORONA, IDDAMAB, c, tablero))
                        {
                            n = MovMovimientos(tablero[x][y], x, y, tablero[x + 1][y + 1], x + 1, y + 1, Tablero.CORONA, IDDAMAB, n, movs);
                        }
                    }

                    // 1 diagonal izquierda (captura al paso)
                    if (x - 1 >= 0 && y == 4 && tablero[x - 1][5] == 0 && tablero[x - 1][4] == IDPEONN && me[4] == x - 1 && me[5] == 4)
                    {
                        if (!MovimientoJaque(x, y, x - 1, 5, Tablero.ALPASO, x - 1, c, tablero))
                        {
                            n = MovMovimientos(tablero[x][y], x, y, tablero[x - 1][5], x - 1, 5, Tablero.ALPASO, x - 1, n, movs);
                        }
                    }

                    // 1 diagonal derecha (captura al paso)
                    if (x + 1 <= 7 && y == 4 && tablero[x + 1][5] == 0 && tablero[x + 1][4] == IDPEONN && me[4] == x + 1 && me[5] == 4)
                    {
                        if (!MovimientoJaque(x, y, x + 1, 5, Tablero.ALPASO, x + 1, c, tablero))
                        {
                            n = MovMovimientos(tablero[x][y], x, y, tablero[x + 1][5], x + 1, 5, Tablero.ALPASO, x + 1, n, movs);
                        }
                    }
                }
                // Peon negro
                else if (c == NEGRA)
                {
                    // 1 abajo
                    if (y - 1 > 0 && tablero[x][y - 1] == 0)
                    {
                        if (!MovimientoJaque(x, y, x, y - 1, Tablero.NORMAL, 0, c, tablero))
                        {
                            n = MovMovimientos(tablero[x][y], x, y, tablero[x][y - 1], x, y - 1, Tablero.NORMAL, 0, n, movs);
                        }
                    }

                    // 2 abajo
                    if (y == 6 && tablero[x][y - 1] == 0 && tablero[x][y - 2] == 0)
                    {
                        if (!MovimientoJaque(x, y, x, y - 2, Tablero.NORMAL, 0, c, tablero))
                        {
                            n = MovMovimientos(tablero[x][y], x, y, tablero[x][y - 2], x, y - 2, Tablero.NORMAL, 0, n, movs);
                        }
                    }

                    // 1 diagonal izquierda
                    if (x - 1 >= 0 && y - 1 > 0 && tablero[x - 1][y - 1] > 0)
                    {
                        if (!MovimientoJaque(x, y, x - 1, y - 1, Tablero.NORMAL, 0, c, tablero))
                        {
                            n = MovMovimientos(tablero[x][y], x, y, tablero[x - 1][y - 1], x - 1, y - 1, Tablero.NORMAL, 0, n, movs);
                        }
                    }

                    // 1 diagonal derecha
                    if (x + 1 <= 7 && y - 1 > 0 && tablero[x + 1][y - 1] > 0)
                    {
                        if (!MovimientoJaque(x, y, x + 1, y - 1, Tablero.NORMAL, 0, c, tablero))
                        {
                            n = MovMovimientos(tablero[x][y], x, y, tablero[x + 1][y - 1], x + 1, y - 1, Tablero.NORMAL, 0, n, movs);
                        }
                    }

                    // 1 abajo (coronacion)
                    if (y - 1 == 0 && tablero[x][y - 1] == 0)
                    {
                        // Caballo
                        if (!MovimientoJaque(x, y, x, y - 1, Tablero.CORONA, IDCABALLON, c, tablero))
                        {
                            n = MovMovimientos(tablero[x][y], x, y, tablero[x][y - 1], x, y - 1, Tablero.CORONA, IDCABALLON, n, movs);
                        }

                        // Alfil
                        if (!MovimientoJaque(x, y, x, y - 1, Tablero.CORONA, IDALFILN, c, tablero))
                        {
                            n = MovMovimientos(tablero[x][y], x, y, tablero[x][y - 1], x, y - 1, Tablero.CORONA, IDALFILN, n, movs);
                        }

                        // Torre
                        if (!MovimientoJaque(x, y, x, y - 1, Tablero.CORONA, IDTORREN, c, tablero))
                        {
                            n = MovMovimientos(tablero[x][y], x, y, tablero[x][y - 1], x, y - 1, Tablero.CORONA, IDTORREN, n, movs);
                        }

                        // Dama
                        if (!MovimientoJaque(x, y, x, y - 1, Tablero.CORONA, IDDAMAN, c, tablero))
                        {
                            n = MovMovimientos(tablero[x][y], x, y, tablero[x][y - 1], x, y - 1, Tablero.CORONA, IDDAMAN, n, movs);
                        }
                    }

                    // 1 diagonal izquierda (coronacion)
                    if (x - 1 >= 0 && y - 1 == 0 && tablero[x - 1][y - 1] > 0)
                    {
                        // Caballo
                        if (!MovimientoJaque(x, y, x - 1, y - 1, Tablero.CORONA, IDCABALLON, c, tablero))
                        {
                            n = MovMovimientos(tablero[x][y], x, y, tablero[x - 1][y - 1], x - 1, y - 1, Tablero.CORONA, IDCABALLON, n, movs);
                        }

                        // Alfil
                        if (!MovimientoJaque(x, y, x - 1, y - 1, Tablero.CORONA, IDALFILN, c, tablero))
                        {
                            n = MovMovimientos(tablero[x][y], x, y, tablero[x - 1][y - 1], x - 1, y - 1, Tablero.CORONA, IDALFILN, n, movs);
                        }

                        // Torre
                        if (!MovimientoJaque(x, y, x - 1, y - 1, Tablero.CORONA, IDTORREN, c, tablero))
                        {
                            n = MovMovimientos(tablero[x][y], x, y, tablero[x - 1][y - 1], x - 1, y - 1, Tablero.CORONA, IDTORREN, n, movs);
                        }

                        // Dama
                        if (!MovimientoJaque(x, y, x - 1, y - 1, Tablero.CORONA, IDDAMAN, c, tablero))
                        {
                            n = MovMovimientos(tablero[x][y], x, y, tablero[x - 1][y - 1], x - 1, y - 1, Tablero.CORONA, IDDAMAN, n, movs);
                        }
                    }

                    // 1 diagonal derecha (coronacion)
                    if (x + 1 <= 7 && y - 1 == 0 && tablero[x + 1][y - 1] > 0)
                    {
                        // Caballo
                        if (!MovimientoJaque(x, y, x + 1, y - 1, Tablero.CORONA, IDCABALLON, c, tablero))
                        {
                            n = MovMovimientos(tablero[x][y], x, y, tablero[x + 1][y - 1], x + 1, y - 1, Tablero.CORONA, IDCABALLON, n, movs);
                        }

                        // Alfil
                        if (!MovimientoJaque(x, y, x + 1, y - 1, Tablero.CORONA, IDALFILN, c, tablero))
                        {
                            n = MovMovimientos(tablero[x][y], x, y, tablero[x + 1][y - 1], x + 1, y - 1, Tablero.CORONA, IDALFILN, n, movs);
                        }

                        // Torre
                        if (!MovimientoJaque(x, y, x + 1, y - 1, Tablero.CORONA, IDTORREN, c, tablero))
                        {
                            n = MovMovimientos(tablero[x][y], x, y, tablero[x + 1][y - 1], x + 1, y - 1, Tablero.CORONA, IDTORREN, n, movs);
                        }

                        // Dama
                        if (!MovimientoJaque(x, y, x + 1, y - 1, Tablero.CORONA, IDDAMAN, c, tablero))
                        {
                            n = MovMovimientos(tablero[x][y], x, y, tablero[x + 1][y - 1], x + 1, y - 1, Tablero.CORONA, IDDAMAN, n, movs);
                        }
                    }

                    // 1 diagonal izquierda (captura al paso)
                    if (x - 1 >= 0 && y == 3 && tablero[x - 1][2] == 0 && tablero[x - 1][3] == IDPEONB && me[4] == x - 1 && me[5] == 3)
                    {
                        if (!MovimientoJaque(x, y, x - 1, 2, Tablero.ALPASO, x - 1, c, tablero))
                        {
                            n = MovMovimientos(tablero[x][y], x, y, tablero[x - 1][2], x - 1, 2, Tablero.ALPASO, x - 1, n, movs);
                        }
                    }

                    // 1 diagonal derecha (captura al paso)
                    if (x + 1 <= 7 && y == 3 && tablero[x + 1][2] == 0 && tablero[x + 1][3] == IDPEONB && me[4] == x + 1 && me[5] == 3)
                    {
                        if (!MovimientoJaque(x, y, x + 1, 2, Tablero.ALPASO, x + 1, c, tablero))
                        {
                            n = MovMovimientos(tablero[x][y], x, y, tablero[x + 1][2], x + 1, 2, Tablero.ALPASO, x + 1, n, movs);
                        }
                    }
                }
            }

            return movs;
        }

        // Metodo MovimientosCaballoV
        // Obtiene vector movimientos del caballo dado
        static private int[] MovimientosCaballoV(int x, int y, int[] me, int[][] tablero)
        {
            int n, c; n = c = 0;
            int[] movs = Chess.Vector(new int[8 * 8], 0);

            if (x >= 0 && x <= 7 && y >= 0 && y <= 7 && me != null && tablero != null)
            {
                if (tablero[x][y] > 0) { c = BLANCA; } else
                if (tablero[x][y] < 0) { c = NEGRA; }

                // 2 arriba, 1 izquierda
                if (x - 1 >= 0 && y + 2 <= 7 && tablero[x - 1][y + 2] * c <= 0)
                {
                    if (!MovimientoJaque(x, y, x - 1, y + 2, Tablero.NORMAL, 0, c, tablero))
                    {
                        n = MovMovimientos(tablero[x][y], x, y, tablero[x - 1][y + 2], x - 1, y + 2, Tablero.NORMAL, 0, n, movs);
                    }
                }

                // 2 arriba, 1 derecha
                if (x + 1 <= 7 && y + 2 <= 7 && tablero[x + 1][y + 2] * c <= 0)
                {
                    if (!MovimientoJaque(x, y, x + 1, y + 2, Tablero.NORMAL, 0, c, tablero))
                    {
                        n = MovMovimientos(tablero[x][y], x, y, tablero[x + 1][y + 2], x + 1, y + 2, Tablero.NORMAL, 0, n, movs);
                    }
                }

                // 1 arriba, 2 izquierda
                if (x - 2 >= 0 && y + 1 <= 7 && tablero[x - 2][y + 1] * c <= 0)
                {
                    if (!MovimientoJaque(x, y, x - 2, y + 1, Tablero.NORMAL, 0, c, tablero))
                    {
                        n = MovMovimientos(tablero[x][y], x, y, tablero[x - 2][y + 1], x - 2, y + 1, Tablero.NORMAL, 0, n, movs);
                    }
                }

                // 1 arriba, 2 derecha
                if (x + 2 <= 7 && y + 1 <= 7 && tablero[x + 2][y + 1] * c <= 0)
                {
                    if (!MovimientoJaque(x, y, x + 2, y + 1, Tablero.NORMAL, 0, c, tablero))
                    {
                        n = MovMovimientos(tablero[x][y], x, y, tablero[x + 2][y + 1], x + 2, y + 1, Tablero.NORMAL, 0, n, movs);
                    }
                }

                // 2 abajo, 1 izquierda
                if (x - 1 >= 0 && y - 2 >= 0 && tablero[x - 1][y - 2] * c <= 0)
                {
                    if (!MovimientoJaque(x, y, x - 1, y - 2, Tablero.NORMAL, 0, c, tablero))
                    {
                        n = MovMovimientos(tablero[x][y], x, y, tablero[x - 1][y - 2], x - 1, y - 2, Tablero.NORMAL, 0, n, movs);
                    }
                }

                // 2 abajo, 1 derecha
                if (x + 1 <= 7 && y - 2 >= 0 && tablero[x + 1][y - 2] * c <= 0)
                {
                    if (!MovimientoJaque(x, y, x + 1, y - 2, Tablero.NORMAL, 0, c, tablero))
                    {
                        n = MovMovimientos(tablero[x][y], x, y, tablero[x + 1][y - 2], x + 1, y - 2, Tablero.NORMAL, 0, n, movs);
                    }
                }

                // 1 abajo, 2 izquierda
                if (x - 2 >= 0 && y - 1 >= 0 && tablero[x - 2][y - 1] * c <= 0)
                {
                    if (!MovimientoJaque(x, y, x - 2, y - 1, Tablero.NORMAL, 0, c, tablero))
                    {
                        n = MovMovimientos(tablero[x][y], x, y, tablero[x - 2][y - 1], x - 2, y - 1, Tablero.NORMAL, 0, n, movs);
                    }
                }

                // 1 abajo, 2 derecha
                if (x + 2 <= 7 && y - 1 >= 0 && tablero[x + 2][y - 1] * c <= 0)
                {
                    if (!MovimientoJaque(x, y, x + 2, y - 1, Tablero.NORMAL, 0, c, tablero))
                    {
                        n = MovMovimientos(tablero[x][y], x, y, tablero[x + 2][y - 1], x + 2, y - 1, Tablero.NORMAL, 0, n, movs);
                    }
                }
            }

            return movs;
        }

        // Metodo MovimientosAlfilV
        // Obtiene vector movimientos del alfil dado
        static private int[] MovimientosAlfilV(int x, int y, int[] me, int[][] tablero)
        {
            int n, c; n = c = 0;
            int[] movs = Chess.Vector(new int[13 * 8], 0);

            if (x >= 0 && x <= 7 && y >= 0 && y <= 7 && me != null && tablero != null)
            {
                if (tablero[x][y] > 0) { c = BLANCA; } else
                if (tablero[x][y] < 0) { c = NEGRA; }

                // Diagonal arriba izquierda
                for (int i = x - 1, j = y + 1; i >= 0 && j <= 7 && tablero[i][j] * c <= 0; i--, j++)
                {
                    if (!MovimientoJaque(x, y, i, j, Tablero.NORMAL, 0, c, tablero))
                    {
                        n = MovMovimientos(tablero[x][y], x, y, tablero[i][j], i, j, Tablero.NORMAL, 0, n, movs);
                    }

                    if (tablero[i][j] * c < 0) { break; }
                }

                // Diagonal arriba derecha
                for (int i = x + 1, j = y + 1; i <= 7 && j <= 7 && tablero[i][j] * c <= 0; i++, j++)
                {
                    if (!MovimientoJaque(x, y, i, j, Tablero.NORMAL, 0, c, tablero))
                    {
                        n = MovMovimientos(tablero[x][y], x, y, tablero[i][j], i, j, Tablero.NORMAL, 0, n, movs);
                    }

                    if (tablero[i][j] * c < 0) { break; }
                }

                // Diagonal abajo izquierda
                for (int i = x - 1, j = y - 1; i >= 0 && j >= 0 && tablero[i][j] * c <= 0; i--, j--)
                {
                    if (!MovimientoJaque(x, y, i, j, Tablero.NORMAL, 0, c, tablero))
                    {
                        n = MovMovimientos(tablero[x][y], x, y, tablero[i][j], i, j, Tablero.NORMAL, 0, n, movs);
                    }

                    if (tablero[i][j] * c < 0) { break; }
                }

                // Diagonal abajo derecha
                for (int i = x + 1, j = y - 1; i <= 7 && j >= 0 && tablero[i][j] * c <= 0; i++, j--)
                {
                    if (!MovimientoJaque(x, y, i, j, Tablero.NORMAL, 0, c, tablero))
                    {
                        n = MovMovimientos(tablero[x][y], x, y, tablero[i][j], i, j, Tablero.NORMAL, 0, n, movs);
                    }

                    if (tablero[i][j] * c < 0) { break; }
                }
            }

            return movs;
        }

        // Metodo MovimientosTorreV
        // Obtiene vector movimientos de la torre dada
        static private int[] MovimientosTorreV(int x, int y, int[] me, int[][] tablero)
        {
            int n, c; n = c = 0;
            int[] movs = Chess.Vector(new int[14 * 8], 0);

            if (x >= 0 && x <= 7 && y >= 0 && y <= 7 && me != null && tablero != null)
            {
                if (tablero[x][y] > 0) { c = BLANCA; } else
                if (tablero[x][y] < 0) { c = NEGRA; }

                // Arriba
                for (int i = y + 1; i <= 7 && tablero[x][i] * c <= 0; i++)
                {
                    if (!MovimientoJaque(x, y, x, i, Tablero.NORMAL, 0, c, tablero))
                    {
                        n = MovMovimientos(tablero[x][y], x, y, tablero[x][i], x, i, Tablero.NORMAL, 0, n, movs);
                    }

                    if (tablero[x][i] * c < 0) { break; }
                }

                // Abajo
                for (int i = y - 1; i >= 0 && tablero[x][i] * c <= 0; i--)
                {
                    if (!MovimientoJaque(x, y, x, i, Tablero.NORMAL, 0, c, tablero))
                    {
                        n = MovMovimientos(tablero[x][y], x, y, tablero[x][i], x, i, Tablero.NORMAL, 0, n, movs);
                    }

                    if (tablero[x][i] * c < 0) { break; }
                }

                // Izquierda
                for (int i = x - 1; i >= 0 && tablero[i][y] * c <= 0; i--)
                {
                    if (!MovimientoJaque(x, y, i, y, Tablero.NORMAL, 0, c, tablero))
                    {
                        n = MovMovimientos(tablero[x][y], x, y, tablero[i][y], i, y, Tablero.NORMAL, 0, n, movs);
                    }

                    if (tablero[i][y] * c < 0) { break; }
                }

                // Derecha
                for (int i = x + 1; i <= 7 && tablero[i][y] * c <= 0; i++)
                {
                    if (!MovimientoJaque(x, y, i, y, Tablero.NORMAL, 0, c, tablero))
                    {
                        n = MovMovimientos(tablero[x][y], x, y, tablero[i][y], i, y, Tablero.NORMAL, 0, n, movs);
                    }

                    if (tablero[i][y] * c < 0) { break; }
                }
            }

            return movs;
        }

        // Metodo MovimientosDamaV
        // Obtiene vector movimientos de la dama dada
        static private int[] MovimientosDamaV(int x, int y, int[] me, int[][] tablero)
        {
            int n = 0;
            int[] movs = Chess.Vector(new int[27 * 8], 0);

            if (x >= 0 && x <= 7 && y >= 0 && y <= 7 && me != null && tablero != null)
            {
                // Alfil
                int[] movsAlfil = MovimientosAlfilV(x, y, me, tablero);

                for (int i = 0; i < movsAlfil.Length && movsAlfil[i] != 0; i += 8)
                {
                    n = MovMovimientos(movsAlfil[i], movsAlfil[i + 1], movsAlfil[i + 2], movsAlfil[i + 3], movsAlfil[i + 4], movsAlfil[i + 5], movsAlfil[i + 6], movsAlfil[i + 7], n, movs);
                }

                // Torre
                int[] movsTorre = MovimientosTorreV(x, y, me, tablero);

                for (int i = 0; i < movsTorre.Length && movsTorre[i] != 0; i += 8)
                {
                    n = MovMovimientos(movsTorre[i], movsTorre[i + 1], movsTorre[i + 2], movsTorre[i + 3], movsTorre[i + 4], movsTorre[i + 5], movsTorre[i + 6], movsTorre[i + 7], n, movs);
                }
            }

            return movs;
        }

        // Metodo MovimientosReyV
        // Obtiene vector movimientos del rey dado
        static private int[] MovimientosReyV(int x, int y, int[] me, int[][] tablero)
        {
            int n, c; n = c = 0;
            int[] movs = Chess.Vector(new int[8 * 8], 0);

            if (x >= 0 && x <= 7 && y >= 0 && y <= 7 && me != null && tablero != null)
            {
                if (tablero[x][y] > 0) { c = BLANCA; } else
                if (tablero[x][y] < 0) { c = NEGRA; }

                // 1 arriba
                if (y + 1 <= 7 && tablero[x][y + 1] * c <= 0)
                {
                    if (!MovimientoJaque(x, y, x, y + 1, Tablero.NORMAL, 0, c, tablero))
                    {
                        n = MovMovimientos(tablero[x][y], x, y, tablero[x][y + 1], x, y + 1, Tablero.NORMAL, 0, n, movs);
                    }
                }

                // 1 abajo
                if (y - 1 >= 0 && tablero[x][y - 1] * c <= 0)
                {
                    if (!MovimientoJaque(x, y, x, y - 1, Tablero.NORMAL, 0, c, tablero))
                    {
                        n = MovMovimientos(tablero[x][y], x, y, tablero[x][y - 1], x, y - 1, Tablero.NORMAL, 0, n, movs);
                    }
                }

                // 1 izquierda
                if (x - 1 >= 0 && tablero[x - 1][y] * c <= 0)
                {
                    if (!MovimientoJaque(x, y, x - 1, y, Tablero.NORMAL, 0, c, tablero))
                    {
                        n = MovMovimientos(tablero[x][y], x, y, tablero[x - 1][y], x - 1, y, Tablero.NORMAL, 0, n, movs);
                    }
                }

                // 1 derecha
                if (x + 1 <= 7 && tablero[x + 1][y] * c <= 0)
                {
                    if (!MovimientoJaque(x, y, x + 1, y, Tablero.NORMAL, 0, c, tablero))
                    {
                        n = MovMovimientos(tablero[x][y], x, y, tablero[x + 1][y], x + 1, y, Tablero.NORMAL, 0, n, movs);
                    }
                }

                // 1 diagonal arriba izquierda
                if (x - 1 >= 0 && y + 1 <= 7 && tablero[x - 1][y + 1] * c <= 0)
                {
                    if (!MovimientoJaque(x, y, x - 1, y + 1, Tablero.NORMAL, 0, c, tablero))
                    {
                        n = MovMovimientos(tablero[x][y], x, y, tablero[x - 1][y + 1], x - 1, y + 1, Tablero.NORMAL, 0, n, movs);
                    }
                }

                // 1 diagonal arriba derecha
                if (x + 1 <= 7 && y + 1 <= 7 && tablero[x + 1][y + 1] * c <= 0)
                {
                    if (!MovimientoJaque(x, y, x + 1, y + 1, Tablero.NORMAL, 0, c, tablero))
                    {
                        n = MovMovimientos(tablero[x][y], x, y, tablero[x + 1][y + 1], x + 1, y + 1, Tablero.NORMAL, 0, n, movs);
                    }
                }

                // 1 diagonal abajo izquierda
                if (x - 1 >= 0 && y - 1 >= 0 && tablero[x - 1][y - 1] * c <= 0)
                {
                    if (!MovimientoJaque(x, y, x - 1, y - 1, Tablero.NORMAL, 0, c, tablero))
                    {
                        n = MovMovimientos(tablero[x][y], x, y, tablero[x - 1][y - 1], x - 1, y - 1, Tablero.NORMAL, 0, n, movs);
                    }
                }

                // 1 diagonal abajo derecha
                if (x + 1 <= 7 && y - 1 >= 0 && tablero[x + 1][y - 1] * c <= 0)
                {
                    if (!MovimientoJaque(x, y, x + 1, y - 1, Tablero.NORMAL, 0, c, tablero))
                    {
                        n = MovMovimientos(tablero[x][y], x, y, tablero[x + 1][y - 1], x + 1, y - 1, Tablero.NORMAL, 0, n, movs);
                    }
                }

                // Enroque corto rey blanco
                if (c == BLANCA && me[8] == 0 && me[10] == 0 && tablero[x + 1][y] == 0 && tablero[x + 2][y] == 0 &&
                    Tablero.ControlCasilla(x, y, NEGRA, tablero)[0] == -1 &&
                    Tablero.ControlCasilla(x + 1, y, NEGRA, tablero)[0] == -1 &&
                    Tablero.ControlCasilla(x + 2, y, NEGRA, tablero)[0] == -1)
                {
                    n = MovMovimientos(tablero[x][y], x, y, tablero[x + 2][y], x + 2, y, Tablero.ENROQUEC, 0, n, movs);
                }

                // Enroque largo rey blanco
                if (c == BLANCA && me[8] == 0 && me[9] == 0 && tablero[x - 1][y] == 0 && tablero[x - 2][y] == 0 &&
                    Tablero.ControlCasilla(x, y, NEGRA, tablero)[0] == -1 &&
                    Tablero.ControlCasilla(x - 1, y, NEGRA, tablero)[0] == -1 &&
                    Tablero.ControlCasilla(x - 2, y, NEGRA, tablero)[0] == -1)
                {
                    n = MovMovimientos(tablero[x][y], x, y, tablero[x - 2][y], x - 2, y, Tablero.ENROQUEL, 0, n, movs);
                }

                // Enroque corto rey negro
                if (c == NEGRA && me[11] == 0 && me[13] == 0 && tablero[x + 1][y] == 0 && tablero[x + 2][y] == 0 &&
                    Tablero.ControlCasilla(x, y, BLANCA, tablero)[0] == -1 &&
                    Tablero.ControlCasilla(x + 1, y, BLANCA, tablero)[0] == -1 &&
                    Tablero.ControlCasilla(x + 2, y, BLANCA, tablero)[0] == -1)
                {
                    n = MovMovimientos(tablero[x][y], x, y, tablero[x + 2][y], x + 2, y, Tablero.ENROQUEC, 0, n, movs);
                }

                // Enroque largo rey negro
                if (c == NEGRA && me[11] == 0 && me[12] == 0 && tablero[x - 1][y] == 0 && tablero[x - 2][y] == 0 &&
                    Tablero.ControlCasilla(x, y, BLANCA, tablero)[0] == -1 &&
                    Tablero.ControlCasilla(x - 1, y, BLANCA, tablero)[0] == -1 &&
                    Tablero.ControlCasilla(x - 2, y, BLANCA, tablero)[0] == -1)
                {
                    n = MovMovimientos(tablero[x][y], x, y, tablero[x - 2][y], x - 2, y, Tablero.ENROQUEL, 0, n, movs);
                }
            }

            return movs;
        }

        // Metodo MovimientosPiezaM
        // Obtiene matriz movimientos de la pieza dada
        static public int[][] MovimientosPiezaM(int x, int y, int[] me, int[][] tablero)
        {
            switch (tablero[x][y])
            {
                // Peones
                case IDPEONB:
                    return MovimientosPeonM(x, y, me, tablero);

                case IDPEONN:
                    return MovimientosPeonM(x, y, me, tablero);

                // Caballos
                case IDCABALLOB:
                    return MovimientosCaballoM(x, y, me, tablero);

                case IDCABALLON:
                    return MovimientosCaballoM(x, y, me, tablero);

                // Alfiles
                case IDALFILB:
                    return MovimientosAlfilM(x, y, me, tablero);

                case IDALFILN:
                    return MovimientosAlfilM(x, y, me, tablero);

                // Torres
                case IDTORREB:
                    return MovimientosTorreM(x, y, me, tablero);

                case IDTORREN:
                    return MovimientosTorreM(x, y, me, tablero);

                // Damas
                case IDDAMAB:
                    return MovimientosDamaM(x, y, me, tablero);

                case IDDAMAN:
                    return MovimientosDamaM(x, y, me, tablero);

                // Reyes
                case IDREYB:
                    return MovimientosReyM(x, y, me, tablero);

                case IDREYN:
                    return MovimientosReyM(x, y, me, tablero);

                default:
                    return null;
            }
        }

        // Metodo MovimientosPeonM
        // Obtiene matriz movimientos del peon dado
        static private int[][] MovimientosPeonM(int x, int y, int[] me, int[][] tablero)
        {
            int c = 0;
            int[][] movs = Chess.Matriz(new int[8][], 8, 0);

            if (x >= 0 && x <= 7 && y >= 0 && y <= 7 && me != null && tablero != null)
            {
                if (tablero[x][y] > 0) { c = BLANCA; } else
                if (tablero[x][y] < 0) { c = NEGRA; }

                // Peon blanco
                if (c == BLANCA)
                {
                    // 1 arriba
                    if (y + 1 <= 7 && tablero[x][y + 1] == 0)
                    {
                        if (!MovimientoJaque(x, y, x, y + 1, Tablero.NORMAL, 0, c, tablero))
                        {
                            movs[x][y + 1] = 1;
                        }
                    }

                    // 2 arriba
                    if (y == 1 && tablero[x][y + 1] == 0 && tablero[x][y + 2] == 0)
                    {
                        if (!MovimientoJaque(x, y, x, y + 2, Tablero.NORMAL, 0, c, tablero))
                        {
                            movs[x][y + 2] = 1;
                        }
                    }

                    // 1 diagonal izquierda
                    if (x - 1 >= 0 && y + 1 <= 7 && tablero[x - 1][y + 1] < 0)
                    {
                        if (!MovimientoJaque(x, y, x - 1, y + 1, Tablero.NORMAL, 0, c, tablero))
                        {
                            movs[x - 1][y + 1] = 1;
                        }
                    }

                    // 1 diagonal derecha
                    if (x + 1 <= 7 && y + 1 <= 7 && tablero[x + 1][y + 1] < 0)
                    {
                        if (!MovimientoJaque(x, y, x + 1, y + 1, Tablero.NORMAL, 0, c, tablero))
                        {
                            movs[x + 1][y + 1] = 1;
                        }
                    }

                    // 1 diagonal izquierda (captura al paso)
                    if (x - 1 >= 0 && y == 4 && tablero[x - 1][5] == 0 && tablero[x - 1][4] == IDPEONN && me[4] == x - 1 && me[5] == 4)
                    {
                        if (!MovimientoJaque(x, y, x - 1, 5, Tablero.ALPASO, x - 1, c, tablero))
                        {
                            movs[x - 1][5] = 1;
                        }
                    }

                    // 1 diagonal derecha (captura al paso)
                    if (x + 1 <= 7 && y == 4 && tablero[x + 1][5] == 0 && tablero[x + 1][4] == IDPEONN && me[4] == x + 1 && me[5] == 4)
                    {
                        if (!MovimientoJaque(x, y, x + 1, 5, Tablero.ALPASO, x + 1, c, tablero))
                        {
                            movs[x + 1][5] = 1;
                        }
                    }
                }
                // Peon negro
                else if (c == NEGRA)
                {
                    // 1 abajo
                    if (y - 1 >= 0 && tablero[x][y - 1] == 0)
                    {
                        if (!MovimientoJaque(x, y, x, y - 1, Tablero.NORMAL, 0, c, tablero))
                        {
                            movs[x][y - 1] = 1;
                        }
                    }

                    // 2 abajo
                    if (y == 6 && tablero[x][y - 1] == 0 && tablero[x][y - 2] == 0)
                    {
                        if (!MovimientoJaque(x, y, x, y - 2, Tablero.NORMAL, 0, c, tablero))
                        {
                            movs[x][y - 2] = 1;
                        }
                    }

                    // 1 diagonal izquierda
                    if (x - 1 >= 0 && y - 1 >= 0 && tablero[x - 1][y - 1] > 0)
                    {
                        if (!MovimientoJaque(x, y, x - 1, y - 1, Tablero.NORMAL, 0, c, tablero))
                        {
                            movs[x - 1][y - 1] = 1;
                        }
                    }

                    // 1 diagonal derecha
                    if (x + 1 <= 7 && y - 1 >= 0 && tablero[x + 1][y - 1] > 0)
                    {
                        if (!MovimientoJaque(x, y, x + 1, y - 1, Tablero.NORMAL, 0, c, tablero))
                        {
                            movs[x + 1][y - 1] = 1;
                        }
                    }

                    // 1 diagonal izquierda (captura al paso)
                    if (x - 1 >= 0 && y == 3 && tablero[x - 1][2] == 0 && tablero[x - 1][3] == IDPEONB && me[4] == x - 1 && me[5] == 3)
                    {
                        if (!MovimientoJaque(x, y, x - 1, 2, Tablero.ALPASO, x - 1, c, tablero))
                        {
                            movs[x - 1][2] = 1;
                        }
                    }

                    // 1 diagonal derecha (captura al paso)
                    if (x + 1 <= 7 && y == 3 && tablero[x + 1][2] == 0 && tablero[x + 1][3] == IDPEONB && me[4] == x + 1 && me[5] == 3)
                    {
                        if (!MovimientoJaque(x, y, x + 1, 2, Tablero.ALPASO, x + 1, c, tablero))
                        {
                            movs[x + 1][2] = 1;
                        }
                    }
                }
            }

            return movs;
        }

        // Metodo MovimientosCaballoM
        // Obtiene matriz movimientos del caballo dado
        static private int[][] MovimientosCaballoM(int x, int y, int[] me, int[][] tablero)
        {
            int c = 0;
            int[][] movs = Chess.Matriz(new int[8][], 8, 0);

            if (x >= 0 && x <= 7 && y >= 0 && y <= 7 && me != null && tablero != null)
            {
                if (tablero[x][y] > 0) { c = BLANCA; } else
                if (tablero[x][y] < 0) { c = NEGRA; }

                // 2 arriba, 1 izquierda
                if (x - 1 >= 0 && y + 2 <= 7 && tablero[x - 1][y + 2] * c <= 0)
                {
                    if (!MovimientoJaque(x, y, x - 1, y + 2, Tablero.NORMAL, 0, c, tablero))
                    {
                        movs[x - 1][y + 2] = 1;
                    }
                }

                // 2 arriba, 1 derecha
                if (x + 1 <= 7 && y + 2 <= 7 && tablero[x + 1][y + 2] * c <= 0)
                {
                    if (!MovimientoJaque(x, y, x + 1, y + 2, Tablero.NORMAL, 0, c, tablero))
                    {
                        movs[x + 1][y + 2] = 1;
                    }
                }

                // 1 arriba, 2 izquierda
                if (x - 2 >= 0 && y + 1 <= 7 && tablero[x - 2][y + 1] * c <= 0)
                {
                    if (!MovimientoJaque(x, y, x - 2, y + 1, Tablero.NORMAL, 0, c, tablero))
                    {
                        movs[x - 2][y + 1] = 1;
                    }
                }

                // 1 arriba, 2 derecha
                if (x + 2 <= 7 && y + 1 <= 7 && tablero[x + 2][y + 1] * c <= 0)
                {
                    if (!MovimientoJaque(x, y, x + 2, y + 1, Tablero.NORMAL, 0, c, tablero))
                    {
                        movs[x + 2][y + 1] = 1;
                    }
                }

                // 2 abajo, 1 izquierda
                if (x - 1 >= 0 && y - 2 >= 0 && tablero[x - 1][y - 2] * c <= 0)
                {
                    if (!MovimientoJaque(x, y, x - 1, y - 2, Tablero.NORMAL, 0, c, tablero))
                    {
                        movs[x - 1][y - 2] = 1;
                    }
                }

                // 2 abajo, 1 derecha
                if (x + 1 <= 7 && y - 2 >= 0 && tablero[x + 1][y - 2] * c <= 0)
                {
                    if (!MovimientoJaque(x, y, x + 1, y - 2, Tablero.NORMAL, 0, c, tablero))
                    {
                        movs[x + 1][y - 2] = 1;
                    }
                }

                // 1 abajo, 2 izquierda
                if (x - 2 >= 0 && y - 1 >= 0 && tablero[x - 2][y - 1] * c <= 0)
                {
                    if (!MovimientoJaque(x, y, x - 2, y - 1, Tablero.NORMAL, 0, c, tablero))
                    {
                        movs[x - 2][y - 1] = 1;
                    }
                }

                // 1 abajo, 2 derecha
                if (x + 2 <= 7 && y - 1 >= 0 && tablero[x + 2][y - 1] * c <= 0)
                {
                    if (!MovimientoJaque(x, y, x + 2, y - 1, Tablero.NORMAL, 0, c, tablero))
                    {
                        movs[x + 2][y - 1] = 1;
                    }
                }
            }

            return movs;
        }

        // Metodo MovimientosAlfilM
        // Obtiene matriz movimientos del alfil dado
        static private int[][] MovimientosAlfilM(int x, int y, int[] me, int[][] tablero)
        {
            int c = 0;
            int[][] movs = Chess.Matriz(new int[8][], 8, 0);

            if (x >= 0 && x <= 7 && y >= 0 && y <= 7 && me != null && tablero != null)
            {
                if (tablero[x][y] > 0) { c = BLANCA; } else
                if (tablero[x][y] < 0) { c = NEGRA; }

                // Diagonal arriba izquierda
                for (int i = x - 1, j = y + 1; i >= 0 && j <= 7 && tablero[i][j] * c <= 0; i--, j++)
                {
                    if (!MovimientoJaque(x, y, i, j, Tablero.NORMAL, 0, c, tablero))
                    {
                        movs[i][j] = 1;
                    }

                    if (tablero[i][j] * c < 0) { break; }
                }

                // Diagonal arriba derecha
                for (int i = x + 1, j = y + 1; i <= 7 && j <= 7 && tablero[i][j] * c <= 0; i++, j++)
                {
                    if (!MovimientoJaque(x, y, i, j, Tablero.NORMAL, 0, c, tablero))
                    {
                        movs[i][j] = 1;
                    }

                    if (tablero[i][j] * c < 0) { break; }
                }

                // Diagonal abajo izquierda
                for (int i = x - 1, j = y - 1; i >= 0 && j >= 0 && tablero[i][j] * c <= 0; i--, j--)
                {
                    if (!MovimientoJaque(x, y, i, j, Tablero.NORMAL, 0, c, tablero))
                    {
                        movs[i][j] = 1;
                    }

                    if (tablero[i][j] * c < 0) { break; }
                }

                // Diagonal abajo derecha
                for (int i = x + 1, j = y - 1; i <= 7 && j >= 0 && tablero[i][j] * c <= 0; i++, j--)
                {
                    if (!MovimientoJaque(x, y, i, j, Tablero.NORMAL, 0, c, tablero))
                    {
                        movs[i][j] = 1;
                    }

                    if (tablero[i][j] * c < 0) { break; }
                }
            }

            return movs;
        }

        // Metodo MovimientosTorreM
        // Obtiene matriz movimientos de la torre dada
        static private int[][] MovimientosTorreM(int x, int y, int[] me, int[][] tablero)
        {
            int c = 0;
            int[][] movs = Chess.Matriz(new int[8][], 8, 0);

            if (x >= 0 && x <= 7 && y >= 0 && y <= 7 && me != null && tablero != null)
            {
                if (tablero[x][y] > 0) { c = BLANCA; } else
                if (tablero[x][y] < 0) { c = NEGRA; }

                // Arriba
                for (int i = y + 1; i <= 7 && tablero[x][i] * c <= 0; i++)
                {
                    if (!MovimientoJaque(x, y, x, i, Tablero.NORMAL, 0, c, tablero))
                    {
                        movs[x][i] = 1;
                    }

                    if (tablero[x][i] * c < 0) { break; }
                }

                // Abajo
                for (int i = y - 1; i >= 0 && tablero[x][i] * c <= 0; i--)
                {
                    if (!MovimientoJaque(x, y, x, i, Tablero.NORMAL, 0, c, tablero))
                    {
                        movs[x][i] = 1;
                    }

                    if (tablero[x][i] * c < 0) { break; }
                }

                // Izquierda
                for (int i = x - 1; i >= 0 && tablero[i][y] * c <= 0; i--)
                {
                    if (!MovimientoJaque(x, y, i, y, Tablero.NORMAL, 0, c, tablero))
                    {
                        movs[i][y] = 1;
                    }

                    if (tablero[i][y] * c < 0) { break; }
                }

                // Derecha
                for (int i = x + 1; i <= 7 && tablero[i][y] * c <= 0; i++)
                {
                    if (!MovimientoJaque(x, y, i, y, Tablero.NORMAL, 0, c, tablero))
                    {
                        movs[i][y] = 1;
                    }

                    if (tablero[i][y] * c < 0) { break; }
                }
            }

            return movs;
        }

        // Metodo MovimientosDamaM
        // Obtiene matriz movimientos de la dama dada
        static private int[][] MovimientosDamaM(int x, int y, int[] me, int[][] tablero)
        {
            int[][] movs = Chess.Matriz(new int[8][], 8, 0);

            if (x >= 0 && x <= 7 && y >= 0 && y <= 7 && me != null && tablero != null)
            {
                // Alfil
                int[][] movsAlfil = MovimientosAlfilM(x, y, me, tablero);

                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (movsAlfil[i][j] != 0)
                        {
                            movs[i][j] = movsAlfil[i][j];
                        }
                    }
                }

                // Torre
                int[][] movsTorre = MovimientosTorreM(x, y, me, tablero);

                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (movsTorre[i][j] != 0)
                        {
                            movs[i][j] = movsTorre[i][j];
                        }
                    }
                }
            }

            return movs;
        }

        // Metodo MovimientosReyM
        // Obtiene matriz movimientos del rey dado
        static private int[][] MovimientosReyM(int x, int y, int[] me, int[][] tablero)
        {
            int c = 0;
            int[][] movs = Chess.Matriz(new int[8][], 8, 0);

            if (x >= 0 && x <= 7 && y >= 0 && y <= 7 && me != null && tablero != null)
            {
                if (tablero[x][y] > 0) { c = BLANCA; } else
                if (tablero[x][y] < 0) { c = NEGRA; }

                // 1 arriba
                if (y + 1 <= 7 && tablero[x][y + 1] * c <= 0)
                {
                    if (!MovimientoJaque(x, y, x, y + 1, Tablero.NORMAL, 0, c, tablero))
                    {
                        movs[x][y + 1] = 1;
                    }
                }

                // 1 abajo
                if (y - 1 >= 0 && tablero[x][y - 1] * c <= 0)
                {
                    if (!MovimientoJaque(x, y, x, y - 1, Tablero.NORMAL, 0, c, tablero))
                    {
                        movs[x][y - 1] = 1;
                    }
                }

                // 1 izquierda
                if (x - 1 >= 0 && tablero[x - 1][y] * c <= 0)
                {
                    if (!MovimientoJaque(x, y, x - 1, y, Tablero.NORMAL, 0, c, tablero))
                    {
                        movs[x - 1][y] = 1;
                    }
                }

                // 1 derecha
                if (x + 1 <= 7 && tablero[x + 1][y] * c <= 0)
                {
                    if (!MovimientoJaque(x, y, x + 1, y, Tablero.NORMAL, 0, c, tablero))
                    {
                        movs[x + 1][y] = 1;
                    }
                }

                // 1 diagonal arriba izquierda
                if (x - 1 >= 0 && y + 1 <= 7 && tablero[x - 1][y + 1] * c <= 0)
                {
                    if (!MovimientoJaque(x, y, x - 1, y + 1, Tablero.NORMAL, 0, c, tablero))
                    {
                        movs[x - 1][y + 1] = 1;
                    }
                }

                // 1 diagonal arriba derecha
                if (x + 1 <= 7 && y + 1 <= 7 && tablero[x + 1][y + 1] * c <= 0)
                {
                    if (!MovimientoJaque(x, y, x + 1, y + 1, Tablero.NORMAL, 0, c, tablero))
                    {
                        movs[x + 1][y + 1] = 1;
                    }
                }

                // 1 diagonal abajo izquierda
                if (x - 1 >= 0 && y - 1 >= 0 && tablero[x - 1][y - 1] * c <= 0)
                {
                    if (!MovimientoJaque(x, y, x - 1, y - 1, Tablero.NORMAL, 0, c, tablero))
                    {
                        movs[x - 1][y - 1] = 1;
                    }
                }

                // 1 diagonal abajo derecha
                if (x + 1 <= 7 && y - 1 >= 0 && tablero[x + 1][y - 1] * c <= 0)
                {
                    if (!MovimientoJaque(x, y, x + 1, y - 1, Tablero.NORMAL, 0, c, tablero))
                    {
                        movs[x + 1][y - 1] = 1;
                    }
                }

                // Enroque corto rey blanco
                if (c == BLANCA && me[8] == 0 && me[10] == 0 && tablero[x + 1][y] == 0 && tablero[x + 2][y] == 0 &&
                    Tablero.ControlCasilla(x, y, NEGRA, tablero)[0] == -1 &&
                    Tablero.ControlCasilla(x + 1, y, NEGRA, tablero)[0] == -1 &&
                    Tablero.ControlCasilla(x + 2, y, NEGRA, tablero)[0] == -1)
                {
                    movs[x + 2][y] = 1;
                }

                // Enroque largo rey blanco
                if (c == BLANCA && me[8] == 0 && me[9] == 0 && tablero[x - 1][y] == 0 && tablero[x - 2][y] == 0 &&
                    Tablero.ControlCasilla(x, y, NEGRA, tablero)[0] == -1 &&
                    Tablero.ControlCasilla(x - 1, y, NEGRA, tablero)[0] == -1 &&
                    Tablero.ControlCasilla(x - 2, y, NEGRA, tablero)[0] == -1)
                {
                    movs[x - 2][y] = 1;
                }

                // Enroque corto rey negro
                if (c == NEGRA && me[11] == 0 && me[13] == 0 && tablero[x + 1][y] == 0 && tablero[x + 2][y] == 0 &&
                    Tablero.ControlCasilla(x, y, BLANCA, tablero)[0] == -1 &&
                    Tablero.ControlCasilla(x + 1, y, BLANCA, tablero)[0] == -1 &&
                    Tablero.ControlCasilla(x + 2, y, BLANCA, tablero)[0] == -1)
                {
                    movs[x + 2][y] = 1;
                }

                // Enroque largo rey negro
                if (c == NEGRA && me[11] == 0 && me[12] == 0 && tablero[x - 1][y] == 0 && tablero[x - 2][y] == 0 &&
                    Tablero.ControlCasilla(x, y, BLANCA, tablero)[0] == -1 &&
                    Tablero.ControlCasilla(x - 1, y, BLANCA, tablero)[0] == -1 &&
                    Tablero.ControlCasilla(x - 2, y, BLANCA, tablero)[0] == -1)
                {
                    movs[x - 2][y] = 1;
                }
            }

            return movs;
        }

        // Metodo MovimientoJaque
        // Indica si rey esta en jaque tras realizar movimiento dado
        static public bool MovimientoJaque(int xo, int yo, int xd, int yd, int me, int pe, int c, int[][] tablero)
        {
            if (xo >= 0 && xo <= 7 && yo >= 0 && yo <= 7 && xd >= 0 && xd <= 7 && yd >= 0 && yd <= 7 &&
                (c == BLANCA || c == NEGRA) && tablero != null)
            {
                // Tablero tras mover
                int[][] tableroC = Mover(xo, yo, xd, yd, me, pe, tablero);

                // Indica si rey dado esta en jaque en tablero
                return Tablero.Jaque(c, tableroC);
            }

            return false;
        }

        // Metodo Mover
        // Obtiene tablero resultado tras realizar movimiento dado
        static public int[][] Mover(int xo, int yo, int xd, int yd, int me, int pe, int[][] tablero)
        {
            if (xo >= 0 && xo <= 7 && yo >= 0 && yo <= 7 && xd >= 0 && xd <= 7 && yd >= 0 && yd <= 7 && tablero != null)
            {
                // Tablero copia
                int[][] tableroC = Chess.Matriz(new int[8][], 8, 0);

                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        tableroC[i][j] = tablero[i][j];
                    }
                }

                // Movimiento NORMAL
                tableroC[xd][yd] = tableroC[xo][yo];
                tableroC[xo][yo] = 0;

                // Movimientos ESPECIALES
                switch (me)
                {
                    // Movimiento ALPASO
                    case Tablero.ALPASO:
                        if (tablero[xo][yo] > 0) { tableroC[xd][yd - 1] = 0; } else
                        if (tablero[xo][yo] < 0) { tableroC[xd][yd + 1] = 0; }
                        break;

                    // Movimiento ENROQUEC
                    case Tablero.ENROQUEC:
                        tableroC[5][yo] = tableroC[7][yo];
                        tableroC[7][yo] = 0;
                        break;

                    // Movimiento ENROQUEL
                    case Tablero.ENROQUEL:
                        tableroC[3][yo] = tableroC[0][yo];
                        tableroC[0][yo] = 0;
                        break;

                    // Movimiento CORONA
                    case Tablero.CORONA:
                        tableroC[xd][yd] = pe;
                        break;
                }

                return tableroC;
            }

            return null;
        }

        # endregion

        # region Metodos Instancia

        // Constructor
        // Construye la pieza dada
        public Pieza(int pieza)
        {
            // Tablero inicial
            int[][] tablero = new int[8][];

            tablero[0] = new int[8] { IDTORREB, IDPEONB, 0, 0, 0, 0, IDPEONN, IDTORREN };
            tablero[1] = new int[8] { IDCABALLOB, IDPEONB, 0, 0, 0, 0, IDPEONN, IDCABALLON };
            tablero[2] = new int[8] { IDALFILB, IDPEONB, 0, 0, 0, 0, IDPEONN, IDALFILN };
            tablero[3] = new int[8] { IDDAMAB, IDPEONB, 0, 0, 0, 0, IDPEONN, IDDAMAN };
            tablero[4] = new int[8] { IDREYB, IDPEONB, 0, 0, 0, 0, IDPEONN, IDREYN };
            tablero[5] = new int[8] { IDALFILB, IDPEONB, 0, 0, 0, 0, IDPEONN, IDALFILN };
            tablero[6] = new int[8] { IDCABALLOB, IDPEONB, 0, 0, 0, 0, IDPEONN, IDCABALLON };
            tablero[7] = new int[8] { IDTORREB, IDPEONB, 0, 0, 0, 0, IDPEONN, IDTORREN };

            // Vector movs especiales inicial
            // [po, xo, yo, pd, xd, yd, me, pe, nreyb, ntorredb, ntorrerb, nreyn, ntorredn, ntorrern]
            int[] me = Chess.Vector(new int[14], 0);

            switch (pieza)
            {
                // Peones

                // Peon torre dama blanco
                case PEONTDB:

                    this.pieza = pieza;
                    this.x = 0; this.y = 1;

                    color = BLANCA;
                    tipo = IDPEONB; valor = VALPEONB;

                    break;

                // Peon torre rey blanco
                case PEONTRB:

                    this.pieza = pieza;
                    this.x = 7; this.y = 1;

                    color = BLANCA;
                    tipo = IDPEONB; valor = VALPEONB;

                    break;

                // Peon caballo dama blanco
                case PEONCDB:

                    this.pieza = pieza;
                    this.x = 1; this.y = 1;

                    color = BLANCA;
                    tipo = IDPEONB; valor = VALPEONB;

                    break;

                // Peon caballo rey blanco
                case PEONCRB:

                    this.pieza = pieza;
                    this.x = 6; this.y = 1;

                    color = BLANCA;
                    tipo = IDPEONB; valor = VALPEONB;

                    break;

                // Peon alfil dama blanco
                case PEONADB:

                    this.pieza = pieza;
                    this.x = 2; this.y = 1;

                    color = BLANCA;
                    tipo = IDPEONB; valor = VALPEONB;

                    break;

                // Peon alfil rey blanco
                case PEONARB:

                    this.pieza = pieza;
                    this.x = 5; this.y = 1;

                    color = BLANCA;
                    tipo = IDPEONB; valor = VALPEONB;

                    break;

                // Peon dama blanco
                case PEONDB:

                    this.pieza = pieza;
                    this.x = 3; this.y = 1;

                    color = BLANCA;
                    tipo = IDPEONB; valor = VALPEONB;

                    break;

                // Peon rey blanco
                case PEONRB:

                    this.pieza = pieza;
                    this.x = 4; this.y = 1;

                    color = BLANCA;
                    tipo = IDPEONB; valor = VALPEONB;

                    break;

                // Peon torre dama negro
                case PEONTDN:

                    this.pieza = pieza;
                    this.x = 0; this.y = 6;

                    color = NEGRA;
                    tipo = IDPEONN; valor = VALPEONN;

                    break;

                // Peon torre rey negro
                case PEONTRN:

                    this.pieza = pieza;
                    this.x = 7; this.y = 6;

                    color = NEGRA;
                    tipo = IDPEONN; valor = VALPEONN;

                    break;

                // Peon caballo dama negro
                case PEONCDN:

                    this.pieza = pieza;
                    this.x = 1; this.y = 6;

                    color = NEGRA;
                    tipo = IDPEONN; valor = VALPEONN;

                    break;

                // Peon caballo rey negro
                case PEONCRN:

                    this.pieza = pieza;
                    this.x = 6; this.y = 6;

                    color = NEGRA;
                    tipo = IDPEONN; valor = VALPEONN;

                    break;

                // Peon alfil dama negro
                case PEONADN:

                    this.pieza = pieza;
                    this.x = 2; this.y = 6;

                    color = NEGRA;
                    tipo = IDPEONN; valor = VALPEONN;

                    break;

                // Peon alfil rey negro
                case PEONARN:

                    this.pieza = pieza;
                    this.x = 5; this.y = 6;

                    color = NEGRA;
                    tipo = IDPEONN; valor = VALPEONN;

                    break;

                // Peon dama negro
                case PEONDN:

                    this.pieza = pieza;
                    this.x = 3; this.y = 6;

                    color = NEGRA;
                    tipo = IDPEONN; valor = VALPEONN;

                    break;

                // Peon rey negro
                case PEONRN:

                    this.pieza = pieza;
                    this.x = 4; this.y = 6;

                    color = NEGRA;
                    tipo = IDPEONN; valor = VALPEONN;

                    break;

                // Caballos

                // Caballo dama blanco
                case CABALLODB:

                    this.pieza = pieza;
                    this.x = 1; this.y = 0;

                    color = BLANCA;
                    tipo = IDCABALLOB; valor = VALCABALLOB;

                    break;

                // Caballo rey blanco
                case CABALLORB:

                    this.pieza = pieza;
                    this.x = 6; this.y = 0;

                    color = BLANCA;
                    tipo = IDCABALLOB; valor = VALCABALLOB;

                    break;

                // Caballo dama negro
                case CABALLODN:

                    this.pieza = pieza;
                    this.x = 1; this.y = 7;

                    color = NEGRA;
                    tipo = IDCABALLON; valor = VALCABALLON;

                    break;

                // Caballo rey negro
                case CABALLORN:

                    this.pieza = pieza;
                    this.x = 6; this.y = 7;

                    color = NEGRA;
                    tipo = IDCABALLON; valor = VALCABALLON;

                    break;

                // Alfiles

                // Alfil dama blanco
                case ALFILDB:

                    this.pieza = pieza;
                    this.x = 2; this.y = 0;

                    color = BLANCA;
                    tipo = IDALFILB; valor = VALALFILB;

                    break;

                // Alfil rey blanco
                case ALFILRB:

                    this.pieza = pieza;
                    this.x = 5; this.y = 0;

                    color = BLANCA;
                    tipo = IDALFILB; valor = VALALFILB;

                    break;

                // Alfil dama negro
                case ALFILDN:

                    this.pieza = pieza;
                    this.x = 2; this.y = 7;

                    color = NEGRA;
                    tipo = IDALFILN; valor = VALALFILN;

                    break;

                // Alfil rey negro
                case ALFILRN:

                    this.pieza = pieza;
                    this.x = 5; this.y = 7;

                    color = NEGRA;
                    tipo = IDALFILN; valor = VALALFILN;

                    break;

                // Torres

                // Torre dama blanco
                case TORREDB:

                    this.pieza = pieza;
                    this.x = 0; this.y = 0;

                    color = BLANCA;
                    tipo = IDTORREB; valor = VALTORREB;

                    break;

                // Torre rey blanco
                case TORRERB:

                    this.pieza = pieza;
                    this.x = 7; this.y = 0;

                    color = BLANCA;
                    tipo = IDTORREB; valor = VALTORREB;

                    break;

                // Torre dama negro
                case TORREDN:

                    this.pieza = pieza;
                    this.x = 0; this.y = 7;

                    color = NEGRA;
                    tipo = IDTORREN; valor = VALTORREN;

                    break;

                // Torre rey negro
                case TORRERN:

                    this.pieza = pieza;
                    this.x = 7; this.y = 7;

                    color = NEGRA;
                    tipo = IDTORREN; valor = VALTORREN;

                    break;

                // Damas

                // Dama blanca
                case DAMAB:

                    this.pieza = pieza;
                    this.x = 3; this.y = 0;

                    color = BLANCA;
                    tipo = IDDAMAB; valor = VALDAMAB;

                    break;

                // Dama negra
                case DAMAN:

                    this.pieza = pieza;
                    this.x = 3; this.y = 7;

                    color = NEGRA;
                    tipo = IDDAMAN; valor = VALDAMAN;

                    break;

                // Reyes

                // Rey blanco
                case REYB:

                    this.pieza = pieza;
                    this.x = 4; this.y = 0;

                    color = BLANCA;
                    tipo = IDREYB; valor = VALREYB;

                    break;

                // Rey negro
                case REYN:

                    this.pieza = pieza;
                    this.x = 4; this.y = 7;

                    color = NEGRA;
                    tipo = IDREYN; valor = VALREYN;

                    break;

                // Default

                // Pieza vacia
                default:

                    pieza = this.x = this.y = -1;
                    color = tipo = valor = 0;

                    break;
            }

            // Movimientos control
            controlV = ControlPiezaV(x, y, tablero);
            controlM = ControlPiezaM(x, y, tablero);

            // Movimientos posibles
            movimientosV = MovimientosPiezaV(x, y, me, tablero);
            movimientosM = MovimientosPiezaM(x, y, me, tablero);

            // Historial de movs
            nmovs = 0; hmovs = Chess.Vector(new int[NMOVIMIENTOS * 8], 0);

            // Ultimo mov pieza
            umov = "No movida";
        }

        // Constructor copia
        // Construye una pieza copia
        public Pieza(Pieza pieza)
        {
            // Pieza / Posicion
            this.pieza = pieza.pieza;
            x = pieza.x; y = pieza.y;

            // Color / Tipo / Valor
            color = pieza.color;
            tipo = pieza.tipo;
            valor = pieza.valor;

            // Movimientos control vector
            if (pieza.controlV != null)
            {
                controlV = Chess.Vector(new int[pieza.controlV.Length], -1);

                for (int i = 0; i < pieza.controlV.Length && pieza.controlV[i] != -1; i += 2)
                {
                    controlV[i] = pieza.controlV[i];
                    controlV[i + 1] = pieza.controlV[i + 1];
                }
            }

            // Movimientos control matriz
            if (pieza.controlM != null)
            {
                controlM = Chess.Matriz(new int[8][], 8, 0);

                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        controlM[i][j] = pieza.controlM[i][j];
                    }
                }
            }

            // Movimientos posibles vector
            if (pieza.movimientosV != null)
            {
                movimientosV = Chess.Vector(new int[pieza.movimientosV.Length], 0);

                for (int i = 0; i < pieza.movimientosV.Length && pieza.movimientosV[i] != 0; i += 8)
                {
                    movimientosV[i] = pieza.movimientosV[i];
                    movimientosV[i + 1] = pieza.movimientosV[i + 1];
                    movimientosV[i + 2] = pieza.movimientosV[i + 2];
                    movimientosV[i + 3] = pieza.movimientosV[i + 3];
                    movimientosV[i + 4] = pieza.movimientosV[i + 4];
                    movimientosV[i + 5] = pieza.movimientosV[i + 5];
                    movimientosV[i + 6] = pieza.movimientosV[i + 6];
                    movimientosV[i + 7] = pieza.movimientosV[i + 7];
                }
            }

            // Movimientos posibles matriz
            if (pieza.movimientosM != null)
            {
                movimientosM = Chess.Matriz(new int[8][], 8, 0);

                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        movimientosM[i][j] = pieza.movimientosM[i][j];
                    }
                }
            }

            // Historial de movs
            nmovs = pieza.nmovs;
            hmovs = Chess.Vector(new int[NMOVIMIENTOS * 8], 0);

            for (int i = 0; i < pieza.nmovs; i++)
            {
                hmovs[i * 8] = pieza.hmovs[i * 8];
                hmovs[i * 8 + 1] = pieza.hmovs[i * 8 + 1];
                hmovs[i * 8 + 2] = pieza.hmovs[i * 8 + 2];
                hmovs[i * 8 + 3] = pieza.hmovs[i * 8 + 3];
                hmovs[i * 8 + 4] = pieza.hmovs[i * 8 + 4];
                hmovs[i * 8 + 5] = pieza.hmovs[i * 8 + 5];
                hmovs[i * 8 + 6] = pieza.hmovs[i * 8 + 6];
                hmovs[i * 8 + 7] = pieza.hmovs[i * 8 + 7];
            }

            // Ultimo mov pieza
            umov = pieza.umov;
        }

        // Metodo ActualizarMovs
        // Actualiza los movimientos control y posibles de la pieza
        public bool ActualizarMovs(Tablero tablero)
        {
            return ControlPieza(tablero) && MovimientosPieza(tablero);
        }

        // Metodo ControlPieza
        // Calcula los movimientos control de la pieza
        private bool ControlPieza(Tablero tablero)
        {
            return ControlPiezaV(tablero) && ControlPiezaM(tablero);
        }

        // Metodo ControlPiezaV
        // Calcula vector control de la pieza
        private bool ControlPiezaV(Tablero tablero)
        {
            if (tablero != null)
            {
                controlV = ControlPiezaV(x, y, tablero.MatrizTipo());

                return true;
            }

            return false;
        }

        // Metodo ControlPiezaM
        // Calcula matriz control de la pieza
        private bool ControlPiezaM(Tablero tablero)
        {
            if (tablero != null)
            {
                controlM = ControlPiezaM(x, y, tablero.MatrizTipo());

                return true;
            }

            return false;
        }

        // Metodo NumControlPieza
        // Obtiene el numero de movimientos control de la pieza
        public int NumControlPieza()
        {
            int n = 0;

            for (int i = 0; i < controlV.Length && controlV[i] != -1; i += 2)
            {
                n++;
            }

            return n;
        }

        // Metodo MovimientosPieza
        // Calcula los movimientos posibles de la pieza
        private bool MovimientosPieza(Tablero tablero)
        {
            return MovimientosPiezaV(tablero) && MovimientosPiezaM(tablero);
        }

        // Metodo MovimientosPiezaV
        // Calcula vector movimientos de la pieza
        private bool MovimientosPiezaV(Tablero tablero)
        {
            if (tablero != null)
            {
                movimientosV = MovimientosPiezaV(x, y, tablero.me, tablero.MatrizTipo());

                return true;
            }

            return false;
        }

        // Metodo MovimientosPiezaM
        // Calcula matriz movimientos de la pieza
        private bool MovimientosPiezaM(Tablero tablero)
        {
            if (tablero != null)
            {
                movimientosM = MovimientosPiezaM(x, y, tablero.me, tablero.MatrizTipo());

                return true;
            }

            return false;
        }

        // Metodo NumMovimientosPieza
        // Obtiene el numero de movimientos posibles de la pieza
        public int NumMovimientosPieza()
        {
            int n = 0;

            for (int i = 0; i < movimientosV.Length && movimientosV[i] != 0; i += 8)
            {
                n++;
            }

            return n;
        }

        // Metodo Mover
        // Mueve la pieza a la casilla dada
        public bool Mover(int x, int y, int me, int pe, Tablero tablero)
        {
            if (x >= 0 && x <= 7 && y >= 0 && y <= 7 && tablero != null && movimientosM[x][y] == 1)
            {
                // Historial de movs
                hmovs[nmovs * 8] = tipo;
                hmovs[nmovs * 8 + 1] = this.x;
                hmovs[nmovs * 8 + 2] = this.y;
                hmovs[nmovs * 8 + 3] = 0;
                hmovs[nmovs * 8 + 4] = x;
                hmovs[nmovs * 8 + 5] = y;
                hmovs[nmovs * 8 + 6] = 0;
                hmovs[nmovs * 8 + 7] = 0;

                // Movimiento NORMAL
                MoverNORMAL(x, y, tablero);

                // Movimientos ESPECIALES
                switch (me)
                {
                    // Movimiento ALPASO
                    case Tablero.ALPASO:
                        MoverALPASO(x, y, tablero);
                        hmovs[nmovs * 8 + 6] = Tablero.ALPASO;
                        break;

                    // Movimiento ENROQUEC
                    case Tablero.ENROQUEC:
                        MoverENROQUEC(x, y, tablero);
                        hmovs[nmovs * 8 + 6] = Tablero.ENROQUEC;
                        break;

                    // Movimiento ENROQUEL
                    case Tablero.ENROQUEL:
                        MoverENROQUEL(x, y, tablero);
                        hmovs[nmovs * 8 + 6] = Tablero.ENROQUEL;
                        break;

                    // Movimiento CORONA
                    case Tablero.CORONA:
                        MoverCORONA(x, y, pe, tablero);
                        hmovs[nmovs * 8 + 6] = Tablero.CORONA;
                        break;
                }

                // Ultimo mov pieza
                umov = Chess.NotacionAlgebraicaL (hmovs[nmovs * 8], hmovs[nmovs * 8 + 1], hmovs[nmovs * 8 + 2], hmovs[nmovs * 8 + 3], 
                    hmovs[nmovs * 8 + 4], hmovs[nmovs * 8 + 5], hmovs[nmovs * 8 + 6], hmovs[nmovs * 8 + 7], 0, 0);

                nmovs++;

                return true;
            }

            return false;
        }

        // Metodo MoverNORMAL
        // Mueve la pieza a la casilla dada (NORMAL)
        private void MoverNORMAL(int x, int y, Tablero tablero)
        {
            // Captura
            if (tablero.matriz[x][y] != null)
            {
                Pieza pieza = tablero.matriz[x][y];
                pieza.x = pieza.y = -1;

                pieza.controlV = pieza.movimientosV = null;
                pieza.controlM = pieza.movimientosM = null;

                hmovs[nmovs * 8 + 3] = pieza.tipo;
            }

            // Movimiento
            tablero.matriz[x][y] = tablero.matriz[this.x][this.y];
            tablero.matriz[this.x][this.y] = null;

            this.x = x; this.y = y;
        }

        // Metodo MoverALPASO
        // Mueve la pieza a la casilla dada (ALPASO)
        private void MoverALPASO(int x, int y, Tablero tablero)
        {
            if (color == BLANCA)
            {
                Pieza pieza = tablero.matriz[x][y - 1];

                pieza.x = pieza.y = -1;
                pieza.controlV = pieza.movimientosV = null;
                pieza.controlM = pieza.movimientosM = null;

                tablero.matriz[x][y - 1] = null;

                hmovs[nmovs * 8 + 7] = x;
            }
            else if (color == NEGRA)
            {
                Pieza pieza = tablero.matriz[x][y + 1];

                pieza.x = pieza.y = -1;
                pieza.controlV = pieza.movimientosV = null;
                pieza.controlM = pieza.movimientosM = null;

                tablero.matriz[x][y + 1] = null;

                hmovs[nmovs * 8 + 7] = x;
            }
        }

        // Metodo MoverENROQUEC
        // Mueve la pieza a la casilla dada (ENROQUEC)
        private void MoverENROQUEC(int x, int y, Tablero tablero)
        {
            Pieza pieza = tablero.matriz[x + 1][y];
            pieza.x = 5;

            tablero.matriz[5][y] = tablero.matriz[x + 1][y];
            tablero.matriz[x + 1][y] = null;
        }

        // Metodo MoverENROQUEL
        // Mueve la pieza a la casilla dada (ENROQUEL)
        private void MoverENROQUEL(int x, int y, Tablero tablero)
        {
            Pieza pieza = tablero.matriz[x - 2][y];
            pieza.x = 3;

            tablero.matriz[3][y] = tablero.matriz[x - 2][y];
            tablero.matriz[x - 2][y] = null;
        }

        // Metodo MoverCORONA
        // Mueve la pieza a la casilla dada (CORONA)
        private void MoverCORONA(int x, int y, int pe, Tablero tablero)
        {
            tipo = pe;
            valor = Pieza.Valor(pe);

            hmovs[nmovs * 8 + 7] = pe;
        }

        # endregion
    }
}