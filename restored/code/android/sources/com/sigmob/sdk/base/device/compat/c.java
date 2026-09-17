package com.sigmob.sdk.base.device.compat;

import android.os.Build;
import android.text.TextUtils;
import cn.thinkingdata.core.router.TRouterMap;
import com.bykv.vk.component.ttvideo.LiveConfigKey;
import java.lang.reflect.Field;
import java.lang.reflect.Method;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/* JADX INFO: loaded from: classes3.dex */
public final class c {
    static final String[] A;
    static final int B = -294058204;
    static final String C = "FuntouchOS";
    static final String D = "ro.vivo.os.build.display.id";
    static final int E = -1801284559;
    static final String F = "MagicOS";
    static final String[] G;
    static final int H = -182666708;
    static final String I = "HarmonyOS NEXT AndroidCompatible";
    static final String J = "ro.sys.anco.product.software.version";
    static final String[] K;
    static final String[] L;
    static final int M = 1583864138;
    static final String N = "HarmonyOS";
    static final String[] O;
    static final String[] P;
    static final int Q = 2132284;
    static final String R = "EMUI";
    static final String S = "ro.build.version.emui";
    static final int T = 76334938;
    static final String U = "OneUI";
    static final String V = "ro.build.version.oneui";
    static final int W = -1363277916;
    static final String X = "OxygenOS";
    static final String Y = "ro.oxygen.version";
    static final int Z = 2195534;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    static final String f3212a = "\\d+(?:\\.\\d+)+";
    static final String aA = "ZUXOS";
    static final String[] aB;
    static final String aC = "ro.config.lgsi.os.name";
    static final int aD = 89198;
    static final String aE = "ZUI";
    static final String aF = "ro.com.zui.version";
    static final String[] aG;
    static final int aH = -2010470489;
    static final String aI = "nubiaUI";
    static final String aJ = "ro.build.nubia.rom.code";
    static final String aK = "ro.build.nubia.rom.name";
    static final int aL = 12510861;
    static final String aM = "ObricUI";
    static final String[] aN;
    static final String aO = "init.svc.bytecellular";
    static final int aP = 78153150;
    static final String aQ = "ROGUI";
    static final String aR = "ro.build.version.incremental";
    static final String aS = "ro.asus.rog";
    static final int aT = 48757121;
    static final String aU = "360UI";
    static final String aV = "ro.build.uiversion";
    private static int aW = 0;
    private static String aX = null;
    private static String aY = null;
    static final String aa = "H2OS";
    static final String ab = "ro.rom.version";
    static final int ac = 67983659;
    static final String ad = "Flyme";
    static final String ae = "ro.build.display.id";
    static final String[] af;
    static final String ag = "ro.build.MiFavor_version";
    static final String ah = "ro.build.display.id";
    static final int ai = -417455456;
    static final String aj = "RedMagicOS";
    static final int ak = -1668450325;
    static final String al = "NebulaAIOS";
    static final int am = 2412720;
    static final String an = "MyOS";
    static final int ao = -203064298;
    static final String ap = "MifavorUI";
    static final String aq = "ro.build.MiFavor_version";
    static final int ar = 1805724132;
    static final String as = "SmartisanOS";
    static final String at = "ro.smartisan.version";
    static final String[] au;
    static final int av = 69017;
    static final String aw = "EUI";
    static final String ax = "ro.letv.release.version";
    static final String[] ay;
    static final int az = 85736225;
    static final String b = "\\d+";
    static final String c = "ro.build.version.incremental";
    static final String d = "ro.build.display.id";
    static final String[] e;
    static final int f = -1248529104;
    static final String g = "HyperOS";
    static final String h = "ro.mi.os.version.incremental";
    static final String[] i;
    static final String[] j;
    static final int k = 2366768;
    static final String l = "MIUI";
    static final String m = "ro.build.version.incremental";
    static final String[] n;
    static final String[] o;
    static final int p = -859411254;
    static final String q = "realmeUI";
    static final String r = "ro.build.version.realmeui";
    static final int s = -1680767897;
    static final String t = "ColorOS";
    static final String u = "ro.build.version.oplusrom";
    static final String[] v;
    static final String w = "ro.build.version.opporom";
    static final String x = "ro.vivo.os.build.display.id";
    static final int y = 1443687338;
    static final String z = "OriginOS";

    /* JADX WARN: Code duplicated, block: B:101:0x031a  */
    /* JADX WARN: Code duplicated, block: B:102:0x031f  */
    /* JADX WARN: Code duplicated, block: B:104:0x0327  */
    /* JADX WARN: Code duplicated, block: B:105:0x032f  */
    /* JADX WARN: Code duplicated, block: B:107:0x0337  */
    /* JADX WARN: Code duplicated, block: B:110:0x034d  */
    /* JADX WARN: Code duplicated, block: B:11:0x0112  */
    /* JADX WARN: Code duplicated, block: B:121:0x0396  */
    /* JADX WARN: Code duplicated, block: B:126:0x03be  */
    /* JADX WARN: Code duplicated, block: B:128:0x03c6  */
    /* JADX WARN: Code duplicated, block: B:13:0x011e  */
    /* JADX WARN: Code duplicated, block: B:152:0x0459  */
    /* JADX WARN: Code duplicated, block: B:15:0x012e  */
    /* JADX WARN: Code duplicated, block: B:166:0x04c0  */
    /* JADX WARN: Code duplicated, block: B:169:0x04c6  */
    /* JADX WARN: Code duplicated, block: B:174:0x025e A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:176:0x0484 A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:178:0x023d A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:17:0x0139  */
    /* JADX WARN: Code duplicated, block: B:180:? A[RETURN, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:18:0x0142  */
    /* JADX WARN: Code duplicated, block: B:20:0x014e  */
    /* JADX WARN: Code duplicated, block: B:23:0x015b  */
    /* JADX WARN: Code duplicated, block: B:25:0x0167  */
    /* JADX WARN: Code duplicated, block: B:27:0x0173  */
    /* JADX WARN: Code duplicated, block: B:29:0x0183  */
    /* JADX WARN: Code duplicated, block: B:31:0x018f  */
    /* JADX WARN: Code duplicated, block: B:49:0x01f4  */
    /* JADX WARN: Code duplicated, block: B:56:0x0220  */
    /* JADX WARN: Code duplicated, block: B:58:0x0231  */
    /* JADX WARN: Code duplicated, block: B:62:0x0248  */
    /* JADX WARN: Code duplicated, block: B:64:0x0250  */
    /* JADX WARN: Code duplicated, block: B:71:0x0277 A[Catch: Exception -> 0x027e, TRY_LEAVE, TryCatch #0 {Exception -> 0x027e, blocks: (B:69:0x025e, B:71:0x0277), top: B:174:0x025e }] */
    /* JADX WARN: Code duplicated, block: B:74:0x0282  */
    /* JADX WARN: Code duplicated, block: B:76:0x028e  */
    /* JADX WARN: Code duplicated, block: B:79:0x02a1  */
    /* JADX WARN: Code duplicated, block: B:81:0x02ad  */
    /* JADX WARN: Code duplicated, block: B:93:0x02f6  */
    /* JADX WARN: Code duplicated, block: B:95:0x0302  */
    /* JADX WARN: Code duplicated, block: B:99:0x0312  */
    static {
        String strA;
        Object objInvoke;
        String strA2;
        String strA3;
        String strA4;
        String strA5;
        String strA6;
        String lowerCase;
        String strA7;
        String str;
        String strA8;
        String strA9;
        String strA10;
        int i2;
        String strA11;
        String strA12;
        String strA13;
        String strA14;
        String strA15;
        String strA16;
        String[] strArr = {"ro.miui.build.region", "ro.miui.region", "ro.vendor.miui.region"};
        e = strArr;
        String[] strArr2 = {"ro.mi.os.version.name", "ro.mi.os.version.code", h};
        i = strArr2;
        j = strArr;
        String[] strArr3 = {"ro.miui.ui.version.name", "ro.miui.ui.version.code"};
        n = strArr3;
        o = strArr;
        String[] strArr4 = {"ro.build.display.id", "ro.build.display.id.show", "persist.sys.oplus.ota_ver_display", u, "ro.build.version.oplusrom.confidential"};
        v = strArr4;
        String[] strArr5 = {"ro.vivo.product.version", "ro.vivo.default.version", "ro.vivo.build.version.incremental", "ro.vivo.product.version.incremental", "ro.vivo.build.version", "ro.vivo.system.product.version", "ro.build.software.version"};
        A = strArr5;
        String[] strArr6 = {"msc.config.magic.version", "ro.build.version.magic"};
        G = strArr6;
        String[] strArr7 = {"ro.product.anco.devicetype", J, "ro.product.os.dist.anco.apiversion", "ro.product.os.dist.anco.releasetype"};
        K = strArr7;
        String[] strArr8 = {"ro.honor.build.display.id", "persist.sys.hiview.base_version", "ro.comp.hl.product_base_version", "ro.build.display.id"};
        L = strArr8;
        String[] strArr9 = {"ro.huawei.build.display.id", "ro.comp.hl.product_base_version", "persist.sys.hiview.base_version", com.alipay.sdk.m.d.a.b};
        O = strArr9;
        String[] strArr10 = {"ro.build.ohos.devicetype", "persist.sys.ohos.osd.cloud.switch"};
        P = strArr10;
        af = new String[]{"ro.flyme.published", "ro.flyme.version.id"};
        au = new String[]{"ro.smartisan.sa", at};
        ay = new String[]{ax, "ro.letv.release.version_date", "ro.product.letv_model", "ro.product.letv_name", "sys.letv.fmodelaid", "persist.sys.leui.bootreason", "ro.config.leui_ringtone_slot2", "ro.leui_oem_unlock_enable"};
        aB = new String[]{"ro.config.lgsi.fp.incremental", "ro.config.lgsi.os.version"};
        aG = new String[]{aF, "ro.zui.version.status", "ro.zui.hardware.displayid", "persist.radio.zui.feature", "ro.config.zuisdk.enabled"};
        aN = new String[]{"ro.build.id", "ro.product.build.id", "ro.system.build.id", "ro.system_ext.build.id", "ro.build.display.id"};
        if (!d.c(strArr2)) {
            if (d.c(strArr3)) {
                aW = k;
                aX = l;
                strA = a("ro.build.version.incremental");
            }
            if (aX == null) {
                strA14 = d.a(r);
                if (!TextUtils.isEmpty(strA14)) {
                    aW = p;
                    aX = q;
                    strA16 = a(strA14);
                } else if (d.b(u)) {
                    aW = s;
                    aX = t;
                    strA16 = a(strArr4);
                } else {
                    strA15 = d.a(w);
                    if (!TextUtils.isEmpty(strA15)) {
                        aW = s;
                        aX = t;
                        strA16 = a(strA15);
                    }
                }
                aY = strA16;
            }
            if (aX == null) {
                strA12 = d.a("ro.vivo.os.build.display.id");
                if (!TextUtils.isEmpty(strA12)) {
                    if (strA12.toLowerCase().contains(LiveConfigKey.ORIGIN)) {
                        aW = y;
                        aX = z;
                        strA13 = a(strArr5);
                    } else if (strA12.toLowerCase().contains("funtouch")) {
                        aW = B;
                        aX = C;
                        strA13 = a("ro.vivo.os.build.display.id");
                    }
                    aY = strA13;
                }
            }
            if (aX == null && d.c(strArr6)) {
                aW = E;
                aX = F;
                aY = a(strArr8);
            }
            if (aX == null && d.c(strArr7)) {
                aW = H;
                aX = I;
                aY = a(J);
            }
            if (aX == null && d.c(strArr10)) {
                aW = M;
                aX = N;
                aY = a(strArr9);
            }
            if (aX == null) {
                strA11 = d.a("ro.build.version.emui");
                if (!TextUtils.isEmpty(strA11) && strA11.toLowerCase().contains("emotionui")) {
                    aW = Q;
                    aX = R;
                    aY = a(strA11);
                }
            }
            if (aX == null) {
                strA10 = d.a(V);
                if (!TextUtils.isEmpty(strA10)) {
                    aW = T;
                    aX = U;
                    if (strA10.matches(b)) {
                        try {
                            aY = a(Integer.parseInt(strA10));
                        } catch (Exception unused) {
                        }
                    } else if (strA10.matches(f3212a)) {
                        aY = strA10;
                    }
                }
                if (aX != null || TextUtils.isEmpty(aY)) {
                    try {
                        Field declaredField = Build.VERSION.class.getDeclaredField("SEM_PLATFORM_INT");
                        declaredField.setAccessible(true);
                        i2 = declaredField.getInt(null);
                        aW = T;
                        aX = U;
                        if (i2 >= 90000) {
                            aY = a(i2 - 90000);
                        }
                    } catch (Exception unused2) {
                    }
                }
            }
            if (aX == null) {
                strA9 = d.a(Y);
                if (!TextUtils.isEmpty(strA9)) {
                    aW = W;
                    aX = X;
                    aY = a(strA9);
                }
            }
            if (aX == null) {
                strA8 = d.a(ab);
                if (!TextUtils.isEmpty(strA8)) {
                    aW = Z;
                    aX = aa;
                    aY = a(strA8);
                }
            }
            if (aX == null && d.c(af)) {
                aW = ac;
                aX = ad;
                aY = a("ro.build.display.id");
            }
            if (aX == null && d.b("ro.build.MiFavor_version")) {
                strA6 = d.a("ro.build.display.id");
                if (!TextUtils.isEmpty(strA6)) {
                    lowerCase = strA6.toLowerCase();
                    if (lowerCase.contains("nebulaaios")) {
                        aW = ak;
                        str = al;
                    } else if (lowerCase.contains("redmagicos")) {
                        aW = ai;
                        aX = aj;
                        strA7 = a(strA6);
                        aY = strA7;
                    } else if (lowerCase.contains("myos")) {
                        aW = am;
                        str = an;
                    } else if (lowerCase.contains("zte")) {
                        aW = ao;
                        aX = ap;
                        strA7 = a("ro.build.MiFavor_version");
                        aY = strA7;
                    }
                    aX = str;
                    strA7 = a(strA6);
                    aY = strA7;
                }
            }
            if (aX == null) {
                strA5 = d.a(aK);
                if (!TextUtils.isEmpty(strA5) && strA5.toLowerCase().contains("nubiaui")) {
                    aW = aH;
                    aX = aI;
                    aY = a(aJ);
                    if (Build.VERSION.SDK_INT >= 27 && d(Build.VERSION.RELEASE) - J() >= 5) {
                        aW = ai;
                        aX = aj;
                    }
                }
            }
            if (aX == null) {
                strA3 = d.a(aC);
                if (TextUtils.isEmpty(strA3) && strA3.toLowerCase().contains("zuxos")) {
                    aW = az;
                    aX = aA;
                    strA4 = a(aB);
                } else if (d.c(aG)) {
                    aW = aD;
                    aX = aE;
                    strA4 = a(aF);
                }
                aY = strA4;
            }
            if (aX == null && d.b(aO)) {
                aW = aL;
                aX = aM;
                aY = a(aN);
            }
            if (aX == null && d.b(aS)) {
                aW = aP;
                aX = aQ;
                aY = a("ro.build.version.incremental");
            }
            if (aX == null && d.c(au)) {
                aW = ar;
                aX = as;
                aY = a(at);
            }
            if (aX == null && d.c(ay)) {
                aW = av;
                aX = aw;
                aY = a(ax);
            }
            if (aX == null) {
                strA2 = d.a(aV);
                if (!TextUtils.isEmpty(strA2) && strA2.toLowerCase().contains("360ui")) {
                    aW = aT;
                    aX = aU;
                    aY = a(strA2);
                }
            }
            if (aX == null) {
                try {
                    Class<?> cls = Class.forName("com.huawei.system.BuildEx");
                    Method method = cls.getMethod("getOsBrand", new Class[0]);
                    method.setAccessible(true);
                    objInvoke = method.invoke(cls, new Object[0]);
                    if (objInvoke != null && String.valueOf(objInvoke).toLowerCase().contains("harmony")) {
                        aW = M;
                        aX = N;
                        aY = a(O);
                    }
                } catch (Exception unused3) {
                }
            }
            if (aX == null) {
                aX = "";
            }
            if (aY == null) {
                aY = "";
            }
        }
        aW = f;
        aX = g;
        strA = a(h);
        aY = strA;
        if (aX == null) {
            strA14 = d.a(r);
            if (!TextUtils.isEmpty(strA14)) {
                aW = p;
                aX = q;
                strA16 = a(strA14);
            } else if (d.b(u)) {
                aW = s;
                aX = t;
                strA16 = a(strArr4);
            } else {
                strA15 = d.a(w);
                if (!TextUtils.isEmpty(strA15)) {
                    aW = s;
                    aX = t;
                    strA16 = a(strA15);
                }
            }
            aY = strA16;
        }
        if (aX == null) {
            strA12 = d.a("ro.vivo.os.build.display.id");
            if (!TextUtils.isEmpty(strA12)) {
                if (strA12.toLowerCase().contains(LiveConfigKey.ORIGIN)) {
                    aW = y;
                    aX = z;
                    strA13 = a(strArr5);
                } else if (strA12.toLowerCase().contains("funtouch")) {
                    aW = B;
                    aX = C;
                    strA13 = a("ro.vivo.os.build.display.id");
                }
                aY = strA13;
            }
        }
        if (aX == null) {
            aW = E;
            aX = F;
            aY = a(strArr8);
        }
        if (aX == null) {
            aW = H;
            aX = I;
            aY = a(J);
        }
        if (aX == null) {
            aW = M;
            aX = N;
            aY = a(strArr9);
        }
        if (aX == null) {
            strA11 = d.a("ro.build.version.emui");
            if (!TextUtils.isEmpty(strA11)) {
                aW = Q;
                aX = R;
                aY = a(strA11);
            }
        }
        if (aX == null) {
            strA10 = d.a(V);
            if (!TextUtils.isEmpty(strA10)) {
                aW = T;
                aX = U;
                if (strA10.matches(b)) {
                    aY = a(Integer.parseInt(strA10));
                } else if (strA10.matches(f3212a)) {
                    aY = strA10;
                }
            }
            if (aX != null) {
                Field declaredField2 = Build.VERSION.class.getDeclaredField("SEM_PLATFORM_INT");
                declaredField2.setAccessible(true);
                i2 = declaredField2.getInt(null);
                aW = T;
                aX = U;
                if (i2 >= 90000) {
                    aY = a(i2 - 90000);
                }
            } else {
                Field declaredField3 = Build.VERSION.class.getDeclaredField("SEM_PLATFORM_INT");
                declaredField3.setAccessible(true);
                i2 = declaredField3.getInt(null);
                aW = T;
                aX = U;
                if (i2 >= 90000) {
                    aY = a(i2 - 90000);
                }
            }
        }
        if (aX == null) {
            strA9 = d.a(Y);
            if (!TextUtils.isEmpty(strA9)) {
                aW = W;
                aX = X;
                aY = a(strA9);
            }
        }
        if (aX == null) {
            strA8 = d.a(ab);
            if (!TextUtils.isEmpty(strA8)) {
                aW = Z;
                aX = aa;
                aY = a(strA8);
            }
        }
        if (aX == null) {
            aW = ac;
            aX = ad;
            aY = a("ro.build.display.id");
        }
        if (aX == null) {
            strA6 = d.a("ro.build.display.id");
            if (!TextUtils.isEmpty(strA6)) {
                lowerCase = strA6.toLowerCase();
                if (lowerCase.contains("nebulaaios")) {
                    aW = ak;
                    str = al;
                } else if (lowerCase.contains("redmagicos")) {
                    aW = ai;
                    aX = aj;
                    strA7 = a(strA6);
                    aY = strA7;
                } else if (lowerCase.contains("myos")) {
                    aW = am;
                    str = an;
                } else if (lowerCase.contains("zte")) {
                    aW = ao;
                    aX = ap;
                    strA7 = a("ro.build.MiFavor_version");
                    aY = strA7;
                }
                aX = str;
                strA7 = a(strA6);
                aY = strA7;
            }
        }
        if (aX == null) {
            strA5 = d.a(aK);
            if (!TextUtils.isEmpty(strA5)) {
                aW = aH;
                aX = aI;
                aY = a(aJ);
                if (Build.VERSION.SDK_INT >= 27) {
                    aW = ai;
                    aX = aj;
                }
            }
        }
        if (aX == null) {
            strA3 = d.a(aC);
            if (TextUtils.isEmpty(strA3)) {
                if (d.c(aG)) {
                    aW = aD;
                    aX = aE;
                    strA4 = a(aF);
                    aY = strA4;
                }
            } else if (d.c(aG)) {
                aW = aD;
                aX = aE;
                strA4 = a(aF);
                aY = strA4;
            }
        }
        if (aX == null) {
            aW = aL;
            aX = aM;
            aY = a(aN);
        }
        if (aX == null) {
            aW = aP;
            aX = aQ;
            aY = a("ro.build.version.incremental");
        }
        if (aX == null) {
            aW = ar;
            aX = as;
            aY = a(at);
        }
        if (aX == null) {
            aW = av;
            aX = aw;
            aY = a(ax);
        }
        if (aX == null) {
            strA2 = d.a(aV);
            if (!TextUtils.isEmpty(strA2)) {
                aW = aT;
                aX = aU;
                aY = a(strA2);
            }
        }
        if (aX == null) {
            Class<?> cls2 = Class.forName("com.huawei.system.BuildEx");
            Method method2 = cls2.getMethod("getOsBrand", new Class[0]);
            method2.setAccessible(true);
            objInvoke = method2.invoke(cls2, new Object[0]);
            if (objInvoke != null) {
                aW = M;
                aX = N;
                aY = a(O);
            }
        }
        if (aX == null) {
            aX = "";
        }
        if (aY == null) {
            aY = "";
        }
    }

    private c() {
    }

    public static boolean A() {
        return aW == av;
    }

    public static boolean B() {
        return aW == az;
    }

    public static boolean C() {
        return aW == aD;
    }

    public static boolean D() {
        return aW == aH;
    }

    public static boolean E() {
        return aW == aL;
    }

    public static boolean F() {
        return aW == aP;
    }

    public static boolean G() {
        return aW == aT;
    }

    public static String H() {
        String str = aX;
        return str != null ? str : "";
    }

    public static String I() {
        String str = aY;
        return str != null ? str : "";
    }

    public static int J() {
        return d(I());
    }

    private static boolean K() {
        try {
            Class<?> cls = Class.forName("android.os.SystemProperties");
            String strValueOf = String.valueOf(cls.getMethod("get", String.class, String.class).invoke(cls, "ro.miui.cts", ""));
            Method method = cls.getMethod("getBoolean", String.class, Boolean.TYPE);
            Object[] objArr = new Object[2];
            objArr[0] = "persist.sys.miui_optimization";
            objArr[1] = Boolean.valueOf("1".equals(strValueOf) ? false : true);
            return Boolean.parseBoolean(String.valueOf(method.invoke(cls, objArr)));
        } catch (Exception unused) {
            return true;
        }
    }

    private static String a(int oneUiVersionCode) {
        int i2 = oneUiVersionCode / 10000;
        int i3 = oneUiVersionCode % 10000;
        int i4 = oneUiVersionCode % 100;
        return (i4 > 0 ? new StringBuilder().append(i2).append(TRouterMap.DOT).append(i3 / 100).append(TRouterMap.DOT).append(i4) : new StringBuilder().append(i2).append(TRouterMap.DOT).append(i3 / 100)).toString();
    }

    private static String a(String text) {
        String strB = b(text);
        if (!TextUtils.isEmpty(strB)) {
            return strB;
        }
        int iC = c(text);
        return iC > 0 ? iC + ".0" : "";
    }

    private static String a(String... systemPropertyKeys) {
        for (String str : systemPropertyKeys) {
            String strB = b(d.a(str));
            if (!TextUtils.isEmpty(strB)) {
                return strB;
            }
        }
        for (String str2 : systemPropertyKeys) {
            int iC = c(d.a(str2));
            if (iC > 0) {
                return iC + ".0";
            }
        }
        return "";
    }

    public static boolean a() {
        return aW == f;
    }

    private static String b(String text) {
        String strGroup;
        if (TextUtils.isEmpty(text)) {
            return "";
        }
        Matcher matcher = Pattern.compile("(\\d+(?:\\.\\d+)+)").matcher(text);
        return (!matcher.find() || matcher.groupCount() <= 0 || (strGroup = matcher.group(1)) == null) ? "" : strGroup;
    }

    public static boolean b() {
        if (!a()) {
            return false;
        }
        for (String str : d.a(j)) {
            if (str.equalsIgnoreCase("cn")) {
                return true;
            }
        }
        return false;
    }

    private static int c(String text) {
        String strGroup;
        Matcher matcher = Pattern.compile("(\\d+)").matcher(text);
        if (!matcher.find() || matcher.groupCount() <= 0 || (strGroup = matcher.group(1)) == null) {
            return 0;
        }
        try {
            return Integer.parseInt(strGroup);
        } catch (Exception unused) {
            return 0;
        }
    }

    public static boolean c() {
        if (!a()) {
            return false;
        }
        for (String str : d.a(j)) {
            if (str.equalsIgnoreCase("global")) {
                return true;
            }
        }
        return false;
    }

    private static int d(String text) {
        if (text != null && !text.isEmpty()) {
            String[] strArrSplit = text.split("\\.");
            if (strArrSplit.length == 0) {
                return -1;
            }
            try {
                return Integer.parseInt(strArrSplit[0]);
            } catch (Exception unused) {
            }
        }
        return -1;
    }

    public static boolean d() {
        return K();
    }

    public static boolean e() {
        return aW == k;
    }

    public static boolean f() {
        if (!e()) {
            return false;
        }
        for (String str : d.a(o)) {
            if (str.equalsIgnoreCase("cn")) {
                return true;
            }
        }
        return false;
    }

    public static boolean g() {
        if (!e()) {
            return false;
        }
        for (String str : d.a(o)) {
            if (str.equalsIgnoreCase("global")) {
                return true;
            }
        }
        return false;
    }

    public static boolean h() {
        return K();
    }

    public static boolean i() {
        return aW == p;
    }

    public static boolean j() {
        return aW == s;
    }

    public static boolean k() {
        return aW == y;
    }

    public static boolean l() {
        return aW == B;
    }

    public static boolean m() {
        return aW == E;
    }

    public static boolean n() {
        return aW == M;
    }

    @Deprecated
    public static boolean o() {
        return p();
    }

    public static boolean p() {
        return aW == H;
    }

    public static boolean q() {
        return aW == Q;
    }

    public static boolean r() {
        return aW == T;
    }

    public static boolean s() {
        return aW == W;
    }

    public static boolean t() {
        return aW == Z;
    }

    public static boolean u() {
        return aW == ac;
    }

    public static boolean v() {
        return aW == ai;
    }

    public static boolean w() {
        return aW == ak;
    }

    public static boolean x() {
        return aW == am;
    }

    public static boolean y() {
        return aW == ao;
    }

    public static boolean z() {
        return aW == ar;
    }
}
