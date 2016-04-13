using System;

namespace UAChess
{
    public class Tablero
    {
        # region Constantes

        // Max movimientos en historial
        public const int NMOVIMIENTOS = 10000;

        // Movimientos
        public const int NORMAL = 0;
        public const int ALPASO = 1;
        public const int ENROQUEC = 2;
        public const int ENROQUEL = 3;
        public const int CORONA = 4;

        # endregion

        # region Atributos

        // Peones
        public Pieza peonTDB, peonTRB, peonCDB, peonCRB;
        public Pieza peonADB, peonARB, peonDB, peonRB;

        public Pieza peonTDN, peonTRN, peonCDN, peonCRN;
        public Pieza peonADN, peonARN, peonDN, peonRN;

        // Caballos
        public Pieza caballoDB, caballoRB;
        public Pieza caballoDN, caballoRN;

        // Alfiles
        public Pieza alfilDB, alfilRB;
        public Pieza alfilDN, alfilRN;

        // Torres
        public Pieza torreDB, torreRB;
        public Pieza torreDN, torreRN;

        // Damas / Reyes
        public Pieza damaB, damaN;
        public Pieza reyB, reyN;

        // Turno / Puntos
        public int turno;
        public int nturnosB, nturnosN;
        public int puntosB, puntosN;

        // Tablero vector / matriz
        public Pieza[] vector;
        public Pieza[][] matriz;

        // Vector movs especiales
        // [[umov], [nreytorreb], [nreytorren]
        public int[] me;

        // Historial de movs
        // [po, xo, yo, pd, xd, yd, me, pe, j, jm, ...]
        public int nmovs;
        public int[] hmovs;

        // Estadistica num control / movs
        public int ncontrolB, ncontrolN;
        public int nmovsB, nmovsN;

        // Estadistica coeficientes
        public float ataqueB, ataqueN;
        public float defensaB, defensaN;
        public float movilidadB, movilidadN;

        # endregion

        # region Metodos Estaticos

        // Metodo ControlCasilla
        // Obtiene piezas de color c con movimientos control a casilla dada
        static public int[] ControlCasilla(int x, int y, int c, int[][] tablero)
        {
            int n = 0;
            int[] piezas = Chess.Vector(new int[32 * 2], -1);

            if (x >= 0 && x <= 7 && y >= 0 && y <= 7 && (c == Pieza.BLANCA || c == Pieza.NEGRA || c == 0) && tablero != null)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (tablero[i][j] * c >= 0)
                        {
                            int[][] control = Pieza.ControlPiezaM(i, j, tablero);

                            if (control != null && control[x][y] == 1)
                            {
                                piezas[n] = i;
                                piezas[n + 1] = j;
                                n += 2;
                            }
                        }
                    }
                }
            }

            return piezas;
        }

        // Metodo NumControlCasilla
        // Obtiene num piezas de color c con movimientos control a casilla dada
        static public int NumControlCasilla(int x, int y, int c, int[][] tablero)
        {
            int n = 0;

            int[] piezas = ControlCasilla(x, y, c, tablero);

            for (int i = 0; i < piezas.Length && piezas[i] != -1; i += 2)
            {
                n++;
            }

            return n;
        }

        // Metodo MovimientosCasilla
        // Obtiene piezas de color c con movimientos posibles a casilla dada
        static public int[] MovimientosCasilla(int x, int y, int c, int[] me, int[][] tablero)
        {
            int n = 0;
            int[] piezas = Chess.Vector(new int[32 * 2], -1);

            if (x >= 0 && x <= 7 && y >= 0 && y <= 7 && (c == Pieza.BLANCA || c == Pieza.NEGRA || c == 0) && me != null && tablero != null)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (tablero[i][j] * c >= 0)
                        {
                            int[][] movs = Pieza.MovimientosPiezaM(i, j, me, tablero);

                            if (movs != null && movs[x][y] == 1)
                            {
                                piezas[n] = i;
                                piezas[n + 1] = j;
                                n += 2;
                            }
                        }
                    }
                }
            }

            return piezas;
        }

        // Metodo NumMovimientosCasilla
        // Obtiene num piezas de color c con movimientos posibles a casilla dada
        static public int NumMovimientosCasilla(int x, int y, int c, int[] me, int[][] tablero)
        {
            int n = 0;

            int[] piezas = MovimientosCasilla(x, y, c, me, tablero);

            for (int i = 0; i < piezas.Length && piezas[i] != -1; i += 2)
            {
                n++;
            }

            return n;
        }

        // Metodo ControlTablero
        // Obtiene todos los movimientos control de piezas de color c del tablero
        static public int[] ControlTablero(int c, int[][] tablero)
        {
            int n = 0;
            int[] controlTotal = Chess.Vector(new int[10000 * 2], -1);

            if ((c == Pieza.BLANCA || c == Pieza.NEGRA || c == 0) && tablero != null)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (tablero[i][j] * c >= 0)
                        {
                            int[] control = Pieza.ControlPiezaV(i, j, tablero);

                            for (int k = 0; control != null && k < control.Length && control[k] != -1; k += 2)
                            {
                                controlTotal[n] = control[k];
                                controlTotal[n + 1] = control[k + 1];
                                n += 2;
                            }
                        }
                    }
                }
            }

            return controlTotal;
        }

        // Metodo NumControlTablero
        // Obtiene num de todos los movimientos control de piezas de color c del tablero
        static public int NumControlTablero(int c, int[][] tablero)
        {
            int n = 0;

            int[] control = ControlTablero(c, tablero);

            for (int i = 0; i < control.Length && control[i] != -1; i += 2)
            {
                n++;
            }

            return n;
        }

        // Metodo MovimientosTablero
        // Obtiene todos los movimientos posibles de piezas de color c del tablero
        static public int[] MovimientosTablero(int c, int[] me, int[][] tablero)
        {
            int n = 0;
            int[] movsTotal = Chess.Vector(new int[10000 * 8], 0);

            if ((c == Pieza.BLANCA || c == Pieza.NEGRA || c == 0) && me != null && tablero != null)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (tablero[i][j] * c >= 0)
                        {
                            int[] movs = Pieza.MovimientosPiezaV(i, j, me, tablero);

                            for (int k = 0; movs != null && k < movs.Length && movs[k] != 0; k += 8)
                            {
                                movsTotal[n] = movs[k];
                                movsTotal[n + 1] = movs[k + 1];
                                movsTotal[n + 2] = movs[k + 2];
                                movsTotal[n + 3] = movs[k + 3];
                                movsTotal[n + 4] = movs[k + 4];
                                movsTotal[n + 5] = movs[k + 5];
                                movsTotal[n + 6] = movs[k + 6];
                                movsTotal[n + 7] = movs[k + 7];
                                n += 8;
                            }
                        }
                    }
                }
            }

            return movsTotal;
        }

        // Metodo NumMovimientosTablero
        // Obtiene num de todos los movimientos posibles de piezas de color c del tablero
        static public int NumMovimientosTablero(int c, int[] me, int[][] tablero)
        {
            int n = 0;

            int[] movs = MovimientosTablero(c, me, tablero);

            for (int i = 0; i < movs.Length && movs[i] != 0; i += 8)
            {
                n++;
            }

            return n;
        }

        // Metodo ValorTablero
        // Obtiene el valor total de las piezas de color c del tablero
        static public int ValorTablero(int c, int[][] tablero)
        {
            int valor = 0;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (tablero[i][j] * c >= 0)
                    {
                        switch (Math.Abs(tablero[i][j]))
                        {
                            // Peon
                            case Pieza.IDPEONB:
                                valor += Pieza.VALPEONB;
                                break;

                            // Caballo
                            case Pieza.IDCABALLOB:
                                valor += Pieza.VALCABALLOB;
                                break;

                            // Alfil
                            case Pieza.IDALFILB:
                                valor += Pieza.VALALFILB;
                                break;

                            // Torre
                            case Pieza.IDTORREB:
                                valor += Pieza.VALTORREB;
                                break;

                            // Dama
                            case Pieza.IDDAMAB:
                                valor += Pieza.VALDAMAB;
                                break;
                        }
                    }
                }
            }

            return valor;
        }

        // Metodo Jaque
        // Indica si rey dado esta en jaque
        static public bool Jaque(int c, int[][] tablero)
        {
            if ((c == Pieza.BLANCA || c == Pieza.NEGRA) && tablero != null)
            {
                // Posicion rey
                int x, y; x = y = -1;

                for (int i = 0; i < 8 && x == -1 && y == -1; i++)
                {
                    for (int j = 0; j < 8 && x == -1 && y == -1; j++)
                    {
                        if (tablero[i][j] * c == Pieza.IDREYB) { x = i; y = j; }
                    }
                }

                // Comprobar jaque
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (tablero[i][j] * c < 0)
                        {
                            if (Pieza.ControlPiezaM(i, j, tablero)[x][y] == 1) { return true; }
                        }
                    }
                }
            }

            return false;
        }

        // Metodo JaqueMate
        // Indica si rey dado esta en jaque mate
        static public bool JaqueMate(int c, int[] me, int[][] tablero)
        {
            if ((c == Pieza.BLANCA || c == Pieza.NEGRA) && me != null && tablero != null)
            {
                if (Jaque(c, tablero) && MovimientosTablero(c, me, tablero)[0] == 0) { return true; }
            }

            return false;
        }

        # endregion

        # region Metodos Instancia

        // Constructor
        // Construye el tablero
        public Tablero()
        {
            // Peones
            peonTDB = new Pieza(Pieza.PEONTDB);
            peonTRB = new Pieza(Pieza.PEONTRB);
            peonCDB = new Pieza(Pieza.PEONCDB);
            peonCRB = new Pieza(Pieza.PEONCRB);
            peonADB = new Pieza(Pieza.PEONADB);
            peonARB = new Pieza(Pieza.PEONARB);
            peonDB = new Pieza(Pieza.PEONDB);
            peonRB = new Pieza(Pieza.PEONRB);

            peonTDN = new Pieza(Pieza.PEONTDN);
            peonTRN = new Pieza(Pieza.PEONTRN);
            peonCDN = new Pieza(Pieza.PEONCDN);
            peonCRN = new Pieza(Pieza.PEONCRN);
            peonADN = new Pieza(Pieza.PEONADN);
            peonARN = new Pieza(Pieza.PEONARN);
            peonDN = new Pieza(Pieza.PEONDN);
            peonRN = new Pieza(Pieza.PEONRN);

            // Caballos
            caballoDB = new Pieza(Pieza.CABALLODB);
            caballoRB = new Pieza(Pieza.CABALLORB);
            caballoDN = new Pieza(Pieza.CABALLODN);
            caballoRN = new Pieza(Pieza.CABALLORN);

            // Alfiles
            alfilDB = new Pieza(Pieza.ALFILDB);
            alfilRB = new Pieza(Pieza.ALFILRB);
            alfilDN = new Pieza(Pieza.ALFILDN);
            alfilRN = new Pieza(Pieza.ALFILRN);

            // Torres
            torreDB = new Pieza(Pieza.TORREDB);
            torreRB = new Pieza(Pieza.TORRERB);
            torreDN = new Pieza(Pieza.TORREDN);
            torreRN = new Pieza(Pieza.TORRERN);

            // Damas
            damaB = new Pieza(Pieza.DAMAB);
            damaN = new Pieza(Pieza.DAMAN);

            // Reyes
            reyB = new Pieza(Pieza.REYB);
            reyN = new Pieza(Pieza.REYN);

            // Turno / Puntos
            turno = Pieza.BLANCA;
            nturnosB = nturnosN = 0;
            puntosB = puntosN = 0;

            // Tablero vector
            vector = new Pieza[32]
            {
                peonTDB, peonTRB, peonCDB, peonCRB, peonADB, peonARB, peonDB, peonRB,
                caballoDB, caballoRB, alfilDB, alfilRB, torreDB, torreRB, damaB, reyB,
                peonTDN, peonTRN, peonCDN, peonCRN, peonADN, peonARN, peonDN, peonRN,
                caballoDN, caballoRN, alfilDN, alfilRN, torreDN, torreRN, damaN, reyN
            };

            // Tablero matriz
            matriz = new Pieza[8][];

            matriz[0] = new Pieza[8] { torreDB, peonTDB, null, null, null, null, peonTDN, torreDN };
            matriz[1] = new Pieza[8] { caballoDB, peonCDB, null, null, null, null, peonCDN, caballoDN };
            matriz[2] = new Pieza[8] { alfilDB, peonADB, null, null, null, null, peonADN, alfilDN };
            matriz[3] = new Pieza[8] { damaB, peonDB, null, null, null, null, peonDN, damaN };
            matriz[4] = new Pieza[8] { reyB, peonRB, null, null, null, null, peonRN, reyN };
            matriz[5] = new Pieza[8] { alfilRB, peonARB, null, null, null, null, peonARN, alfilRN };
            matriz[6] = new Pieza[8] { caballoRB, peonCRB, null, null, null, null, peonCRN, caballoRN };
            matriz[7] = new Pieza[8] { torreRB, peonTRB, null, null, null, null, peonTRN, torreRN };

            // Vector movs especiales inicial
            // [po, xo, yo, pd, xd, yd, me, pe, nreyb, ntorredb, ntorredr, nreyn, ntorredn, ntorrern]
            me = Chess.Vector(new int[14], 0);

            // Historial de movs
            nmovs = 0; hmovs = Chess.Vector(new int[NMOVIMIENTOS * 10], 0);

            // Estadisticas

            // Num casillas controladas
            ncontrolB = NumControlTablero(Pieza.BLANCA);
            ncontrolN = NumControlTablero(Pieza.NEGRA);

            // Num movimientos posibles
            nmovsB = NumMovimientosTablero(Pieza.BLANCA);
            nmovsN = NumMovimientosTablero(Pieza.NEGRA);

            // Coeficientes

            // Ataque
            ataqueB = (ncontrolB / 64.0f) * 100;
            ataqueN = (ncontrolN / 64.0f) * 100;

            // Defensa
            defensaB = (ValorTablero(Pieza.BLANCA) / 39.0f) * 100;
            defensaN = (ValorTablero(Pieza.NEGRA) / 39.0f) * 100;

            // Movilidad
            movilidadB = (nmovsB / 64.0f) * 100;
            movilidadN = (nmovsN / 64.0f) * 100;
        }

        // Constructor copia
        // Construye un tablero copia
        public Tablero(Tablero tablero)
        {
            // Peones
            peonTDB = new Pieza(tablero.peonTDB);
            peonTRB = new Pieza(tablero.peonTRB);
            peonCDB = new Pieza(tablero.peonCDB);
            peonCRB = new Pieza(tablero.peonCRB);
            peonADB = new Pieza(tablero.peonADB);
            peonARB = new Pieza(tablero.peonARB);
            peonDB = new Pieza(tablero.peonDB);
            peonRB = new Pieza(tablero.peonRB);

            peonTDN = new Pieza(tablero.peonTDN);
            peonTRN = new Pieza(tablero.peonTRN);
            peonCDN = new Pieza(tablero.peonCDN);
            peonCRN = new Pieza(tablero.peonCRN);
            peonADN = new Pieza(tablero.peonADN);
            peonARN = new Pieza(tablero.peonARN);
            peonDN = new Pieza(tablero.peonDN);
            peonRN = new Pieza(tablero.peonRN);

            // Caballos
            caballoDB = new Pieza(tablero.caballoDB);
            caballoRB = new Pieza(tablero.caballoRB);
            caballoDN = new Pieza(tablero.caballoDN);
            caballoRN = new Pieza(tablero.caballoRN);

            // Alfiles
            alfilDB = new Pieza(tablero.alfilDB);
            alfilRB = new Pieza(tablero.alfilRB);
            alfilDN = new Pieza(tablero.alfilDN);
            alfilRN = new Pieza(tablero.alfilRN);

            // Torres
            torreDB = new Pieza(tablero.torreDB);
            torreRB = new Pieza(tablero.torreRB);
            torreDN = new Pieza(tablero.torreDN);
            torreRN = new Pieza(tablero.torreRN);

            // Damas
            damaB = new Pieza(tablero.damaB);
            damaN = new Pieza(tablero.damaN);

            // Reyes
            reyB = new Pieza(tablero.reyB);
            reyN = new Pieza(tablero.reyN);

            // Turno / Puntos
            turno = tablero.turno;
            nturnosB = tablero.nturnosB;
            nturnosN = tablero.nturnosN;
            puntosB = tablero.puntosB;
            puntosN = tablero.puntosN;

            // Tablero vector
            vector = new Pieza[32]
            {
                peonTDB, peonTRB, peonCDB, peonCRB, peonADB, peonARB, peonDB, peonRB,
                caballoDB, caballoRB, alfilDB, alfilRB, torreDB, torreRB, damaB, reyB,
                peonTDN, peonTRN, peonCDN, peonCRN, peonADN, peonARN, peonDN, peonRN,
                caballoDN, caballoRN, alfilDN, alfilRN, torreDN, torreRN, damaN, reyN
            };

            // Tablero matriz
            matriz = new Pieza[8][];

            for (int i = 0; i < 8; i++)
            {
                matriz[i] = new Pieza[8];

                for (int j = 0; j < 8; j++)
                {
                    if (tablero.matriz[i][j] != null)
                    {
                        matriz[i][j] = vector[tablero.matriz[i][j].pieza];
                    }
                    else
                    {
                        matriz[i][j] = null;
                    }
                }
            }

            // Vector movs especiales
            me = Chess.Vector(new int[tablero.me.Length], 0);

            for (int i = 0; i < tablero.me.Length; i++)
            {
                me[i] = tablero.me[i];
            }

            // Historial de movs
            nmovs = tablero.nmovs;
            hmovs = Chess.Vector(new int[NMOVIMIENTOS * 10], 0);

            for (int i = 0; i < tablero.nmovs; i++)
            {
                hmovs[i * 10] = tablero.hmovs[i * 10];
                hmovs[i * 10 + 1] = tablero.hmovs[i * 10 + 1];
                hmovs[i * 10 + 2] = tablero.hmovs[i * 10 + 2];
                hmovs[i * 10 + 3] = tablero.hmovs[i * 10 + 3];
                hmovs[i * 10 + 4] = tablero.hmovs[i * 10 + 4];
                hmovs[i * 10 + 5] = tablero.hmovs[i * 10 + 5];
                hmovs[i * 10 + 6] = tablero.hmovs[i * 10 + 6];
                hmovs[i * 10 + 7] = tablero.hmovs[i * 10 + 7];
                hmovs[i * 10 + 8] = tablero.hmovs[i * 10 + 8];
                hmovs[i * 10 + 9] = tablero.hmovs[i * 10 + 9];
            }

            // Estadisticas

            // Num casillas controladas
            ncontrolB = tablero.ncontrolB;
            ncontrolN = tablero.ncontrolN;

            // Num movimientos posibles
            nmovsB = tablero.nmovsB;
            nmovsN = tablero.nmovsN;

            // Coeficientes

            // Ataque
            ataqueB = tablero.ataqueB;
            ataqueN = tablero.ataqueN;

            // Defensa
            defensaB = tablero.defensaB;
            defensaN = tablero.defensaN;

            // Movilidad
            movilidadB = tablero.movilidadB;
            movilidadN = tablero.movilidadN;
        }

        // Metodo MatrizTipo
        // Obtiene la matriz tipo del tablero
        public int[][] MatrizTipo()
        {
            int[][] tablero = new int[8][];

            for (int i = 0; i < 8; i++)
            {
                tablero[i] = new int[8];

                for (int j = 0; j < 8; j++)
                {
                    if (matriz[i][j] != null)
                    {
                        tablero[i][j] = matriz[i][j].tipo;
                    }
                    else
                    {
                        tablero[i][j] = 0;
                    }
                }
            }

            return tablero;
        }

        // Metodo MatrizValor
        // Obtiene la matriz valor del tablero
        public int[][] MatrizValor()
        {
            int[][] tablero = new int[8][];

            for (int i = 0; i < 8; i++)
            {
                tablero[i] = new int[8];

                for (int j = 0; j < 8; j++)
                {
                    if (matriz[i][j] != null)
                    {
                        tablero[i][j] = matriz[i][j].valor;
                    }
                    else
                    {
                        tablero[i][j] = 0;
                    }
                }
            }

            return tablero;
        }

        // Metodo ActualizarMovs
        // Actualiza los movimientos control y posibles de las piezas
        public bool ActualizarMovs()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (matriz[i][j] != null)
                    {
                        if (!matriz[i][j].ActualizarMovs(this)) { return false; };
                    }
                }
            }

            return true;
        }

        // Metodo ControlCasilla
        // Obtiene piezas de color c con movimientos control a casilla dada
        public Pieza[] ControlCasilla(int x, int y, int c)
        {
            int n = 0;
            Pieza[] piezas = new Pieza[32];

            if (x >= 0 && x <= 7 && y >= 0 && y <= 7 && (c == Pieza.BLANCA || c == Pieza.NEGRA || c == 0))
            {
                int[] control = ControlCasilla(x, y, c, this.MatrizTipo());

                for (int i = 0; i < control.Length && control[i] != -1; i += 2)
                {
                    piezas[n++] = matriz[control[i]][control[i + 1]];
                }
            }

            return piezas;
        }

        // Metodo NumControlCasilla
        // Obtiene num piezas de color c con movimientos control a casilla dada
        public int NumControlCasilla(int x, int y, int c)
        {
            return NumControlCasilla(x, y, c, this.MatrizTipo());
        }

        // Metodo MovimientosCasilla
        // Obtiene piezas de color c con movimientos posibles a casilla dada
        public Pieza[] MovimientosCasilla(int x, int y, int c)
        {
            int n = 0;
            Pieza[] piezas = new Pieza[32];

            if (x >= 0 && x <= 7 && y >= 0 && y <= 7 && (c == Pieza.BLANCA || c == Pieza.NEGRA || c == 0))
            {
                int[] movs = MovimientosCasilla(x, y, c, me, this.MatrizTipo());

                for (int i = 0; i < movs.Length && movs[i] != -1; i += 2)
                {
                    piezas[n++] = matriz[movs[i]][movs[i + 1]];
                }
            }

            return piezas;
        }

        // Metodo NumMovimientosCasilla
        // Obtiene num piezas de color c con movimientos posibles a casilla dada
        public int NumMovimientosCasilla(int x, int y, int c)
        {
            return NumMovimientosCasilla(x, y, c, me, this.MatrizTipo());
        }

        // Metodo ControlTablero
        // Obtiene todos los movimientos control de piezas de color c del tablero
        public int[] ControlTablero(int c)
        {
            return ControlTablero(c, this.MatrizTipo());
        }

        // Metodo NumControlTablero
        // Obtiene num de todos los movimientos control de piezas de color c del tablero
        public int NumControlTablero(int c)
        {
            return NumControlTablero(c, this.MatrizTipo());
        }

        // Metodo MovimientosTablero
        // Obtiene todos los movimientos posibles de piezas de color c del tablero
        public int[] MovimientosTablero(int c)
        {
            return MovimientosTablero(c, me, this.MatrizTipo());
        }

        // Metodo NumMovimientosTablero
        // Obtiene num de todos los movimientos posibles de piezas de color c del tablero
        public int NumMovimientosTablero(int c)
        {
            return NumMovimientosTablero(c, me, this.MatrizTipo());
        }

        // Metodo ValorTablero
        // Obtiene el valor total de las piezas de color c del tablero
        public int ValorTablero(int c)
        {
            return ValorTablero(c, this.MatrizTipo());
        }

        // Metodo Jaque
        // Indica si rey dado esta en jaque
        public bool Jaque(int c)
        {
            return Jaque(c, this.MatrizTipo());
        }

        // Metodo JaqueMate
        // Indica si rey dado esta en jaque mate
        public bool JaqueMate(int c)
        {
            return JaqueMate(c, me, this.MatrizTipo());
        }

        // Metodo Mover
        // Mueve la pieza a la casilla dada
        public bool Mover(Pieza pieza, int x, int y, int me, int pe)
        {
            if (pieza.Mover(x, y, me, pe, this))
            {
                // Historial de movs
                hmovs[nmovs * 10] = pieza.hmovs[(pieza.nmovs - 1) * 8];
                hmovs[nmovs * 10 + 1] = pieza.hmovs[(pieza.nmovs - 1) * 8 + 1];
                hmovs[nmovs * 10 + 2] = pieza.hmovs[(pieza.nmovs - 1) * 8 + 2];
                hmovs[nmovs * 10 + 3] = pieza.hmovs[(pieza.nmovs - 1) * 8 + 3];
                hmovs[nmovs * 10 + 4] = pieza.hmovs[(pieza.nmovs - 1) * 8 + 4];
                hmovs[nmovs * 10 + 5] = pieza.hmovs[(pieza.nmovs - 1) * 8 + 5];
                hmovs[nmovs * 10 + 6] = pieza.hmovs[(pieza.nmovs - 1) * 8 + 6];
                hmovs[nmovs * 10 + 7] = pieza.hmovs[(pieza.nmovs - 1) * 8 + 7];

                // Turno / Puntos
                if (turno == Pieza.BLANCA)
                {
                    puntosB += Math.Abs(Pieza.Valor(hmovs[nmovs * 10 + 3]));

                    if (hmovs[nmovs * 10 + 6] == ALPASO)
                    {
                        puntosB += Math.Abs(Pieza.VALPEONB);
                    }

                    nturnosB++;
                    turno = Pieza.NEGRA;
                }
                else if (turno == Pieza.NEGRA)
                {
                    puntosN += Math.Abs(Pieza.Valor(hmovs[nmovs * 10 + 3]));

                    if (hmovs[nmovs * 10 + 6] == ALPASO)
                    {
                        puntosN += Math.Abs(Pieza.VALPEONN);
                    }

                    nturnosN++;
                    turno = Pieza.BLANCA;
                }

                // Vector movs especiales
                this.me[0] = hmovs[nmovs * 10];
                this.me[1] = hmovs[nmovs * 10 + 1];
                this.me[2] = hmovs[nmovs * 10 + 2];
                this.me[3] = hmovs[nmovs * 10 + 3];
                this.me[4] = hmovs[nmovs * 10 + 4];
                this.me[5] = hmovs[nmovs * 10 + 5];
                this.me[6] = hmovs[nmovs * 10 + 6];
                this.me[7] = hmovs[nmovs * 10 + 7];
                this.me[8] = reyB.nmovs;
                this.me[9] = torreDB.nmovs;
                this.me[10] = torreRB.nmovs;
                this.me[11] = reyN.nmovs;
                this.me[12] = torreDN.nmovs;
                this.me[13] = torreRN.nmovs;

                // Jaque
                hmovs[nmovs * 10 + 8] = 0;
                if (Jaque(pieza.color * -1)) { hmovs[nmovs * 10 + 8] = 1; }

                // Jaque mate
                hmovs[nmovs * 10 + 9] = 0;
                if (JaqueMate(pieza.color * -1)) { hmovs[nmovs * 10 + 9] = 1; }

                // Actualizar movimientos
                ActualizarMovs();
                nmovs++;

                // Estadisticas

                // Num casillas controladas
                ncontrolB = NumControlTablero(Pieza.BLANCA);
                ncontrolN = NumControlTablero(Pieza.NEGRA);

                // Num movimientos posibles
                nmovsB = NumMovimientosTablero(Pieza.BLANCA);
                nmovsN = NumMovimientosTablero(Pieza.NEGRA);

                // Coeficientes

                // Ataque
                ataqueB = (ncontrolB / 64.0f) * 100;
                ataqueN = (ncontrolN / 64.0f) * 100;

                // Defensa
                defensaB = (ValorTablero(Pieza.BLANCA) / 39.0f) * 100;
                defensaN = (ValorTablero(Pieza.NEGRA) / 39.0f) * 100;

                // Movilidad
                movilidadB = (nmovsB / 64.0f) * 100;
                movilidadN = (nmovsN / 64.0f) * 100;

                return true;
            }

            return false;
        }

        # endregion
    }
}