package com.qq.gdt.action.d;

import android.content.Context;
import android.os.Build;
import android.provider.Settings;
import android.text.TextUtils;
import com.qq.gdt.action.i.o;

/* JADX INFO: loaded from: classes3.dex */
public final class b {

    /* JADX INFO: renamed from: com.qq.gdt.action.d.b$1, reason: invalid class name */
    static /* synthetic */ class AnonymousClass1 {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        static final /* synthetic */ int[] f3032a;
        static final /* synthetic */ int[] b;

        static {
            int[] iArr = new int[a.values().length];
            b = iArr;
            try {
                iArr[a.ANDROIDID_TYPE.ordinal()] = 1;
            } catch (NoSuchFieldError unused) {
            }
            try {
                b[a.IMEI_TYPE.ordinal()] = 2;
            } catch (NoSuchFieldError unused2) {
            }
            try {
                b[a.IMEI0_TYPE.ordinal()] = 3;
            } catch (NoSuchFieldError unused3) {
            }
            try {
                b[a.IMEI1_TYPE.ordinal()] = 4;
            } catch (NoSuchFieldError unused4) {
            }
            try {
                b[a.DEVICEID_TYPE.ordinal()] = 5;
            } catch (NoSuchFieldError unused5) {
            }
            try {
                b[a.DEVICEID0_TYPE.ordinal()] = 6;
            } catch (NoSuchFieldError unused6) {
            }
            try {
                b[a.DEVICEID1_TYPE.ordinal()] = 7;
            } catch (NoSuchFieldError unused7) {
            }
            try {
                b[a.MEID_TYPE.ordinal()] = 8;
            } catch (NoSuchFieldError unused8) {
            }
            try {
                b[a.MEID0_TYPE.ordinal()] = 9;
            } catch (NoSuchFieldError unused9) {
            }
            try {
                b[a.MEID1_TYPE.ordinal()] = 10;
            } catch (NoSuchFieldError unused10) {
            }
            try {
                b[a.BUILD_MODEL_TYPE.ordinal()] = 11;
            } catch (NoSuchFieldError unused11) {
            }
            try {
                b[a.BSSID_TYPE.ordinal()] = 12;
            } catch (NoSuchFieldError unused12) {
            }
            try {
                b[a.IMSI_TYPE.ordinal()] = 13;
            } catch (NoSuchFieldError unused13) {
            }
            int[] iArr2 = new int[EnumC0551b.values().length];
            f3032a = iArr2;
            try {
                iArr2[EnumC0551b.IMEI.ordinal()] = 1;
            } catch (NoSuchFieldError unused14) {
            }
            try {
                f3032a[EnumC0551b.MEID.ordinal()] = 2;
            } catch (NoSuchFieldError unused15) {
            }
            try {
                f3032a[EnumC0551b.ANDROID_ID.ordinal()] = 3;
            } catch (NoSuchFieldError unused16) {
            }
            try {
                f3032a[EnumC0551b.DEVICEID.ordinal()] = 4;
            } catch (NoSuchFieldError unused17) {
            }
            try {
                f3032a[EnumC0551b.BSSID.ordinal()] = 5;
            } catch (NoSuchFieldError unused18) {
            }
            try {
                f3032a[EnumC0551b.IMSI.ordinal()] = 6;
            } catch (NoSuchFieldError unused19) {
            }
        }
    }

    enum a {
        ANDROIDID_TYPE,
        IMEI_TYPE,
        IMEI0_TYPE,
        IMEI1_TYPE,
        DEVICEID_TYPE,
        DEVICEID0_TYPE,
        DEVICEID1_TYPE,
        MEID_TYPE,
        MEID0_TYPE,
        MEID1_TYPE,
        BUILD_MODEL_TYPE,
        BSSID_TYPE,
        IMSI_TYPE
    }

    /* JADX INFO: renamed from: com.qq.gdt.action.d.b$b, reason: collision with other inner class name */
    enum EnumC0551b {
        MEID,
        IMEI,
        ANDROID_ID,
        DEVICEID,
        BSSID,
        IMSI
    }

    public static synchronized com.qq.gdt.action.multioprocess.b.b a(com.qq.gdt.action.multioprocess.b.a aVar, a aVar2) {
        com.qq.gdt.action.multioprocess.b.b.j jVar;
        switch (AnonymousClass1.b[aVar2.ordinal()]) {
            case 1:
                com.qq.gdt.action.multioprocess.b.b.a aVarA = aVar.a();
                jVar = aVarA;
                if (aVarA == null) {
                    com.qq.gdt.action.multioprocess.b.b.a aVar3 = new com.qq.gdt.action.multioprocess.b.b.a();
                    aVar.a(aVar3);
                    jVar = aVar3;
                }
                break;
            case 2:
                com.qq.gdt.action.multioprocess.b.b.i iVarB = aVar.b();
                jVar = iVarB;
                if (iVarB == null) {
                    com.qq.gdt.action.multioprocess.b.b.i iVar = new com.qq.gdt.action.multioprocess.b.b.i();
                    aVar.a(iVar);
                    jVar = iVar;
                }
                break;
            case 3:
                com.qq.gdt.action.multioprocess.b.b.g gVarC = aVar.c();
                jVar = gVarC;
                if (gVarC == null) {
                    com.qq.gdt.action.multioprocess.b.b.g gVar = new com.qq.gdt.action.multioprocess.b.b.g();
                    aVar.a(gVar);
                    jVar = gVar;
                }
                break;
            case 4:
                com.qq.gdt.action.multioprocess.b.b.h hVarD = aVar.d();
                jVar = hVarD;
                if (hVarD == null) {
                    com.qq.gdt.action.multioprocess.b.b.h hVar = new com.qq.gdt.action.multioprocess.b.b.h();
                    aVar.a(hVar);
                    jVar = hVar;
                }
                break;
            case 5:
                com.qq.gdt.action.multioprocess.b.b.f fVarE = aVar.e();
                jVar = fVarE;
                if (fVarE == null) {
                    com.qq.gdt.action.multioprocess.b.b.f fVar = new com.qq.gdt.action.multioprocess.b.b.f();
                    aVar.a(fVar);
                    jVar = fVar;
                }
                break;
            case 6:
                com.qq.gdt.action.multioprocess.b.b.d dVarF = aVar.f();
                jVar = dVarF;
                if (dVarF == null) {
                    com.qq.gdt.action.multioprocess.b.b.d dVar = new com.qq.gdt.action.multioprocess.b.b.d();
                    aVar.a(dVar);
                    jVar = dVar;
                }
                break;
            case 7:
                com.qq.gdt.action.multioprocess.b.b.e eVarG = aVar.g();
                jVar = eVarG;
                if (eVarG == null) {
                    com.qq.gdt.action.multioprocess.b.b.e eVar = new com.qq.gdt.action.multioprocess.b.b.e();
                    aVar.a(eVar);
                    jVar = eVar;
                }
                break;
            case 8:
                com.qq.gdt.action.multioprocess.b.b.m mVarH = aVar.h();
                jVar = mVarH;
                if (mVarH == null) {
                    com.qq.gdt.action.multioprocess.b.b.m mVar = new com.qq.gdt.action.multioprocess.b.b.m();
                    aVar.a(mVar);
                    jVar = mVar;
                }
                break;
            case 9:
                com.qq.gdt.action.multioprocess.b.b.k kVarI = aVar.i();
                jVar = kVarI;
                if (kVarI == null) {
                    com.qq.gdt.action.multioprocess.b.b.k kVar = new com.qq.gdt.action.multioprocess.b.b.k();
                    aVar.a(kVar);
                    jVar = kVar;
                }
                break;
            case 10:
                com.qq.gdt.action.multioprocess.b.b.l lVarJ = aVar.j();
                jVar = lVarJ;
                if (lVarJ == null) {
                    com.qq.gdt.action.multioprocess.b.b.l lVar = new com.qq.gdt.action.multioprocess.b.b.l();
                    aVar.a(lVar);
                    jVar = lVar;
                }
                break;
            case 11:
                com.qq.gdt.action.multioprocess.b.b.c cVarK = aVar.k();
                jVar = cVarK;
                if (cVarK == null) {
                    com.qq.gdt.action.multioprocess.b.b.c cVar = new com.qq.gdt.action.multioprocess.b.b.c();
                    aVar.a(cVar);
                    jVar = cVar;
                }
                break;
            case 12:
                com.qq.gdt.action.multioprocess.b.b.C0552b c0552bL = aVar.l();
                jVar = c0552bL;
                if (c0552bL == null) {
                    com.qq.gdt.action.multioprocess.b.b.C0552b c0552b = new com.qq.gdt.action.multioprocess.b.b.C0552b();
                    aVar.a(c0552b);
                    jVar = c0552b;
                }
                break;
            case 13:
                com.qq.gdt.action.multioprocess.b.b.j jVarM = aVar.m();
                jVar = jVarM;
                if (jVarM == null) {
                    com.qq.gdt.action.multioprocess.b.b.j jVar2 = new com.qq.gdt.action.multioprocess.b.b.j();
                    aVar.a(jVar2);
                    jVar = jVar2;
                }
                break;
            default:
                jVar = null;
                break;
        }
        return jVar;
    }

    public static synchronized String a() {
        com.qq.gdt.action.multioprocess.b.a aVarB = b();
        com.qq.gdt.action.multioprocess.b.b bVarA = a(aVarB, a.BUILD_MODEL_TYPE);
        String strA = bVarA.a();
        if (TextUtils.isEmpty(strA) && !a(bVarA.b(), bVarA.c())) {
            bVarA.d();
            try {
                strA = Build.MODEL;
            } catch (Throwable th) {
                o.a("getBuildModule Throwable " + th, new Object[0]);
            }
            a(strA, bVarA, aVarB);
            return strA;
        }
        return strA;
    }

    public static synchronized String a(Context context) {
        if (!a(context, EnumC0551b.ANDROID_ID)) {
            return "";
        }
        com.qq.gdt.action.multioprocess.b.a aVarB = b();
        com.qq.gdt.action.multioprocess.b.b bVarA = a(aVarB, a.ANDROIDID_TYPE);
        String strA = bVarA.a();
        try {
            if (TextUtils.isEmpty(strA) && !a(bVarA.b(), bVarA.c())) {
                bVarA.d();
                try {
                    String string = Settings.System.getString(context.getApplicationContext().getContentResolver(), "android_id");
                    if (!TextUtils.isEmpty(string)) {
                        strA = string;
                    }
                } catch (Throwable th) {
                    o.a("getAndroidId throwable " + th, new Object[0]);
                }
                a(strA, bVarA, aVarB);
                return strA;
            }
            return strA;
        } catch (Throwable th2) {
            o.a("getAndroidId Throwable = " + th2, new Object[0]);
        }
    }

    public static synchronized String a(Context context, int i, boolean z) {
        return "";
    }

    public static synchronized String a(Context context, boolean z) {
        return "";
    }

    public static void a(String str, com.qq.gdt.action.multioprocess.b.b bVar, com.qq.gdt.action.multioprocess.b.a aVar) {
        bVar.a(str);
        com.qq.gdt.action.multioprocess.d.a().a(aVar);
    }

    public static boolean a(int i, int i2) {
        return i >= i2;
    }

    public static boolean a(Context context, EnumC0551b enumC0551b) {
        int i;
        try {
            switch (AnonymousClass1.f3032a[enumC0551b.ordinal()]) {
                case 1:
                    i = com.qq.gdt.action.b.a(context).i();
                    break;
                case 2:
                    i = com.qq.gdt.action.b.a(context).j();
                    break;
                case 3:
                    i = com.qq.gdt.action.b.a(context).k();
                    break;
                case 4:
                    i = com.qq.gdt.action.b.a(context).l();
                    break;
                case 5:
                    i = com.qq.gdt.action.b.a(context).g();
                    break;
                case 6:
                    i = com.qq.gdt.action.b.a(context).h();
                    break;
                default:
                    return false;
            }
            return i == 0;
        } catch (Throwable th) {
            o.a("!checkSwitchOpen error" + th, new Object[0]);
            return false;
        }
    }

    public static synchronized com.qq.gdt.action.multioprocess.b.a b() {
        com.qq.gdt.action.multioprocess.b.a aVarE;
        aVarE = com.qq.gdt.action.multioprocess.d.a().e();
        if (aVarE == null) {
            aVarE = new com.qq.gdt.action.multioprocess.b.a();
        }
        return aVarE;
    }

    public static synchronized String b(Context context, int i, boolean z) {
        return "";
    }

    public static synchronized String b(Context context, boolean z) {
        return "";
    }

    public static synchronized String c(Context context, int i, boolean z) {
        return "";
    }

    public static synchronized String c(Context context, boolean z) {
        return "";
    }
}
