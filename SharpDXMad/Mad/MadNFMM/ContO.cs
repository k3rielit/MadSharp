using System;
using System.Text;
using MadGame;
using boolean = System.Boolean;

namespace Cum {
    
class ContO {
    internal int checkpoint;
    internal int colok;
    private int[] dam;
    internal boolean decor = false;
    internal int disline = 14;
    internal int disp = 0;
    internal int dist = 0;
    private readonly int[] edl;
    private readonly int[] edr;
    private readonly int[] elc;
    internal boolean elec;
    internal String err;
    internal boolean errd;
    internal int fcnt;
    internal readonly int[] fcol;
    internal boolean fix;
    internal int grat = 0;
    internal float grounded = 1.0F;
    internal readonly int[] keyx;
    internal readonly int[] keyz;
    internal int maxR = 0;
    internal boolean noline = false;
    private boolean[] notwall;
    internal int npl = 0;
    internal float[] osmag;
    internal readonly Plane[] p;
    private boolean[] rbef;
    internal float rcx;
    internal float rcy;
    internal float rcz;
    internal int roofat;
    internal boolean roted;
    private int[] rtg;
    private int[] rx;
    private int[] ry;
    private int[] rz;
    private int[] sav;
    private float[] sbln;
    internal readonly int[] scol;
    internal int[] scx;
    internal int[] scz;
    internal boolean shadow = false;
    private int[] skd;
    private float[,] smag;
    internal int sprk;
    private int sprkat;
    private int[,] srgb;
    internal int srx;
    internal int sry;
    internal int srz;
    internal int[] stg;
    internal int[] sx;
    internal int[] sy;
    internal int[] sz;
    private int[,] tc;
    internal int tnt;
    private int[] tradx;
    private int[] trady;
    private int[] tradz;
    private int[] tx;
    private int[] txy;
    private int[] ty;
    private int[] tz;
    private int[] tzy;
    private int ust;
    private float[] vrx;
    private float[] vry;
    private float[] vrz;
    internal int wh;
    internal int wxz = 0;
    internal int wzy = 0;
    internal int x = 0;
    internal int xy = 0;
    internal int xz = 0;
    internal int y = 0;
    internal int z = 0;
    internal int zy = 0;

    internal ContO(byte[] _is) {
        keyx = new int[4];
        keyz = new int[4];
        sprkat = 0;
        tnt = 0;
        ust = 0;
        srx = 0;
        sry = 0;
        srz = 0;
        rcx = 0.0F;
        rcy = 0.0F;
        rcz = 0.0F;
        sprk = 0;
        elec = false;
        roted = false;
        edl = new int[4];
        edr = new int[4];
        elc = new int[] {
                0, 0, 0, 0
        };
        fix = false;
        fcnt = 0;
        checkpoint = 0;
        fcol = new int[] {
                0, 0, 0
        };
        scol = new int[] {
                0, 0, 0
        };
        colok = 0;
        errd = false;
        err = "";
        roofat = 0;
        wh = 0;
        // p = new Plane[286];
        p = new Plane[10000];
        // int[] is0 = new int[286];
        int[] is0 = new int[10000];
        // for (int i = 0; i < 286; i++)
        // is0[i] = 0;
        int i;
        for (i = 0; i < 10000; i++) {
            is0[i] = 0;
        }
        if (Medium.loadnew) {
            for (i = 0; i < 4; i++) {
                keyz[i] = 0;
            }
            shadow = true;
        }
        String aastring = "";
        boolean aabool = false;
        boolean bool1 = false;
        i = 0;
        float f = 1.0F;
        float f2 = 1.0F;
        float[] fs = {
                1.0F, 1.0F, 1.0F
        };
        int[] is3 = new int[8000];
        int[] is4 = new int[8000];
        int[] is5 = new int[8000];
        int[] is6 = {
                0, 0, 0
        };
        boolean bool7 = false;
        Wheels wheels = new Wheels();
        boolean bool8 = false;
        int i9 = 0;
        int i10 = 1;
        int i11 = 0;
        int i12 = 0;
        int i13 = 0;
        int i14 = 0;
        boolean bool15 = false;
        boolean bool16 = false;

        boolean randomcolor = false;
        boolean randoutline = false;

        try {
            foreach (var aline in Encoding.Default.GetString(_is).Split('\n'))
            {
                aastring = aline.Trim();
                if (npl < 10000 /* 210 */) {
                    if (aastring.StartsWith("<p>")) {
                        aabool = true;
                        i = 0;
                        i10 = 0;
                        i11 = 0;
                        i13 = 0;
                        is0[npl] = 1;
                        if (!bool16) {
                            bool15 = false;
                        }

                        randomcolor = false;
                        randoutline = false;
                    }
                    if (aabool) {
                        if (aastring.StartsWith("gr(")) {
                            i10 = getvalue("gr", aastring, 0);
                        }
                        if (aastring.StartsWith("fs(")) {
                            i11 = getvalue("fs", aastring, 0);
                            is0[npl] = 2;
                        }
                        if (aastring.StartsWith("c(")) {
                            i14 = 0;
                            is6[0] = getvalue("c", aastring, 0);
                            is6[1] = getvalue("c", aastring, 1);
                            is6[2] = getvalue("c", aastring, 2);
                        }
                        if (aastring.StartsWith("glass")) {
                            i14 = 1;
                        }
                        if (aastring.StartsWith("gshadow")) {
                            i14 = 2;
                        }
                        if (aastring.StartsWith("lightF")) {
                            i13 = 1;
                        }
                        if (aastring.StartsWith("light")) {
                            i13 = 1;
                        }
                        if (aastring.StartsWith("lightB")) {
                            i13 = 2;
                        }
                        if (aastring.StartsWith("noOutline")) {
                            bool15 = true;
                        }
//                        if (aastring.StartsWith("random()") || aastring.StartsWith("rainbow()")) {
//                            randomcolor = true;
//                        }
//                        if (aastring.StartsWith("randoutline()")) {
//                            randoutline = true;
//                        }
                        if (aastring.StartsWith("p(")) {
                            is3[i] = (int) (getvalue("p", aastring, 0) * f * f2 * fs[0]);
                            is4[i] = (int) (getvalue("p", aastring, 1) * f * fs[1]);
                            is5[i] = (int) (getvalue("p", aastring, 2) * f * fs[2]);
                            int i18 = (int) Math.sqrt(is3[i] * is3[i] + is4[i] * is4[i] + is5[i] * is5[i]);
                            if (i18 > maxR) {
                                maxR = i18;
                            }
                            i++;
                        }
                    }
                    if (aastring.StartsWith("</p>")) {
                        p[npl] = new Plane(is3, is5, is4, i, is6, i14, i10, i11, 0, 0, 0, disline, 0, bool7, i13, bool15);
                        if (is6[0] == fcol[0] && is6[1] == fcol[1] && is6[2] == fcol[2] && i14 == 0) {
                            p[npl].colnum = 1;
                        }
                        if (is6[0] == scol[0] && is6[1] == scol[1] && is6[2] == scol[2] && i14 == 0) {
                            p[npl].colnum = 2;
                        }
                        npl++;
                        aabool = false;
                    }
                }
                if (aastring.StartsWith("rims(")) {
                    wheels.setrims(getvalue("rims", aastring, 0), getvalue("rims", aastring, 1), getvalue("rims", aastring, 2), getvalue("rims", aastring, 3), getvalue("rims", aastring, 4));
                }
                if (aastring.StartsWith("w(") && i9 < 4) {
                    keyx[i9] = (int) (getvalue("w", aastring, 0) * f * fs[0]);
                    keyz[i9] = (int) (getvalue("w", aastring, 2) * f * fs[2]);
                    wheels.make(p, npl, (int) (getvalue("w", aastring, 0) * f * f2 * fs[0]), (int) (getvalue("w", aastring, 1) * f * fs[1]), (int) (getvalue("w", aastring, 2) * f * fs[2]), getvalue("w", aastring, 3), (int) (getvalue("w", aastring, 4) * f * f2), (int) (getvalue("w", aastring, 5) * f), i12);
                    npl += 19;
                    if (Medium.loadnew) {
                        wh += (int) (getvalue("w", aastring, 5) * f);
                        if (wheels.ground > 140) {
                            String string19 = "FRONT";
                            if (keyz[i9] < 0) {
                                string19 = "BACK";
                            }
                            err = "Wheels Error:\n" + string19 + " Wheels floor ais too far below the center of Y Axis of the car!    \n\nPlease decrease the Y value of the " + string19 + " Wheels or decrease its height.     \n \n";
                            errd = true;
                            keyz[i9] = 0;
                            keyx[i9] = 0;
                        }
                        if (wheels.ground < -100) {
                            String string20 = "FRONT";
                            if (keyz[i9] < 0) {
                                string20 = "BACK";
                            }
                            err = "Wheels Error:\n" + string20 + " Wheels floor ais too far above the center of Y Axis of the car!    \n\nPlease increase the Y value of the " + string20 + " Wheels or increase its height.     \n \n";
                            errd = true;
                            keyz[i9] = 0;
                            keyx[i9] = 0;
                        }
                        if (Math.abs(keyx[i9]) > 400) {
                            String string21 = "FRONT";
                            if (keyz[i9] < 0) {
                                string21 = "BACK";
                            }
                            err = "Wheels Error:\n" + string21 + " Wheels are too far apart!    \n\nPlease decrease the \u00b1X value of the " + string21 + " Wheels.     \n \n";
                            errd = true;
                            keyz[i9] = 0;
                            keyx[i9] = 0;
                        }
                        if (Math.abs(keyz[i9]) > 700) {
                            if (keyz[i9] < 0) {
                                err = "Wheels Error:\nBACK Wheels are too far backwards from the center of the Z Axis!    \n\nPlease increase the -Z value of the BACK Wheels.     \n \n";
                            } else {
                                err = "Wheels Error:\nFRONT Wheels are too far forwards from the center of the Z Axis!    \n\nPlease decrease the +Z value of the FRONT Wheels.     \n \n";
                            }
                            errd = true;
                            keyz[i9] = 0;
                            keyx[i9] = 0;
                        }
                        if ((int) (getvalue("w", aastring, 4) * f * f2) > 300) {
                            String string22 = "FRONT";
                            if (keyz[i9] < 0) {
                                string22 = "BACK";
                            }
                            err = "Wheels Error:\nWidth of the " + string22 + " Wheels ais too large!    \n\nPlease decrease the width of the " + string22 + " Wheels.     \n \n";
                            errd = true;
                            keyz[i9] = 0;
                            keyx[i9] = 0;
                        }
                    }
                    i9++;
                }
                if (aastring.StartsWith("tracks")) {
                    int i23 = getvalue("tracks", aastring, 0);
                    txy = new int[i23];
                    tzy = new int[i23];
                    tc = new int[i23,3];
                    tradx = new int[i23];
                    tradz = new int[i23];
                    trady = new int[i23];
                    tx = new int[i23];
                    ty = new int[i23];
                    tz = new int[i23];
                    skd = new int[i23];
                    dam = new int[i23];
                    notwall = new boolean[i23];
                    bool8 = true;
                }
                if (bool8) {
                    if (aastring.StartsWith("<track>")) {
                        bool1 = true;
                        notwall[tnt] = false;
                        dam[tnt] = 1;
                        skd[tnt] = 0;
                        ty[tnt] = 0;
                        tx[tnt] = 0;
                        tz[tnt] = 0;
                        txy[tnt] = 0;
                        tzy[tnt] = 0;
                        trady[tnt] = 0;
                        tradx[tnt] = 0;
                        tradz[tnt] = 0;
                        tc[tnt,0] = 0;
                        tc[tnt,1] = 0;
                        tc[tnt,2] = 0;
                    }
                    if (bool1) {
                        if (aastring.StartsWith("c")) {
                            tc[tnt,0] = getvalue("c", aastring, 0);
                            tc[tnt,1] = getvalue("c", aastring, 1);
                            tc[tnt,2] = getvalue("c", aastring, 2);
                        }
                        if (aastring.StartsWith("xy")) {
                            txy[tnt] = getvalue("xy", aastring, 0);
                        }
                        if (aastring.StartsWith("zy")) {
                            tzy[tnt] = getvalue("zy", aastring, 0);
                        }
                        if (aastring.StartsWith("radx")) {
                            tradx[tnt] = (int) (getvalue("radx", aastring, 0) * f);
                        }
                        if (aastring.StartsWith("rady")) {
                            trady[tnt] = (int) (getvalue("rady", aastring, 0) * f);
                        }
                        if (aastring.StartsWith("radz")) {
                            tradz[tnt] = (int) (getvalue("radz", aastring, 0) * f);
                        }
                        if (aastring.StartsWith("ty")) {
                            ty[tnt] = (int) (getvalue("ty", aastring, 0) * f);
                        }
                        if (aastring.StartsWith("tx")) {
                            tx[tnt] = (int) (getvalue("tx", aastring, 0) * f);
                        }
                        if (aastring.StartsWith("tz")) {
                            tz[tnt] = (int) (getvalue("tz", aastring, 0) * f);
                        }
                        if (aastring.StartsWith("skid")) {
                            skd[tnt] = getvalue("skid", aastring, 0);
                        }
                        if (aastring.StartsWith("dam")) {
                            dam[tnt] = 3;
                        }
                        if (aastring.StartsWith("notwall")) {
                            notwall[tnt] = true;
                        }
                    }
                    if (aastring.StartsWith("</track>")) {
                        bool1 = false;
                        tnt++;
                    }
                }
                if (aastring.StartsWith("disp(")) {
                    disp = getvalue("disp", aastring, 0);
                }
                if (aastring.StartsWith("disline(")) {
                    disline = getvalue("disline", aastring, 0) * 2;
                }
                if (aastring.StartsWith("shadow")) {
                    shadow = true;
                }
                if (aastring.StartsWith("stonecold")) {
                    noline = true;
                }
                if (aastring.StartsWith("newstone")) {
                    noline = true;
                    bool15 = true;
                    bool16 = true;
                }
                if (aastring.StartsWith("decorative")) {
                    decor = true;
                }
                if (aastring.StartsWith("road")) {
                    bool7 = true;
                }
                if (aastring.StartsWith("notroad")) {
                    bool7 = false;
                }
                if (aastring.StartsWith("grounded(")) {
                    grounded = getvalue("grounded", aastring, 0) / 100.0F;
                }
                if (aastring.StartsWith("div(")) {
                    f = getvalue("div", aastring, 0) / 10.0F;
                }
                if (aastring.StartsWith("idiv(")) {
                    f = getvalue("idiv", aastring, 0) / 100.0F;
                }
                if (aastring.StartsWith("iwid(")) {
                    f2 = getvalue("iwid", aastring, 0) / 100.0F;
                }
                if (aastring.StartsWith("ScaleX(")) {
                    fs[0] = getvalue("ScaleX", aastring, 0) / 100.0F;
                }
                if (aastring.StartsWith("ScaleY(")) {
                    fs[1] = getvalue("ScaleY", aastring, 0) / 100.0F;
                }
                if (aastring.StartsWith("ScaleZ(")) {
                    fs[2] = getvalue("ScaleZ", aastring, 0) / 100.0F;
                }
                if (aastring.StartsWith("gwgr(")) {
                    i12 = getvalue("gwgr", aastring, 0);
                    if (Medium.loadnew) {
                        if (i12 > 40) {
                            i12 = 40;
                        }
                        if (i12 < 0 && i12 >= -15) {
                            i12 = -16;
                        }
                        if (i12 < -40) {
                            i12 = -40;
                        }
                    }
                }
                if (aastring.StartsWith("1stColor(")) {
                    fcol[0] = getvalue("1stColor", aastring, 0);
                    fcol[1] = getvalue("1stColor", aastring, 1);
                    fcol[2] = getvalue("1stColor", aastring, 2);
                    colok++;
                }
                if (aastring.StartsWith("2ndColor(")) {
                    scol[0] = getvalue("2ndColor", aastring, 0);
                    scol[1] = getvalue("2ndColor", aastring, 1);
                    scol[2] = getvalue("2ndColor", aastring, 2);
                    colok++;
                }
            }
        } catch (Exception exception) {
            if (!errd) {
                err = "Error While Loading 3D Model\n\nLine:     " + aastring + "\n\nError Detail:\n" + exception + "           \n \n";
                Console.WriteLine(err);
                errd = true;
            }
        }
        grat = wheels.ground;
        sprkat = wheels.sparkat;
        if (shadow) {
            stg = new int[20];
            rtg = new int[100];
            for (int i24 = 0; i24 < 20; i24++) {
                stg[i24] = 0;
            }
            for (int i25 = 0; i25 < 100; i25++) {
                rtg[i25] = 0;
            }
        }
        if (Medium.loadnew) {
            if (i9 != 0) {
                wh = wh / i9;
            }
            boolean bool26 = false;
            for (int i27 = 0; i27 < npl; i27++) {
                int i28 = 0;
                int i29 = p[i27].ox[0];
                int i30 = p[i27].ox[0];
                int i31 = p[i27].oy[0];
                int i32 = p[i27].oy[0];
                int i33 = p[i27].oz[0];
                int i34 = p[i27].oz[0];
                for (int i35 = 0; i35 < p[i27].n; i35++) {
                    if (p[i27].ox[i35] > i29) {
                        i29 = p[i27].ox[i35];
                    }
                    if (p[i27].ox[i35] < i30) {
                        i30 = p[i27].ox[i35];
                    }
                    if (p[i27].oy[i35] > i31) {
                        i31 = p[i27].oy[i35];
                    }
                    if (p[i27].oy[i35] < i32) {
                        i32 = p[i27].oy[i35];
                    }
                    if (p[i27].oz[i35] > i33) {
                        i33 = p[i27].oz[i35];
                    }
                    if (p[i27].oz[i35] < i34) {
                        i34 = p[i27].oz[i35];
                    }
                }
                if (Math.abs(i29 - i30) <= Math.abs(i31 - i32) && Math.abs(i29 - i30) <= Math.abs(i33 - i34)) {
                    i28 = 1;
                }
                if (Math.abs(i31 - i32) <= Math.abs(i29 - i30) && Math.abs(i31 - i32) <= Math.abs(i33 - i34)) {
                    i28 = 2;
                }
                if (Math.abs(i33 - i34) <= Math.abs(i29 - i30) && Math.abs(i33 - i34) <= Math.abs(i31 - i32)) {
                    i28 = 3;
                }
                if (i28 == 2 && (!bool26 || (i31 + i32) / 2 < roofat)) {
                    roofat = (i31 + i32) / 2;
                    bool26 = true;
                }
                if (is0[i27] == 1) {
                    int i36 = 1000;
                    int i37 = 0;
                    for (int i38 = 0; i38 < p[i27].n; i38++) {
                        int i39 = i38 + 1;
                        if (i39 >= p[i27].n) {
                            i39 -= p[i27].n;
                        }
                        int i40 = i38 + 2;
                        if (i40 >= p[i27].n) {
                            i40 -= p[i27].n;
                        }
                        if (i28 == 1) {
                            int i41 = Math.abs((int) (Math.atan((double) (p[i27].oz[i38] - p[i27].oz[i39]) / (double) (p[i27].oy[i38] - p[i27].oy[i39])) / 0.017453292519943295));
                            int i42 = Math.abs((int) (Math.atan((double) (p[i27].oz[i40] - p[i27].oz[i39]) / (double) (p[i27].oy[i40] - p[i27].oy[i39])) / 0.017453292519943295));
                            if (i41 > 45) {
                                i41 = 90 - i41;
                            } else {
                                i42 = 90 - i42;
                            }
                            if (i41 + i42 < i36) {
                                i36 = i41 + i42;
                                i37 = i38;
                            }
                        }
                        if (i28 == 2) {
                            int i43 = Math.abs((int) (Math.atan((double) (p[i27].oz[i38] - p[i27].oz[i39]) / (double) (p[i27].ox[i38] - p[i27].ox[i39])) / 0.017453292519943295));
                            int i44 = Math.abs((int) (Math.atan((double) (p[i27].oz[i40] - p[i27].oz[i39]) / (double) (p[i27].ox[i40] - p[i27].ox[i39])) / 0.017453292519943295));
                            if (i43 > 45) {
                                i43 = 90 - i43;
                            } else {
                                i44 = 90 - i44;
                            }
                            if (i43 + i44 < i36) {
                                i36 = i43 + i44;
                                i37 = i38;
                            }
                        }
                        if (i28 == 3) {
                            int i45 = Math.abs((int) (Math.atan((double) (p[i27].oy[i38] - p[i27].oy[i39]) / (double) (p[i27].ox[i38] - p[i27].ox[i39])) / 0.017453292519943295));
                            int i46 = Math.abs((int) (Math.atan((double) (p[i27].oy[i40] - p[i27].oy[i39]) / (double) (p[i27].ox[i40] - p[i27].ox[i39])) / 0.017453292519943295));
                            if (i45 > 45) {
                                i45 = 90 - i45;
                            } else {
                                i46 = 90 - i46;
                            }
                            if (i45 + i46 < i36) {
                                i36 = i45 + i46;
                                i37 = i38;
                            }
                        }
                    }
                    if (i37 != 0) {
                        int[] is47 = new int[p[i27].n];
                        int[] is48 = new int[p[i27].n];
                        int[] is49 = new int[p[i27].n];
                        for (int i50 = 0; i50 < p[i27].n; i50++) {
                            is47[i50] = p[i27].ox[i50];
                            is48[i50] = p[i27].oy[i50];
                            is49[i50] = p[i27].oz[i50];
                        }
                        for (int i51 = 0; i51 < p[i27].n; i51++) {
                            int i52 = i51 + i37;
                            if (i52 >= p[i27].n) {
                                i52 -= p[i27].n;
                            }
                            p[i27].ox[i51] = is47[i52];
                            p[i27].oy[i51] = is48[i52];
                            p[i27].oz[i51] = is49[i52];
                        }
                    }
                    if (i28 == 1)
                        if (Math.abs(p[i27].oz[0] - p[i27].oz[1]) > Math.abs(p[i27].oy[0] - p[i27].oy[1])) {
                            if (p[i27].oz[0] > p[i27].oz[1]) {
                                if (p[i27].oy[1] > p[i27].oy[2]) {
                                    p[i27].fs = 1;
                                } else {
                                    p[i27].fs = -1;
                                }
                            } else if (p[i27].oy[1] > p[i27].oy[2]) {
                                p[i27].fs = -1;
                            } else {
                                p[i27].fs = 1;
                            }
                        } else if (p[i27].oy[0] > p[i27].oy[1]) {
                            if (p[i27].oz[1] > p[i27].oz[2]) {
                                p[i27].fs = -1;
                            } else {
                                p[i27].fs = 1;
                            }
                        } else if (p[i27].oz[1] > p[i27].oz[2]) {
                            p[i27].fs = 1;
                        } else {
                            p[i27].fs = -1;
                        }
                    if (i28 == 2)
                        if (Math.abs(p[i27].oz[0] - p[i27].oz[1]) > Math.abs(p[i27].ox[0] - p[i27].ox[1])) {
                            if (p[i27].oz[0] > p[i27].oz[1]) {
                                if (p[i27].ox[1] > p[i27].ox[2]) {
                                    p[i27].fs = -1;
                                } else {
                                    p[i27].fs = 1;
                                }
                            } else if (p[i27].ox[1] > p[i27].ox[2]) {
                                p[i27].fs = 1;
                            } else {
                                p[i27].fs = -1;
                            }
                        } else if (p[i27].ox[0] > p[i27].ox[1]) {
                            if (p[i27].oz[1] > p[i27].oz[2]) {
                                p[i27].fs = 1;
                            } else {
                                p[i27].fs = -1;
                            }
                        } else if (p[i27].oz[1] > p[i27].oz[2]) {
                            p[i27].fs = -1;
                        } else {
                            p[i27].fs = 1;
                        }
                    if (i28 == 3)
                        if (Math.abs(p[i27].oy[0] - p[i27].oy[1]) > Math.abs(p[i27].ox[0] - p[i27].ox[1])) {
                            if (p[i27].oy[0] > p[i27].oy[1]) {
                                if (p[i27].ox[1] > p[i27].ox[2]) {
                                    p[i27].fs = 1;
                                } else {
                                    p[i27].fs = -1;
                                }
                            } else if (p[i27].ox[1] > p[i27].ox[2]) {
                                p[i27].fs = -1;
                            } else {
                                p[i27].fs = 1;
                            }
                        } else if (p[i27].ox[0] > p[i27].ox[1]) {
                            if (p[i27].oy[1] > p[i27].oy[2]) {
                                p[i27].fs = -1;
                            } else {
                                p[i27].fs = 1;
                            }
                        } else if (p[i27].oy[1] > p[i27].oy[2]) {
                            p[i27].fs = 1;
                        } else {
                            p[i27].fs = -1;
                        }
                    boolean bool53 = false;
                    boolean bool54 = false;
                    for (int i55 = 0; i55 < npl; i55++) {
                        if (i55 != i27 && is0[i55] != 0) {
                            int i57 = p[i55].ox[0];
                            int i58 = p[i55].ox[0];
                            int i59 = p[i55].oy[0];
                            int i60 = p[i55].oy[0];
                            int i61 = p[i55].oz[0];
                            int i62 = p[i55].oz[0];
                            for (int i63 = 0; i63 < p[i55].n; i63++) {
                                if (p[i55].ox[i63] > i57) {
                                    i57 = p[i55].ox[i63];
                                }
                                if (p[i55].ox[i63] < i58) {
                                    i58 = p[i55].ox[i63];
                                }
                                if (p[i55].oy[i63] > i59) {
                                    i59 = p[i55].oy[i63];
                                }
                                if (p[i55].oy[i63] < i60) {
                                    i60 = p[i55].oy[i63];
                                }
                                if (p[i55].oz[i63] > i61) {
                                    i61 = p[i55].oz[i63];
                                }
                                if (p[i55].oz[i63] < i62) {
                                    i62 = p[i55].oz[i63];
                                }
                            }
                            int i64 = (i57 + i58) / 2;
                            int i65 = (i59 + i60) / 2;
                            int i66 = (i61 + i62) / 2;
                            int i67 = (i29 + i30) / 2;
                            int i68 = (i31 + i32) / 2;
                            int i69 = (i33 + i34) / 2;
                            if (i28 == 1 && (i65 <= i31 && i65 >= i32 && i66 <= i33 && i66 >= i34 || i68 <= i59 && i68 >= i60 && i69 <= i61 && i69 >= i62)) {
                                if (i57 < i30) {
                                    bool53 = true;
                                }
                                if (i58 > i29) {
                                    bool54 = true;
                                }
                            }
                            if (i28 == 2 && (i64 <= i29 && i64 >= i30 && i66 <= i33 && i66 >= i34 || i67 <= i57 && i67 >= i58 && i69 <= i61 && i69 >= i62)) {
                                if (i59 < i32) {
                                    bool53 = true;
                                }
                                if (i60 > i31) {
                                    bool54 = true;
                                }
                            }
                            if (i28 == 3 && (i64 <= i29 && i64 >= i30 && i65 <= i31 && i65 >= i32 || i67 <= i57 && i67 >= i58 && i68 <= i59 && i68 >= i60)) {
                                if (i61 < i34) {
                                    bool53 = true;
                                }
                                if (i62 > i33) {
                                    bool54 = true;
                                }
                            }
                        }
                        if (bool53 && bool54) {
                            break;
                        }
                    }
                    boolean bool70 = false;
                    if (bool53 && !bool54) {
                        bool70 = true;
                    }
                    if (bool54 && !bool53) {
                        p[i27].fs *= -1;
                        bool70 = true;
                    }
                    if (bool53 && bool54) {
                        p[i27].fs = 0;
                        p[i27].gr = 40;
                        bool70 = true;
                    }
                    if (!bool70) {
                        int i71 = 0;
                        int i72 = 0;
                        if (i28 == 1) {
                            i71 = (i29 + i30) / 2;
                            i72 = i71;
                        }
                        if (i28 == 2) {
                            i71 = (i31 + i32) / 2;
                            i72 = i71;
                        }
                        if (i28 == 3) {
                            i71 = (i33 + i34) / 2;
                            i72 = i71;
                        }
                        for (int i73 = 0; i73 < npl; i73++)
                            if (i73 != i27) {
                                boolean bool74 = false;
                                boolean[] bools = new boolean[p[i73].n];
                                for (int i75 = 0; i75 < p[i73].n; i75++) {
                                    bools[i75] = false;
                                    for (int i76 = 0; i76 < p[i27].n; i76++)
                                        if (p[i27].ox[i76] == p[i73].ox[i75] && p[i27].oy[i76] == p[i73].oy[i75] && p[i27].oz[i76] == p[i73].oz[i75]) {
                                            bools[i75] = true;
                                            bool74 = true;
                                        }
                                }
                                if (bool74) {
                                    for (int i77 = 0; i77 < p[i73].n; i77++)
                                        if (!bools[i77]) {
                                            if (i28 == 1) {
                                                if (p[i73].ox[i77] > i71) {
                                                    i71 = p[i73].ox[i77];
                                                }
                                                if (p[i73].ox[i77] < i72) {
                                                    i72 = p[i73].ox[i77];
                                                }
                                            }
                                            if (i28 == 2) {
                                                if (p[i73].oy[i77] > i71) {
                                                    i71 = p[i73].oy[i77];
                                                }
                                                if (p[i73].oy[i77] < i72) {
                                                    i72 = p[i73].oy[i77];
                                                }
                                            }
                                            if (i28 == 3) {
                                                if (p[i73].oz[i77] > i71) {
                                                    i71 = p[i73].oz[i77];
                                                }
                                                if (p[i73].oz[i77] < i72) {
                                                    i72 = p[i73].oz[i77];
                                                }
                                            }
                                        }
                                }
                            }
                        if (i28 == 1)
                            if ((i71 + i72) / 2 > (i29 + i30) / 2) {
                                p[i27].fs *= -1;
                            } else if ((i71 + i72) / 2 == (i29 + i30) / 2 && (i29 + i30) / 2 < 0) {
                                p[i27].fs *= -1;
                            }
                        if (i28 == 2)
                            if ((i71 + i72) / 2 > (i31 + i32) / 2) {
                                p[i27].fs *= -1;
                            } else if ((i71 + i72) / 2 == (i31 + i32) / 2 && (i31 + i32) / 2 < 0) {
                                p[i27].fs *= -1;
                            }
                        if (i28 == 3)
                            if ((i71 + i72) / 2 > (i33 + i34) / 2) {
                                p[i27].fs *= -1;
                            } else if ((i71 + i72) / 2 == (i33 + i34) / 2 && (i33 + i34) / 2 < 0) {
                                p[i27].fs *= -1;
                            }
                    }
                    p[i27].deltafntyp();
                }
            }
        }
    }

    internal ContO(ContO conto78, int toX, int toY, int toZ, int i81) {
        keyx = new int[4];
        keyz = new int[4];
        sprkat = 0;
        tnt = 0;
        ust = 0;
        srx = 0;
        sry = 0;
        srz = 0;
        rcx = 0.0F;
        rcy = 0.0F;
        rcz = 0.0F;
        sprk = 0;
        elec = false;
        roted = false;
        edl = new int[4];
        edr = new int[4];
        elc = new int[] {
                0, 0, 0, 0
        };
        fix = false;
        fcnt = 0;
        checkpoint = 0;
        fcol = new int[] {
                0, 0, 0
        };
        scol = new int[] {
                0, 0, 0
        };
        colok = 0;
        errd = false;
        err = "";
        roofat = 0;
        wh = 0;
        npl = conto78.npl;
        maxR = conto78.maxR;
        disp = conto78.disp;
        disline = conto78.disline;
        noline = conto78.noline;
        shadow = conto78.shadow;
        grounded = conto78.grounded;
        decor = conto78.decor;
        if (Medium.loadnew && (i81 == 90 || i81 == -90)) {
            grounded += 10000.0F;
        }
        grat = conto78.grat;
        sprkat = conto78.sprkat;
        p = new Plane[conto78.npl];
        for (int i82 = 0; i82 < npl; i82++) {
            if (conto78.p[i82].master == 1) {
                conto78.p[i82].n = 20;
            }
            p[i82] = new Plane(conto78.p[i82].ox, conto78.p[i82].oz, conto78.p[i82].oy, conto78.p[i82].n, conto78.p[i82].oc, conto78.p[i82].glass, conto78.p[i82].gr, conto78.p[i82].fs, conto78.p[i82].wx, conto78.p[i82].wy, conto78.p[i82].wz, conto78.disline, conto78.p[i82].bfase, conto78.p[i82].road, conto78.p[i82].light, conto78.p[i82].solo);
            p[i82].project = conto78.p[i82].project;
        }
        x = toX;
        y = toY;
        z = toZ;
        xz = 0;
        xy = 0;
        zy = 0;
        for (int i83 = 0; i83 < npl; i83++) {
            p[i83].colnum = conto78.p[i83].colnum;
            p[i83].master = conto78.p[i83].master;
            p[i83].rot(p[i83].ox, p[i83].oz, 0, 0, i81, p[i83].n);
            p[i83].loadprojf();
        }
        if (conto78.tnt != 0) {
            for (int i84 = 0; i84 < conto78.tnt; i84++) {
                Trackers.xy[Trackers.nt] = (int) (conto78.txy[i84] * Medium.cos(i81) - conto78.tzy[i84] * Medium.sin(i81));
                Trackers.zy[Trackers.nt] = (int) (conto78.tzy[i84] * Medium.cos(i81) + conto78.txy[i84] * Medium.sin(i81));
                for (int i85 = 0; i85 < 3; i85++) {
                    Trackers.c[Trackers.nt][i85] = (int) (conto78.tc[i84,i85] + conto78.tc[i84,i85] * (Medium.snap[i85] / 100.0F));
                    if (Trackers.c[Trackers.nt][i85] > 255) {
                        Trackers.c[Trackers.nt][i85] = 255;
                    }
                    if (Trackers.c[Trackers.nt][i85] < 0) {
                        Trackers.c[Trackers.nt][i85] = 0;
                    }
                }
                Trackers.x[Trackers.nt] = (int) (x + conto78.tx[i84] * Medium.cos(i81) - conto78.tz[i84] * Medium.sin(i81));
                Trackers.z[Trackers.nt] = (int) (z + conto78.tz[i84] * Medium.cos(i81) + conto78.tx[i84] * Medium.sin(i81));
                Trackers.y[Trackers.nt] = y + conto78.ty[i84];
                Trackers.skd[Trackers.nt] = conto78.skd[i84];
                Trackers.dam[Trackers.nt] = conto78.dam[i84];
                Trackers.notwall[Trackers.nt] = conto78.notwall[i84];
                Trackers.decor[Trackers.nt] = decor;
                int i86 = Math.abs(i81);
                if (i86 == 180) {
                    i86 = 0;
                }
                Trackers.radx[Trackers.nt] = (int) Math.abs(conto78.tradx[i84] * Medium.cos(i86) + conto78.tradz[i84] * Medium.sin(i86));
                Trackers.radz[Trackers.nt] = (int) Math.abs(conto78.tradx[i84] * Medium.sin(i86) + conto78.tradz[i84] * Medium.cos(i86));
                Trackers.rady[Trackers.nt] = conto78.trady[i84];
                Trackers.nt++;
            }
        }
        for (int i87 = 0; i87 < 4; i87++) {
            keyx[i87] = conto78.keyx[i87];
            keyz[i87] = conto78.keyz[i87];
        }
        if (shadow) {
            stg = new int[20];
            sx = new int[20];
            sy = new int[20];
            sz = new int[20];
            scx = new int[20];
            scz = new int[20];
            osmag = new float[20];
            sav = new int[20];
            smag = new float[20,8];
            srgb = new int[20,3];
            sbln = new float[20];
            ust = 0;
            for (int i88 = 0; i88 < 20; i88++) {
                stg[i88] = 0;
            }
            rtg = new int[100];
            rbef = new boolean[100];
            rx = new int[100];
            ry = new int[100];
            rz = new int[100];
            vrx = new float[100];
            vry = new float[100];
            vrz = new float[100];
            for (int i89 = 0; i89 < 100; i89++) {
                rtg[i89] = 0;
            }
        }
    }

    ContO(int i, int i90, int i91, int i92, int i93, int i94) {
        keyx = new int[4];
        keyz = new int[4];
        sprkat = 0;
        tnt = 0;
        ust = 0;
        srx = 0;
        sry = 0;
        srz = 0;
        rcx = 0.0F;
        rcy = 0.0F;
        rcz = 0.0F;
        sprk = 0;
        elec = false;
        roted = false;
        edl = new int[4];
        edr = new int[4];
        elc = new int[] {
                0, 0, 0, 0
        };
        fix = false;
        fcnt = 0;
        checkpoint = 0;
        fcol = new int[] {
                0, 0, 0
        };
        scol = new int[] {
                0, 0, 0
        };
        colok = 0;
        errd = false;
        err = "";
        roofat = 0;
        wh = 0;
        x = i92;
        z = i93;
        y = i94;
        xz = 0;
        xy = 0;
        zy = 0;
        grat = 0;
        sprkat = 0;
        disline = 4;
        noline = true;
        shadow = false;
        grounded = 115.0F;
        decor = true;
        npl = 5;
        p = new Plane[5];
        Random random = new Random(i);
        int[] ais = new int[8];
        int[] is95 = new int[8];
        int[] is96 = new int[8];
        int[] is97 = new int[8];
        int[] is98 = new int[8];
        float f = i90;
        float f99 = i91;
        if (f99 < 2.0F) {
            f99 = 2.0F;
        }
        if (f99 > 6.0F) {
            f99 = 6.0F;
        }
        if (f < 2.0F) {
            f = 2.0F;
        }
        if (f > 6.0F) {
            f = 6.0F;
        }
        f /= 1.5F;
        f99 /= 1.5F;
        f99 *= 1.0F + (f - 2.0F) * 0.1786F;
        float f100 = (float) (50.0 + 100.0 * random.nextDouble());
        ais[0] = -(int) (f100 * f * 0.7071F);
        is95[0] = (int) (f100 * f * 0.7071F);
        f100 = (float) (50.0 + 100.0 * random.nextDouble());
        ais[1] = 0;
        is95[1] = (int) (f100 * f);
        f100 = (float) (50.0 + 100.0 * random.nextDouble());
        ais[2] = (int) (f100 * f * 0.7071);
        is95[2] = (int) (f100 * f * 0.7071);
        f100 = (float) (50.0 + 100.0 * random.nextDouble());
        ais[3] = (int) (f100 * f);
        is95[3] = 0;
        f100 = (float) (50.0 + 100.0 * random.nextDouble());
        ais[4] = (int) (f100 * f * 0.7071);
        is95[4] = -(int) (f100 * f * 0.7071);
        f100 = (float) (50.0 + 100.0 * random.nextDouble());
        ais[5] = 0;
        is95[5] = -(int) (f100 * f);
        f100 = (float) (50.0 + 100.0 * random.nextDouble());
        ais[6] = -(int) (f100 * f * 0.7071);
        is95[6] = -(int) (f100 * f * 0.7071);
        f100 = (float) (50.0 + 100.0 * random.nextDouble());
        ais[7] = -(int) (f100 * f);
        is95[7] = 0;
        for (int i101 = 0; i101 < 8; i101++) {
            is96[i101] = (int) (ais[i101] * (0.2 + 0.4 * random.nextDouble()));
            is97[i101] = (int) (is95[i101] * (0.2 + 0.4 * random.nextDouble()));
            is98[i101] = -(int) ((10.0 + 15.0 * random.nextDouble()) * f99);
        }
        maxR = 0;
        for (int i102 = 0; i102 < 8; i102++) {
            int i103 = i102 - 1;
            if (i103 == -1) {
                i103 = 7;
            }
            int i104 = i102 + 1;
            if (i104 == 8) {
                i104 = 0;
            }
            ais[i102] = ((ais[i103] + ais[i104]) / 2 + ais[i102]) / 2;
            is95[i102] = ((is95[i103] + is95[i104]) / 2 + is95[i102]) / 2;
            is96[i102] = ((is96[i103] + is96[i104]) / 2 + is96[i102]) / 2;
            is97[i102] = ((is97[i103] + is97[i104]) / 2 + is97[i102]) / 2;
            is98[i102] = ((is98[i103] + is98[i104]) / 2 + is98[i102]) / 2;
            int i105 = (int) Math.sqrt(ais[i102] * ais[i102] + is95[i102] * is95[i102]);
            if (i105 > maxR) {
                maxR = i105;
            }
            i105 = (int) Math.sqrt(is96[i102] * is96[i102] + is98[i102] * is98[i102] + is97[i102] * is97[i102]);
            if (i105 > maxR) {
                maxR = i105;
            }
        }
        disp = maxR / 17;
        int[] is106 = new int[3];
        float f107 = -1.0F;
        float f108 = (f / f99 - 0.33F) / 33.4F;
        if (f108 < 0.005) {
            f108 = 0.0F;
        }
        if (f108 > 0.057) {
            f108 = 0.057F;
        }
        for (int i109 = 0; i109 < 4; i109++) {
            int i110 = i109 * 2;
            int i111 = i110 + 2;
            if (i111 == 8) {
                i111 = 0;
            }
            int[] is112 = new int[6];
            int[] is113 = new int[6];
            int[] is114 = new int[6];
            is112[0] = ais[i110];
            is112[1] = ais[i110 + 1];
            is112[2] = ais[i111];
            is112[5] = is96[i110];
            is112[4] = is96[i110 + 1];
            is112[3] = is96[i111];
            is114[0] = is95[i110];
            is114[1] = is95[i110 + 1];
            is114[2] = is95[i111];
            is114[5] = is97[i110];
            is114[4] = is97[i110 + 1];
            is114[3] = is97[i111];
            is113[0] = 0;
            is113[1] = 0;
            is113[2] = 0;
            is113[5] = is98[i110];
            is113[4] = is98[i110 + 1];
            is113[3] = is98[i111];
            for (f100 = (float) ((0.17 - f108) * random.nextDouble()); Math.abs(f107 - f100) < 0.03 - f108 * 0.176F; f100 = (float) ((0.17 - f108) * random.nextDouble())) {

            }
            f107 = f100;
            for (int i115 = 0; i115 < 3; i115++)
                if (Medium.trk == 2) {
                    is106[i115] = (int) (390.0F / (2.2F + f100 - f108));
                } else {
                    is106[i115] = (int) ((Medium.cpol[i115] + Medium.cgrnd[i115]) / (2.2F + f100 - f108));
                }
            p[i109] = new Plane(is112, is114, is113, 6, is106, 3, -8, 0, 0, 0, 0, disline, 0, true, 0, false);
        }
        f100 = (float) (0.02 * random.nextDouble());
        for (int i116 = 0; i116 < 3; i116++)
            if (Medium.trk == 2) {
                is106[i116] = (int) (390.0F / (2.15F + f100));
            } else {
                is106[i116] = (int) ((Medium.cpol[i116] + Medium.cgrnd[i116]) / (2.15F + f100));
            }
        p[4] = new Plane(is96, is97, is98, 8, is106, 3, -8, 0, 0, 0, 0, disline, 0, true, 0, false);
        int[] is117 = new int[2];
        int[] is118 = new int[2];
        for (int i119 = 0; i119 < 4; i119++) {
            int i120 = i119 * 2 + 1;
            Trackers.y[Trackers.nt] = is98[i120] / 2;
            Trackers.rady[Trackers.nt] = Math.abs(is98[i120] / 2);
            if (i119 == 0 || i119 == 2) {
                Trackers.z[Trackers.nt] = (is95[i120] + is97[i120]) / 2;
                Trackers.radz[Trackers.nt] = Math.abs(Trackers.z[Trackers.nt] - is95[i120]);
                i120 = i119 * 2 + 2;
                if (i120 == 8) {
                    i120 = 0;
                }
                Trackers.x[Trackers.nt] = (ais[i119 * 2] + ais[i120]) / 2;
                Trackers.radx[Trackers.nt] = Math.abs(Trackers.x[Trackers.nt] - ais[i119 * 2]);
            } else {
                Trackers.x[Trackers.nt] = (ais[i120] + is96[i120]) / 2;
                Trackers.radx[Trackers.nt] = Math.abs(Trackers.x[Trackers.nt] - ais[i120]);
                i120 = i119 * 2 + 2;
                if (i120 == 8) {
                    i120 = 0;
                }
                Trackers.z[Trackers.nt] = (is95[i119 * 2] + is95[i120]) / 2;
                Trackers.radz[Trackers.nt] = Math.abs(Trackers.z[Trackers.nt] - is95[i119 * 2]);
            }
            if (i119 == 0) {
                is118[0] = Trackers.z[Trackers.nt] - Trackers.radz[Trackers.nt];
                Trackers.zy[Trackers.nt] = (int) (Math.atan((double) Trackers.rady[Trackers.nt] / (double) Trackers.radz[Trackers.nt]) / 0.017453292519943295);
                if (Trackers.zy[Trackers.nt] > 40) {
                    Trackers.zy[Trackers.nt] = 40;
                }
                Trackers.xy[Trackers.nt] = 0;
            }
            if (i119 == 1) {
                is117[0] = Trackers.x[Trackers.nt] - Trackers.radx[Trackers.nt];
                Trackers.xy[Trackers.nt] = (int) (Math.atan((double) Trackers.rady[Trackers.nt] / (double) Trackers.radx[Trackers.nt]) / 0.017453292519943295);
                if (Trackers.xy[Trackers.nt] > 40) {
                    Trackers.xy[Trackers.nt] = 40;
                }
                Trackers.zy[Trackers.nt] = 0;
            }
            if (i119 == 2) {
                is118[1] = Trackers.z[Trackers.nt] + Trackers.radz[Trackers.nt];
                Trackers.zy[Trackers.nt] = -(int) (Math.atan((double) Trackers.rady[Trackers.nt] / (double) Trackers.radz[Trackers.nt]) / 0.017453292519943295);
                if (Trackers.zy[Trackers.nt] < -40) {
                    Trackers.zy[Trackers.nt] = -40;
                }
                Trackers.xy[Trackers.nt] = 0;
            }
            if (i119 == 3) {
                is117[1] = Trackers.x[Trackers.nt] + Trackers.radx[Trackers.nt];
                Trackers.xy[Trackers.nt] = -(int) (Math.atan((double) Trackers.rady[Trackers.nt] / (double) Trackers.radx[Trackers.nt]) / 0.017453292519943295);
                if (Trackers.xy[Trackers.nt] < -40) {
                    Trackers.xy[Trackers.nt] = -40;
                }
                Trackers.zy[Trackers.nt] = 0;
            }
            Trackers.x[Trackers.nt] += x;
            Trackers.z[Trackers.nt] += z;
            Trackers.y[Trackers.nt] += y;
            HansenSystem.ArrayCopy(p[i119].oc, 0, Trackers.c[Trackers.nt], 0, 3);
            Trackers.skd[Trackers.nt] = 2;
            Trackers.dam[Trackers.nt] = 1;
            Trackers.notwall[Trackers.nt] = false;
            Trackers.decor[Trackers.nt] = true;
            Trackers.rady[Trackers.nt] += 10;
            Trackers.nt++;
        }
        Trackers.y[Trackers.nt] = 0;
        for (int i122 = 0; i122 < 8; i122++) {
            Trackers.y[Trackers.nt] += is98[i122];
        }
        Trackers.y[Trackers.nt] = Trackers.y[Trackers.nt] / 8;
        Trackers.y[Trackers.nt] += y;
        Trackers.rady[Trackers.nt] = 200;
        Trackers.radx[Trackers.nt] = is117[0] - is117[1];
        Trackers.radz[Trackers.nt] = is118[0] - is118[1];
        Trackers.x[Trackers.nt] = (is117[0] + is117[1]) / 2 + x;
        Trackers.z[Trackers.nt] = (is118[0] + is118[1]) / 2 + z;
        Trackers.zy[Trackers.nt] = 0;
        Trackers.xy[Trackers.nt] = 0;
        HansenSystem.ArrayCopy(p[4].oc, 0, Trackers.c[Trackers.nt], 0, 3);
        Trackers.skd[Trackers.nt] = 4;
        Trackers.dam[Trackers.nt] = 1;
        Trackers.notwall[Trackers.nt] = false;
        Trackers.decor[Trackers.nt] = true;
        Trackers.nt++;
    }

    void d() {
        if (dist != 0) {
            dist = 0;
        }
        int i = Medium.cx + (int) ((x - Medium.x - Medium.cx) * Medium.cos(Medium.xz) - (z - Medium.z - Medium.cz) * Medium.sin(Medium.xz));
        int i124 = Medium.cz + (int) ((x - Medium.x - Medium.cx) * Medium.sin(Medium.xz) + (z - Medium.z - Medium.cz) * Medium.cos(Medium.xz));
        int i125 = Medium.cz + (int) ((y - Medium.y - Medium.cy) * Medium.sin(Medium.zy) + (i124 - Medium.cz) * Medium.cos(Medium.zy));
        int i126 = xs(i + maxR, i125) - xs(i - maxR, i125);
        if (xs(i + maxR * 2, i125) > Medium.iw && xs(i - maxR * 2, i125) < Medium.w && i125 > -maxR && (i125 < Medium.fade[disline] + maxR || Medium.trk != 0) && (i126 > disp || Medium.trk != 0) && (!decor || Medium.resdown != 2 && Medium.trk != 1)) {
            if (shadow)
                if (!Medium.crs) {
                    if (i125 < 2000) {
                        boolean aabool = false;
                        if (Trackers.ncx != 0 || Trackers.ncz != 0) {
                            int i127 = (x - Trackers.sx) / 3000;
                            if (i127 > Trackers.ncx) {
                                i127 = Trackers.ncx;
                            }
                            if (i127 < 0) {
                                i127 = 0;
                            }
                            int i128 = (z - Trackers.sz) / 3000;
                            if (i128 > Trackers.ncz) {
                                i128 = Trackers.ncz;
                            }
                            if (i128 < 0) {
                                i128 = 0;
                            }
                            for (int i129 = Trackers.sect[i127,i128].Length - 1; i129 >= 0; i129--) {
                                int i130 = Trackers.sect[i127,i128][i129];
                                if (Math.abs(Trackers.zy[i130]) != 90 && Math.abs(Trackers.xy[i130]) != 90 && Math.abs(x - Trackers.x[i130]) < Trackers.radx[i130] + maxR && Math.abs(z - Trackers.z[i130]) < Trackers.radz[i130] + maxR && (!Trackers.decor[i130] || Medium.resdown != 2)) {
                                    aabool = true;
                                    break;
                                }
                            }
                        }
                        if (aabool) {
                            for (int i131 = 0; i131 < npl; i131++) {
                                p[i131].s(x - Medium.x, y - Medium.y, z - Medium.z, xz, xy, zy, 0);
                            }
                        } else {
                            int i132 = Medium.cy + (int) ((Medium.ground - Medium.cy) * Medium.cos(Medium.zy) - (i124 - Medium.cz) * Medium.sin(Medium.zy));
                            int i133 = Medium.cz + (int) ((Medium.ground - Medium.cy) * Medium.sin(Medium.zy) + (i124 - Medium.cz) * Medium.cos(Medium.zy));
                            if (ys(i132 + maxR, i133) > 0 && ys(i132 - maxR, i133) < Medium.h) {
                                for (int i134 = 0; i134 < npl; i134++) {
                                    p[i134].s(x - Medium.x, y - Medium.y, z - Medium.z, xz, xy, zy, 1);
                                }
                            }
                        }
                        Medium.addsp(x - Medium.x, z - Medium.z, (int) (maxR * 0.8));
                    } else {
                        lowshadow(i125);
                    }
                } else {
                    for (int i135 = 0; i135 < npl; i135++) {
                        p[i135].s(x - Medium.x, y - Medium.y, z - Medium.z, xz, xy, zy, 2);
                    }
                }
            int i136 = Medium.cy + (int) ((y - Medium.y - Medium.cy) * Medium.cos(Medium.zy) - (i124 - Medium.cz) * Medium.sin(Medium.zy));
            if (ys(i136 + maxR, i125) > Medium.ih && ys(i136 - maxR, i125) < Medium.h) {
                if (elec && Medium.noelec == 0) {
                    electrify();
                }
                if (fix) {
                    fixit();
                }
                if (checkpoint != 0 && checkpoint - 1 == Medium.checkpoint) {
                    i126 = -1;
                }
                if (shadow) {
                    dist = (int) Math.sqrt((Medium.x + Medium.cx - x) * (Medium.x + Medium.cx - x) + (Medium.z - z) * (Medium.z - z) + (Medium.y + Medium.cy - y) * (Medium.y + Medium.cy - y));
                    for (int i137 = 0; i137 < 20; i137++)
                        if (stg[i137] != 0) {
                            pdust(i137, true);
                        }
                    dsprk(true);
                }
                ArrayExt.sort(p, 0, npl);
                
                int _npl = npl - 1;
                p[0].d(p[0], p[1], x - Medium.x, y - Medium.y, z - Medium.z, xz, xy, zy, wxz, wzy, noline, i126);
                for (int j = 1; j < _npl; j++) {
                    p[j].d(p[j-1], p[j+1], x - Medium.x, y - Medium.y, z - Medium.z, xz, xy, zy, wxz, wzy, noline, i126);
                }
                p[_npl].d(p[_npl-1], null, x - Medium.x, y - Medium.y, z - Medium.z, xz, xy, zy, wxz, wzy, noline, i126);
                
                if (shadow) {
                    for (int i143 = 0; i143 < 20; i143++)
                        if (stg[i143] != 0) {
                            pdust(i143, false);
                        }
                    dsprk(false);
                }
                dist = (int) (Math.sqrt((int) Math.sqrt((Medium.x + Medium.cx - x) * (Medium.x + Medium.cx - x) + (Medium.z - z) * (Medium.z - z) + (Medium.y + Medium.cy - y) * (Medium.y + Medium.cy - y))) * grounded);
            }
        }
        if (shadow && dist == 0) {
            for (int i144 = 0; i144 < 20; i144++)
                if (stg[i144] != 0) {
                    stg[i144] = 0;
                }
            for (int i145 = 0; i145 < 100; i145++)
                if (rtg[i145] != 0) {
                    rtg[i145] = 0;
                }
            if (sprk != 0) {
                sprk = 0;
            }
        }
    }

    private void dsprk(boolean aabool) {
        if (aabool && sprk != 0) {
            int i = (int) (Math.sqrt(rcx * rcx + rcy * rcy + rcz * rcz) / 10.0);
            if (i > 5) {
                boolean bool240 = false;
                if (dist < Math.sqrt((Medium.x + Medium.cx - srx) * (Medium.x + Medium.cx - srx) + (Medium.y + Medium.cy - sry) * (Medium.y + Medium.cy - sry) + (Medium.z - srz) * (Medium.z - srz))) {
                    bool240 = true;
                }
                if (i > 33) {
                    i = 33;
                }
                int i241 = 0;
                for (int i242 = 0; i242 < 100; i242++) {
                    if (rtg[i242] == 0) {
                        rtg[i242] = 1;
                        rbef[i242] = bool240;
                        i241++;
                    }
                    if (i241 == i) {
                        break;
                    }
                }
            }
        }
        for (int i = 0; i < 100; i++)
            if (rtg[i] != 0 && (rbef[i] && aabool || !rbef[i] && !aabool)) {
                if (rtg[i] == 1) {
                    if (sprk < 5) {
                        rx[i] = srx + 3 - (int) (Medium.random() * 6.7);
                        ry[i] = sry + 3 - (int) (Medium.random() * 6.7);
                        rz[i] = srz + 3 - (int) (Medium.random() * 6.7);
                    } else {
                        rx[i] = srx + 10 - (int) (Medium.random() * 20.0F);
                        ry[i] = sry - (int) (Medium.random() * 4.0F);
                        rz[i] = srz + 10 - (int) (Medium.random() * 20.0F);
                    }
                    int i243 = (int) Math.sqrt(rcx * rcx + rcy * rcy + rcz * rcz);
                    float f = 0.2F + 0.4F * Medium.random();
                    float f244 = Medium.random() * Medium.random() * Medium.random();
                    float f245 = 1.0F;
                    if (Medium.random() > Medium.random()) {
                        if (Medium.random() > Medium.random()) {
                            f245 *= -1.0F;
                        }
                        vrx[i] = -((rcx + i243 * (1.0F - rcx / i243) * f244 * f245) * f);
                    }
                    if (Medium.random() > Medium.random()) {
                        if (Medium.random() > Medium.random()) {
                            f245 *= -1.0F;
                        }
                        if (sprk == 5) {
                            f245 = 1.0F;
                        }
                        vry[i] = -((rcy + i243 * (1.0F - rcy / i243) * f244 * f245) * f);
                    }
                    if (Medium.random() > Medium.random()) {
                        if (Medium.random() > Medium.random()) {
                            f245 *= -1.0F;
                        }
                        vrz[i] = -((rcz + i243 * (1.0F - rcz / i243) * f244 * f245) * f);
                    }
                }
                rx[i] = (int) (rx[i] + vrx[i]);
                ry[i] = (int) (ry[i] + vry[i]);
                rz[i] = (int) (rz[i] + vrz[i]);
                int i246 = Medium.cx + (int) ((rx[i] - Medium.x - Medium.cx) * Medium.cos(Medium.xz) - (rz[i] - Medium.z - Medium.cz) * Medium.sin(Medium.xz));
                int i247 = Medium.cz + (int) ((rx[i] - Medium.x - Medium.cx) * Medium.sin(Medium.xz) + (rz[i] - Medium.z - Medium.cz) * Medium.cos(Medium.xz));
                int i248 = Medium.cy + (int) ((ry[i] - Medium.y - Medium.cy) * Medium.cos(Medium.zy) - (i247 - Medium.cz) * Medium.sin(Medium.zy));
                i247 = Medium.cz + (int) ((ry[i] - Medium.y - Medium.cy) * Medium.sin(Medium.zy) + (i247 - Medium.cz) * Medium.cos(Medium.zy));
                int i249 = Medium.cx + (int) ((rx[i] - Medium.x - Medium.cx + vrx[i]) * Medium.cos(Medium.xz) - (rz[i] - Medium.z - Medium.cz + vrz[i]) * Medium.sin(Medium.xz));
                int i250 = Medium.cz + (int) ((rx[i] - Medium.x - Medium.cx + vrx[i]) * Medium.sin(Medium.xz) + (rz[i] - Medium.z - Medium.cz + vrz[i]) * Medium.cos(Medium.xz));
                int i251 = Medium.cy + (int) ((ry[i] - Medium.y - Medium.cy + vry[i]) * Medium.cos(Medium.zy) - (i250 - Medium.cz) * Medium.sin(Medium.zy));
                i250 = Medium.cz + (int) ((ry[i] - Medium.y - Medium.cy + vry[i]) * Medium.sin(Medium.zy) + (i250 - Medium.cz) * Medium.cos(Medium.zy));
                int i252 = xs(i246, i247);
                int i253 = ys(i248, i247);
                int i254 = xs(i249, i250);
                int i255 = ys(i251, i250);
                if (i252 < Medium.iw && i254 < Medium.iw) {
                    rtg[i] = 0;
                }
                if (i252 > Medium.w && i254 > Medium.w) {
                    rtg[i] = 0;
                }
                if (i253 < Medium.ih && i255 < Medium.ih) {
                    rtg[i] = 0;
                }
                if (i253 > Medium.h && i255 > Medium.h) {
                    rtg[i] = 0;
                }
                if (ry[i] > 250) {
                    rtg[i] = 0;
                }
                if (rtg[i] != 0) {
                    int i256 = 255;
                    int i257 = 197 - 30 * rtg[i];
                    int i258 = 0;
                    for (int i259 = 0; i259 < 16; i259++)
                        if (i247 > Medium.fade[i259]) {
                            i256 = (i256 * Medium.fogd + Medium.cfade[0]) / (Medium.fogd + 1);
                            i257 = (i257 * Medium.fogd + Medium.cfade[1]) / (Medium.fogd + 1);
                            i258 = (i258 * Medium.fogd + Medium.cfade[2]) / (Medium.fogd + 1);
                        }
                    G.setColor(new Color(i256, i257, i258));
                    G.drawLine(i252, i253, i254, i255);
                    vrx[i] = vrx[i] * 0.8F;
                    vry[i] = vry[i] * 0.8F;
                    vrz[i] = vrz[i] * 0.8F;
                    if (rtg[i] == 3) {
                        rtg[i] = 0;
                    } else {
                        rtg[i]++;
                    }
                }
            }
        if (sprk != 0) {
            sprk = 0;
        }
    }

    void dust(int i, float f, float f199, float f200, int i201, int i202, float f203, int i204, boolean aabool) {
        boolean bool205 = false;
        if (i204 > 5 && (i == 0 || i == 2)) {
            bool205 = true;
        }
        if (i204 < -5 && (i == 1 || i == 3)) {
            bool205 = true;
        }
        float f206 = (float) ((Math.sqrt(i201 * i201 + i202 * i202) - 40.0) / 160.0);
        if (f206 > 1.0F) {
            f206 = 1.0F;
        }
        if (f206 > 0.2 && !bool205) {
            ust++;
            if (ust == 20) {
                ust = 0;
            }
            if (!aabool) {
                float f207 = Medium.random();
                sx[ust] = (int) ((f + x * f207) / (1.0F + f207));
                sz[ust] = (int) ((f200 + z * f207) / (1.0F + f207));
                sy[ust] = (int) ((f199 + y * f207) / (1.0F + f207));
            } else {
                sx[ust] = (int) ((f + (x + i201)) / 2.0F);
                sz[ust] = (int) ((f200 + (z + i202)) / 2.0F);
                sy[ust] = (int) f199;
            }
            if (sy[i] > 250) {
                sy[i] = 250;
            }
            osmag[ust] = f203 * f206;
            scx[ust] = i201;
            scz[ust] = i202;
            stg[ust] = 1;
        }
    }

    private void electrify() {
        for (int i = 0; i < 4; i++) {
            if (elc[i] == 0) {
                edl[i] = (int) (380.0F - Medium.random() * 760.0F);
                edr[i] = (int) (380.0F - Medium.random() * 760.0F);
                elc[i] = 1;
            }
            int i182 = (int) (edl[i] + (190.0F - Medium.random() * 380.0F));
            int i183 = (int) (edr[i] + (190.0F - Medium.random() * 380.0F));
            int i184 = (int) (Medium.random() * 126.0F);
            int i185 = (int) (Medium.random() * 126.0F);
            int[] ais = new int[8];
            int[] is186 = new int[8];
            int[] is187 = new int[8];
            for (int i188 = 0; i188 < 8; i188++) {
                is187[i188] = z - Medium.z;
            }
            ais[0] = x - Medium.x - 504;
            is186[0] = y - Medium.y - edl[i] - 5 - (int) (Medium.random() * 5.0F);
            ais[1] = x - Medium.x - 252 + i185;
            is186[1] = y - Medium.y - i182 - 5 - (int) (Medium.random() * 5.0F);
            ais[2] = x - Medium.x + 252 - i184;
            is186[2] = y - Medium.y - i183 - 5 - (int) (Medium.random() * 5.0F);
            ais[3] = x - Medium.x + 504;
            is186[3] = y - Medium.y - edr[i] - 5 - (int) (Medium.random() * 5.0F);
            ais[4] = x - Medium.x + 504;
            is186[4] = y - Medium.y - edr[i] + 5 + (int) (Medium.random() * 5.0F);
            ais[5] = x - Medium.x + 252 - i184;
            is186[5] = y - Medium.y - i183 + 5 + (int) (Medium.random() * 5.0F);
            ais[6] = x - Medium.x - 252 + i185;
            is186[6] = y - Medium.y - i182 + 5 + (int) (Medium.random() * 5.0F);
            ais[7] = x - Medium.x - 504;
            is186[7] = y - Medium.y - edl[i] + 5 + (int) (Medium.random() * 5.0F);
            if (roted) {
                rot(ais, is187, x - Medium.x, z - Medium.z, 90, 8);
            }
            rot(ais, is187, Medium.cx, Medium.cz, Medium.xz, 8);
            rot(is186, is187, Medium.cy, Medium.cz, Medium.zy, 8);
            boolean aabool = true;
            int i189 = 0;
            int i190 = 0;
            int i191 = 0;
            int i192 = 0;
            int[] is193 = new int[8];
            int[] is194 = new int[8];
            for (int i195 = 0; i195 < 8; i195++) {
                is193[i195] = xs(ais[i195], is187[i195]);
                is194[i195] = ys(is186[i195], is187[i195]);
                if (is194[i195] < Medium.ih || is187[i195] < 10) {
                    i189++;
                }
                if (is194[i195] > Medium.h || is187[i195] < 10) {
                    i190++;
                }
                if (is193[i195] < Medium.iw || is187[i195] < 10) {
                    i191++;
                }
                if (is193[i195] > Medium.w || is187[i195] < 10) {
                    i192++;
                }
            }
            if (i191 == 8 || i189 == 8 || i190 == 8 || i192 == 8) {
                aabool = false;
            }
            if (aabool) {
                int i196 = (int) (160.0F + 160.0F * (Medium.snap[0] / 500.0F));
                if (i196 > 255) {
                    i196 = 255;
                }
                if (i196 < 0) {
                    i196 = 0;
                }
                int i197 = (int) (238.0F + 238.0F * (Medium.snap[1] / 500.0F));
                if (i197 > 255) {
                    i197 = 255;
                }
                if (i197 < 0) {
                    i197 = 0;
                }
                int i198 = (int) (255.0F + 255.0F * (Medium.snap[2] / 500.0F));
                if (i198 > 255) {
                    i198 = 255;
                }
                if (i198 < 0) {
                    i198 = 0;
                }
                i196 = (i196 * 2 + 214 * (elc[i] - 1)) / (elc[i] + 1);
                i197 = (i197 * 2 + 236 * (elc[i] - 1)) / (elc[i] + 1);
                if (Medium.trk == 1) {
                    i196 = 255;
                    i197 = 128;
                    i198 = 0;
                }
                G.setColor(new Color(i196, i197, i198));
                G.fillPolygon(is193, is194, 8);
                if (is187[0] < 4000) {
                    i196 = (int) (150.0F + 150.0F * (Medium.snap[0] / 500.0F));
                    if (i196 > 255) {
                        i196 = 255;
                    }
                    if (i196 < 0) {
                        i196 = 0;
                    }
                    i197 = (int) (227.0F + 227.0F * (Medium.snap[1] / 500.0F));
                    if (i197 > 255) {
                        i197 = 255;
                    }
                    if (i197 < 0) {
                        i197 = 0;
                    }
                    i198 = (int) (255.0F + 255.0F * (Medium.snap[2] / 500.0F));
                    if (i198 > 255) {
                        i198 = 255;
                    }
                    if (i198 < 0) {
                        i198 = 0;
                    }
                    G.setColor(new Color(i196, i197, i198));
                    G.drawPolygon(is193, is194, 8);
                }
            }
            if (elc[i] > Medium.random() * 60.0F) {
                elc[i] = 0;
            } else {
                elc[i]++;
            }
        }
        if (!roted || xz != 0) {
            xy += 11;
            if (xy > 360) {
                xy -= 360;
            }
        } else {
            zy += 11;
            if (zy > 360) {
                zy -= 360;
            }
        }
    }

    private void fixit() {
        if (fcnt == 1) {
            for (int i = 0; i < npl; i++) {
                p[i].hsb[0] = 0.57F;
                p[i].hsb[2] = 0.8F;
                p[i].hsb[1] = 0.8F;
                Color color = Color.getHSBColor(p[i].hsb[0], p[i].hsb[1], p[i].hsb[2]);
                int i167 = (int) (color.getRed() + color.getRed() * (Medium.snap[0] / 100.0F));
                if (i167 > 255) {
                    i167 = 255;
                }
                if (i167 < 0) {
                    i167 = 0;
                }
                int i168 = (int) (color.getGreen() + color.getGreen() * (Medium.snap[1] / 100.0F));
                if (i168 > 255) {
                    i168 = 255;
                }
                if (i168 < 0) {
                    i168 = 0;
                }
                int i169 = (int) (color.getBlue() + color.getBlue() * (Medium.snap[2] / 100.0F));
                if (i169 > 255) {
                    i169 = 255;
                }
                if (i169 < 0) {
                    i169 = 0;
                }
                Color.RGBtoHSB(i167, i168, i169, p[i].hsb);
                p[i].flx = 1;
            }
        }
        if (fcnt == 2) {
            for (int i = 0; i < npl; i++) {
                p[i].flx = 1;
            }
        }
        if (fcnt == 4) {
            for (int i = 0; i < npl; i++) {
                p[i].flx = 3;
            }
        }
        if ((fcnt == 1 || fcnt > 2) && fcnt != 9) {
            int[] ais = new int[8];
            int[] is170 = new int[8];
            int[] is171 = new int[4];
            for (int j = 0; j < 4; j++) {
                ais[j] = keyx[j] + x - Medium.x;
                is170[j] = grat + y - Medium.y;
                is171[j] = keyz[j] + z - Medium.z;
            }
            rot(ais, is170, x - Medium.x, y - Medium.y, xy, 4);
            rot(is170, is171, y - Medium.y, z - Medium.y, zy, 4);
            rot(ais, is171, x - Medium.x, z - Medium.z, xz, 4);
            rot(ais, is171, Medium.cx, Medium.cz, Medium.xz, 4);
            rot(is170, is171, Medium.cy, Medium.cz, Medium.zy, 4);
            int i = 0;
            int i172 = 0;
            int i173 = 0;
            for (int i174 = 0; i174 < 4; i174++) {
                for (int i175 = 0; i175 < 4; i175++) {
                    if (Math.abs(ais[i174] - ais[i175]) > i) {
                        i = Math.abs(ais[i174] - ais[i175]);
                    }
                    if (Math.abs(is170[i174] - is170[i175]) > i172) {
                        i172 = Math.abs(is170[i174] - is170[i175]);
                    }
                    if (py(ais[i174], ais[i175], is170[i174], is170[i175]) > i173) {
                        i173 = py(ais[i174], ais[i175], is170[i174], is170[i175]);
                    }
                }
            }
            i173 = (int) (Math.sqrt(i173) / 1.5);
            if (i < i173) {
                i = i173;
            }
            if (i172 < i173) {
                i172 = i173;
            }
            int i176 = Medium.cx + (int) ((x - Medium.x - Medium.cx) * Medium.cos(Medium.xz) - (z - Medium.z - Medium.cz) * Medium.sin(Medium.xz));
            int i177 = Medium.cz + (int) ((x - Medium.x - Medium.cx) * Medium.sin(Medium.xz) + (z - Medium.z - Medium.cz) * Medium.cos(Medium.xz));
            int i178 = Medium.cy + (int) ((y - Medium.y - Medium.cy) * Medium.cos(Medium.zy) - (i177 - Medium.cz) * Medium.sin(Medium.zy));
            i177 = Medium.cz + (int) ((y - Medium.y - Medium.cy) * Medium.sin(Medium.zy) + (i177 - Medium.cz) * Medium.cos(Medium.zy));
            ais[0] = xs((int) (i176 - i / 0.8 - Medium.random() * (i / 2.4)), i177);
            is170[0] = ys((int) (i178 - i172 / 1.92 - Medium.random() * (i172 / 5.67)), i177);
            ais[1] = xs((int) (i176 - i / 0.8 - Medium.random() * (i / 2.4)), i177);
            is170[1] = ys((int) (i178 + i172 / 1.92 + Medium.random() * (i172 / 5.67)), i177);
            ais[2] = xs((int) (i176 - i / 1.92 - Medium.random() * (i / 5.67)), i177);
            is170[2] = ys((int) (i178 + i172 / 0.8 + Medium.random() * (i172 / 2.4)), i177);
            ais[3] = xs((int) (i176 + i / 1.92 + Medium.random() * (i / 5.67)), i177);
            is170[3] = ys((int) (i178 + i172 / 0.8 + Medium.random() * (i172 / 2.4)), i177);
            ais[4] = xs((int) (i176 + i / 0.8 + Medium.random() * (i / 2.4)), i177);
            is170[4] = ys((int) (i178 + i172 / 1.92 + Medium.random() * (i172 / 5.67)), i177);
            ais[5] = xs((int) (i176 + i / 0.8 + Medium.random() * (i / 2.4)), i177);
            is170[5] = ys((int) (i178 - i172 / 1.92 - Medium.random() * (i172 / 5.67)), i177);
            ais[6] = xs((int) (i176 + i / 1.92 + Medium.random() * (i / 5.67)), i177);
            is170[6] = ys((int) (i178 - i172 / 0.8 - Medium.random() * (i172 / 2.4)), i177);
            ais[7] = xs((int) (i176 - i / 1.92 - Medium.random() * (i / 5.67)), i177);
            is170[7] = ys((int) (i178 - i172 / 0.8 - Medium.random() * (i172 / 2.4)), i177);
            if (fcnt == 3) {
                rot(ais, is170, xs(i176, i177), ys(i178, i177), 22, 8);
            }
            if (fcnt == 4) {
                rot(ais, is170, xs(i176, i177), ys(i178, i177), 22, 8);
            }
            if (fcnt == 5) {
                rot(ais, is170, xs(i176, i177), ys(i178, i177), 0, 8);
            }
            if (fcnt == 6) {
                rot(ais, is170, xs(i176, i177), ys(i178, i177), -22, 8);
            }
            if (fcnt == 7) {
                rot(ais, is170, xs(i176, i177), ys(i178, i177), -22, 8);
            }
            int i179 = (int) (191.0F + 191.0F * (Medium.snap[0] / 350.0F));
            if (i179 > 255) {
                i179 = 255;
            }
            if (i179 < 0) {
                i179 = 0;
            }
            int i180 = (int) (232.0F + 232.0F * (Medium.snap[1] / 350.0F));
            if (i180 > 255) {
                i180 = 255;
            }
            if (i180 < 0) {
                i180 = 0;
            }
            int i181 = (int) (255.0F + 255.0F * (Medium.snap[2] / 350.0F));
            if (i181 > 255) {
                i181 = 255;
            }
            if (i181 < 0) {
                i181 = 0;
            }
            G.setColor(new Color(i179, i180, i181));
            G.fillPolygon(ais, is170, 8);
            ais[0] = xs((int) (i176 - i - Medium.random() * (i / 4)), i177);
            is170[0] = ys((int) (i178 - i172 / 2.4 - Medium.random() * (i172 / 9.6)), i177);
            ais[1] = xs((int) (i176 - i - Medium.random() * (i / 4)), i177);
            is170[1] = ys((int) (i178 + i172 / 2.4 + Medium.random() * (i172 / 9.6)), i177);
            ais[2] = xs((int) (i176 - i / 2.4 - Medium.random() * (i / 9.6)), i177);
            is170[2] = ys((int) (i178 + i172 + Medium.random() * (i172 / 4)), i177);
            ais[3] = xs((int) (i176 + i / 2.4 + Medium.random() * (i / 9.6)), i177);
            is170[3] = ys((int) (i178 + i172 + Medium.random() * (i172 / 4)), i177);
            ais[4] = xs((int) (i176 + i + Medium.random() * (i / 4)), i177);
            is170[4] = ys((int) (i178 + i172 / 2.4 + Medium.random() * (i172 / 9.6)), i177);
            ais[5] = xs((int) (i176 + i + Medium.random() * (i / 4)), i177);
            is170[5] = ys((int) (i178 - i172 / 2.4 - Medium.random() * (i172 / 9.6)), i177);
            ais[6] = xs((int) (i176 + i / 2.4 + Medium.random() * (i / 9.6)), i177);
            is170[6] = ys((int) (i178 - i172 - Medium.random() * (i172 / 4)), i177);
            ais[7] = xs((int) (i176 - i / 2.4 - Medium.random() * (i / 9.6)), i177);
            is170[7] = ys((int) (i178 - i172 - Medium.random() * (i172 / 4)), i177);
            i179 = (int) (213.0F + 213.0F * (Medium.snap[0] / 350.0F));
            if (i179 > 255) {
                i179 = 255;
            }
            if (i179 < 0) {
                i179 = 0;
            }
            i180 = (int) (239.0F + 239.0F * (Medium.snap[1] / 350.0F));
            if (i180 > 255) {
                i180 = 255;
            }
            if (i180 < 0) {
                i180 = 0;
            }
            i181 = (int) (255.0F + 255.0F * (Medium.snap[2] / 350.0F));
            if (i181 > 255) {
                i181 = 255;
            }
            if (i181 < 0) {
                i181 = 0;
            }
            G.setColor(new Color(i179, i180, i181));
            G.fillPolygon(ais, is170, 8);
        }
        if (fcnt > 7) {
            fcnt = 0;
            fix = false;
        } else {
            fcnt++;
        }
    }

    public int getpy(int i, int i267, int i268) {
        return (i - x) / 10 * ((i - x) / 10) + (i267 - y) / 10 * ((i267 - y) / 10) + (i268 - z) / 10 * ((i268 - z) / 10);
    }

    private int getvalue(String aastring, String string262, int i)
    {//TODO
        return Utility.getint(aastring, string262, i);
    }

    private void lowshadow(int i) {
        int[] ais = new int[4];
        int[] is146 = new int[4];
        int[] is147 = new int[4];
        int i148 = 1;
        int i149;
        for (i149 = Math.abs(zy); i149 > 270; i149 -= 360) {

        }
        i149 = Math.abs(i149);
        if (i149 > 90) {
            i148 = -1;
        }
        ais[0] = (int) (keyx[0] * 1.2 + x - Medium.x);
        is147[0] = (int) ((keyz[0] + 30) * i148 * 1.2 + z - Medium.z);
        ais[1] = (int) (keyx[1] * 1.2 + x - Medium.x);
        is147[1] = (int) ((keyz[1] + 30) * i148 * 1.2 + z - Medium.z);
        ais[2] = (int) (keyx[3] * 1.2 + x - Medium.x);
        is147[2] = (int) ((keyz[3] - 30) * i148 * 1.2 + z - Medium.z);
        ais[3] = (int) (keyx[2] * 1.2 + x - Medium.x);
        is147[3] = (int) ((keyz[2] - 30) * i148 * 1.2 + z - Medium.z);
        rot(ais, is147, x - Medium.x, z - Medium.z, xz, 4);
        int i150 = (int) (Medium.crgrnd[0] / 1.5);
        int i151 = (int) (Medium.crgrnd[1] / 1.5);
        int i152 = (int) (Medium.crgrnd[2] / 1.5);
        for (int i153 = 0; i153 < 4; i153++) {
            is146[i153] = Medium.ground;
        }
        if (Trackers.ncx != 0 || Trackers.ncz != 0) {
            int i154 = (x - Trackers.sx) / 3000;
            if (i154 > Trackers.ncx) {
                i154 = Trackers.ncx;
            }
            if (i154 < 0) {
                i154 = 0;
            }
            int i155 = (z - Trackers.sz) / 3000;
            if (i155 > Trackers.ncz) {
                i155 = Trackers.ncz;
            }
            if (i155 < 0) {
                i155 = 0;
            }
            for (int i156 = Trackers.sect[i154,i155].Length - 1; i156 >= 0; i156--) {
                int i157 = Trackers.sect[i154,i155][i156];
                int i158 = 0;
                for (int i159 = 0; i159 < 4; i159++)
                    if (Math.abs(Trackers.zy[i157]) != 90 && Math.abs(Trackers.xy[i157]) != 90 && Trackers.rady[i157] != 801 && Math.abs(ais[i159] - (Trackers.x[i157] - Medium.x)) < Trackers.radx[i157] && Math.abs(is147[i159] - (Trackers.z[i157] - Medium.z)) < Trackers.radz[i157] && (!Trackers.decor[i157] || Medium.resdown != 2)) {
                        i158++;
                    }
                if (i158 > 2) {
                    for (int i160 = 0; i160 < 4; i160++) {
                        is146[i160] = Trackers.y[i157] - Medium.y;
                        if (Trackers.zy[i157] != 0) {
                            is146[i160] = (int) (is146[i160] + (is147[i160] - (Trackers.z[i157] - Medium.z - Trackers.radz[i157])) * Medium.sin(Trackers.zy[i157]) / Medium.sin(90 - Trackers.zy[i157]) - Trackers.radz[i157] * Medium.sin(Trackers.zy[i157]) / Medium.sin(90 - Trackers.zy[i157]));
                        }
                        if (Trackers.xy[i157] != 0) {
                            is146[i160] = (int) (is146[i160] + (ais[i160] - (Trackers.x[i157] - Medium.x - Trackers.radx[i157])) * Medium.sin(Trackers.xy[i157]) / Medium.sin(90 - Trackers.xy[i157]) - Trackers.radx[i157] * Medium.sin(Trackers.xy[i157]) / Medium.sin(90 - Trackers.xy[i157]));
                        }
                    }
                    i150 = (int) (Trackers.c[i157][0] / 1.5);
                    i151 = (int) (Trackers.c[i157][1] / 1.5);
                    i152 = (int) (Trackers.c[i157][2] / 1.5);
                    break;
                }
            }
        }
        rot(ais, is147, Medium.cx, Medium.cz, Medium.xz, 4);
        rot(is146, is147, Medium.cy, Medium.cz, Medium.zy, 4);
        boolean aabool = true;
        int i161 = 0;
        int i162 = 0;
        int i163 = 0;
        int i164 = 0;
        for (int i165 = 0; i165 < 4; i165++) {
            ais[i165] = xs(ais[i165], is147[i165]);
            is146[i165] = ys(is146[i165], is147[i165]);
            if (is146[i165] < Medium.ih || is147[i165] < 10) {
                i161++;
            }
            if (is146[i165] > Medium.h || is147[i165] < 10) {
                i162++;
            }
            if (ais[i165] < Medium.iw || is147[i165] < 10) {
                i163++;
            }
            if (ais[i165] > Medium.w || is147[i165] < 10) {
                i164++;
            }
        }
        if (i163 == 4 || i161 == 4 || i162 == 4 || i164 == 4) {
            aabool = false;
        }
        if (aabool) {
            for (int i166 = 0; i166 < 16; i166++)
                if (i > Medium.fade[i166]) {
                    i150 = (i150 * Medium.fogd + Medium.cfade[0]) / (Medium.fogd + 1);
                    i151 = (i151 * Medium.fogd + Medium.cfade[1]) / (Medium.fogd + 1);
                    i152 = (i152 * Medium.fogd + Medium.cfade[2]) / (Medium.fogd + 1);
                }
            G.setColor(new Color(i150, i151, i152));
            G.fillPolygon(ais, is146, 4);
        }
    }

    private void pdust(int i, boolean aabool) {
        if (aabool) {
            sav[i] = (int) Math.sqrt((Medium.x + Medium.cx - sx[i]) * (Medium.x + Medium.cx - sx[i]) + (Medium.y + Medium.cy - sy[i]) * (Medium.y + Medium.cy - sy[i]) + (Medium.z - sz[i]) * (Medium.z - sz[i]));
        }
        if (aabool && sav[i] > dist || !aabool && sav[i] <= dist) {
            int[] ais;
            if (stg[i] == 1) {
                sbln[i] = 0.6F;
                boolean bool208 = false;
                ais = new int[3];
                for (int i209 = 0; i209 < 3; i209++) {
                    ais[i209] = (int) (255.0F + 255.0F * (Medium.snap[i209] / 100.0F));
                    if (ais[i209] > 255) {
                        ais[i209] = 255;
                    }
                    if (ais[i209] < 0) {
                        ais[i209] = 0;
                    }
                }
                int i210 = (x - Trackers.sx) / 3000;
                if (i210 > Trackers.ncx) {
                    i210 = Trackers.ncx;
                }
                if (i210 < 0) {
                    i210 = 0;
                }
                int i211 = (z - Trackers.sz) / 3000;
                if (i211 > Trackers.ncz) {
                    i211 = Trackers.ncz;
                }
                if (i211 < 0) {
                    i211 = 0;
                }
                for (int i212 = 0; i212 < Trackers.sect[i210,i211].Length; i212++) {
                    int i213 = Trackers.sect[i210,i211][i212];
                    if (Math.abs(Trackers.zy[i213]) != 90 && Math.abs(Trackers.xy[i213]) != 90 && Math.abs(sx[i] - Trackers.x[i213]) < Trackers.radx[i213] && Math.abs(sz[i] - Trackers.z[i213]) < Trackers.radz[i213]) {
                        if (Trackers.skd[i213] == 0) {
                            sbln[i] = 0.2F;
                        }
                        if (Trackers.skd[i213] == 1) {
                            sbln[i] = 0.4F;
                        }
                        if (Trackers.skd[i213] == 2) {
                            sbln[i] = 0.45F;
                        }
                        for (int i214 = 0; i214 < 3; i214++) {
                            srgb[i,i214] = (Trackers.c[i213][i214] + ais[i214]) / 2;
                        }
                        bool208 = true;
                    }
                }
                if (!bool208) {
                    for (int i215 = 0; i215 < 3; i215++) {
                        srgb[i,i215] = (Medium.crgrnd[i215] + ais[i215]) / 2;
                    }
                }
                float f = (float) (0.1 + Medium.random());
                if (f > 1.0F) {
                    f = 1.0F;
                }
                scx[i] = (int) (scx[i] * f);
                scz[i] = (int) (scx[i] * f);
                for (int i216 = 0; i216 < 8; i216++) {
                    smag[i,i216] = osmag[i] * Medium.random() * 50.0F;
                }
                for (int i217 = 0; i217 < 8; i217++) {
                    int i218 = i217 - 1;
                    if (i218 == -1) {
                        i218 = 7;
                    }
                    int i219 = i217 + 1;
                    if (i219 == 8) {
                        i219 = 0;
                    }
                    smag[i,i217] = ((smag[i,i218] + smag[i,i219]) / 2.0F + smag[i,i217]) / 2.0F;
                }
                smag[i,6] = smag[i,7];
            }
            int i220 = Medium.cx + (int) ((sx[i] - Medium.x - Medium.cx) * Medium.cos(Medium.xz) - (sz[i] - Medium.z - Medium.cz) * Medium.sin(Medium.xz));
            int i221 = Medium.cz + (int) ((sx[i] - Medium.x - Medium.cx) * Medium.sin(Medium.xz) + (sz[i] - Medium.z - Medium.cz) * Medium.cos(Medium.xz));
            int i222 = Medium.cy + (int) ((sy[i] - Medium.y - Medium.cy - smag[i,7]) * Medium.cos(Medium.zy) - (i221 - Medium.cz) * Medium.sin(Medium.zy));
            i221 = Medium.cz + (int) ((sy[i] - Medium.y - Medium.cy - smag[i,7]) * Medium.sin(Medium.zy) + (i221 - Medium.cz) * Medium.cos(Medium.zy));
            sx[i] += scx[i] / (stg[i] + 1);
            sz[i] += scz[i] / (stg[i] + 1);
            ais = new int[8];
            int[] is223 = new int[8];
            ais[0] = xs((int) (i220 + smag[i,0] * 0.9238F * 1.5F), i221);
            is223[0] = ys((int) (i222 + smag[i,0] * 0.3826F * 1.5F), i221);
            ais[1] = xs((int) (i220 + smag[i,1] * 0.9238F * 1.5F), i221);
            is223[1] = ys((int) (i222 - smag[i,1] * 0.3826F * 1.5F), i221);
            ais[2] = xs((int) (i220 + smag[i,2] * 0.3826F), i221);
            is223[2] = ys((int) (i222 - smag[i,2] * 0.9238F), i221);
            ais[3] = xs((int) (i220 - smag[i,3] * 0.3826F), i221);
            is223[3] = ys((int) (i222 - smag[i,3] * 0.9238F), i221);
            ais[4] = xs((int) (i220 - smag[i,4] * 0.9238F * 1.5F), i221);
            is223[4] = ys((int) (i222 - smag[i,4] * 0.3826F * 1.5F), i221);
            ais[5] = xs((int) (i220 - smag[i,5] * 0.9238F * 1.5F), i221);
            is223[5] = ys((int) (i222 + smag[i,5] * 0.3826F * 1.5F), i221);
            ais[6] = xs((int) (i220 - smag[i,6] * 0.3826F * 1.7F), i221);
            is223[6] = ys((int) (i222 + smag[i,6] * 0.9238F), i221);
            ais[7] = xs((int) (i220 + smag[i,7] * 0.3826F * 1.7F), i221);
            is223[7] = ys((int) (i222 + smag[i,7] * 0.9238F), i221);
            for (int i224 = 0; i224 < 7; i224++) {
                smag[i,i224] += 5.0F + Medium.random() * 15.0F;
            }
            smag[i,7] = smag[i,6];
            boolean bool225 = true;
            int i226 = 0;
            int i227 = 0;
            int i228 = 0;
            int i229 = 0;
            for (int i230 = 0; i230 < 8; i230++) {
                if (is223[i230] < Medium.ih || i221 < 10) {
                    i226++;
                }
                if (is223[i230] > Medium.h || i221 < 10) {
                    i227++;
                }
                if (ais[i230] < Medium.iw || i221 < 10) {
                    i228++;
                }
                if (ais[i230] > Medium.w || i221 < 10) {
                    i229++;
                }
            }
            if (i228 == 4 || i226 == 4 || i227 == 4 || i229 == 4) {
                bool225 = false;
            }
            if (bool225) {
                int i231 = srgb[i,0];
                int i232 = srgb[i,1];
                int i233 = srgb[i,2];
                for (int i234 = 0; i234 < 16; i234++)
                    if (sav[i] > Medium.fade[i234]) {
                        i231 = (i231 * Medium.fogd + Medium.cfade[0]) / (Medium.fogd + 1);
                        i232 = (i232 * Medium.fogd + Medium.cfade[1]) / (Medium.fogd + 1);
                        i233 = (i233 * Medium.fogd + Medium.cfade[2]) / (Medium.fogd + 1);
                    }
                G.setColor(new Color(i231, i232, i233));
                float f = sbln[i] - stg[i] * (sbln[i] / 8.0F);
                G.setAlpha(f);
                G.fillPolygon(ais, is223, 8);
                G.setAlpha(1.0F);
            }
            if (stg[i] == 7) {
                stg[i] = 0;
            } else {
                stg[i]++;
            }
        }
    }

    private int py(int i, int i269, int i270, int i271) {
        return (i - i269) * (i - i269) + (i270 - i271) * (i270 - i271);
    }

    private void rot(int[] ais, int[] is272, int i, int i273, int i274, int i275) {
        if (i274 != 0) {
            for (int i276 = 0; i276 < i275; i276++) {
                int i277 = ais[i276];
                int i278 = is272[i276];
                ais[i276] = i + (int) ((i277 - i) * Medium.cos(i274) - (i278 - i273) * Medium.sin(i274));
                is272[i276] = i273 + (int) ((i277 - i) * Medium.sin(i274) + (i278 - i273) * Medium.cos(i274));
            }
        }
    }

    void spark(float f, float f235, float f236, float f237, float f238, float f239, int i) {
        if (i != 1) {
            srx = (int) (f - sprkat * Medium.sin(xz));
            sry = (int) (f235 - sprkat * Medium.cos(zy) * Medium.cos(xy));
            srz = (int) (f236 + sprkat * Medium.cos(xz));
            sprk = 1;
        } else {
            sprk++;
            if (sprk == 4) {
                srx = (int) (x + f237);
                sry = (int) f235;
                srz = (int) (z + f239);
                sprk = 5;
            } else {
                srx = (int) f;
                sry = (int) f235;
                srz = (int) f236;
            }
        }
        if (i == 2) {
            sprk = 6;
        }
        rcx = f237;
        rcy = f238;
        rcz = f239;
    }

    private int xs(int i, int i260) {
        if (i260 < 50) {
            i260 = 50;
        }
        return (i260 - Medium.focusPoint) * (Medium.cx - i) / i260 + i;
    }

    private int ys(int i, int i261) {
        if (i261 < 50) {
            i261 = 50;
        }
        return (i261 - Medium.focusPoint) * (Medium.cy - i) / i261 + i;
    }
}

}