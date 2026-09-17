package com.tencent.bugly.proguard;

import android.app.ActivityManager;
import android.content.Context;
import android.text.TextUtils;
import com.tencent.bugly.crashreport.crash.CrashDetailBean;
import com.tencent.bugly.crashreport.crash.jni.NativeCrashHandler;
import com.tencent.bugly.crashreport.crash.jni.NativeExceptionHandler;
import java.util.HashMap;
import java.util.Map;

/* JADX INFO: compiled from: BUGLY */
/* JADX INFO: loaded from: classes4.dex */
public final class bd implements NativeExceptionHandler {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final Context f3775a;
    private final as b;
    private final aa c;
    private final ac d;

    public bd(Context context, aa aaVar, as asVar, ac acVar) {
        this.f3775a = context;
        this.b = asVar;
        this.c = aaVar;
        this.d = acVar;
    }

    @Override // com.tencent.bugly.crashreport.crash.jni.NativeExceptionHandler
    public final CrashDetailBean packageCrashDatas(String str, String str2, long j, String str3, String str4, String str5, String str6, String str7, String str8, String str9, String str10, String str11, byte[] bArr, Map<String, String> map, boolean z, boolean z2) {
        int i;
        String str12;
        int iIndexOf;
        boolean zI = at.a().i();
        if (zI) {
            al.e("This Crash Caused By ANR , PLS To Fix ANR , This Trace May Be Not Useful!", new Object[0]);
        }
        CrashDetailBean crashDetailBean = new CrashDetailBean();
        crashDetailBean.b = 1;
        crashDetailBean.e = this.c.g();
        crashDetailBean.f = this.c.o;
        crashDetailBean.g = this.c.q();
        crashDetailBean.m = this.c.f();
        crashDetailBean.n = str3;
        crashDetailBean.o = zI ? " This Crash Caused By ANR , PLS To Fix ANR , This Trace May Be Not Useful![Bugly]" : "";
        crashDetailBean.p = str4;
        crashDetailBean.q = str5 != null ? str5 : "";
        crashDetailBean.r = j;
        crashDetailBean.u = ap.c(crashDetailBean.q.getBytes());
        crashDetailBean.A = str;
        crashDetailBean.B = str2;
        crashDetailBean.L = this.c.s();
        crashDetailBean.h = this.c.p();
        crashDetailBean.i = this.c.A();
        crashDetailBean.v = str8;
        String dumpFilePath = NativeCrashHandler.getInstance() != null ? NativeCrashHandler.getDumpFilePath() : null;
        String strA = be.a(dumpFilePath, str8);
        if (!ap.b(strA)) {
            crashDetailBean.Z = strA;
        }
        crashDetailBean.aa = be.b(dumpFilePath);
        crashDetailBean.w = be.a(str9, at.f, at.k, at.p);
        crashDetailBean.x = be.a(str10, at.f, null, true);
        crashDetailBean.N = str7;
        crashDetailBean.O = str6;
        crashDetailBean.P = str11;
        crashDetailBean.F = this.c.k();
        crashDetailBean.G = this.c.j();
        crashDetailBean.H = this.c.l();
        crashDetailBean.I = ab.b(this.f3775a);
        crashDetailBean.J = ab.g();
        crashDetailBean.K = ab.h();
        if (z) {
            crashDetailBean.C = ab.j();
            crashDetailBean.D = ab.f();
            crashDetailBean.E = ab.l();
            crashDetailBean.y = ao.a();
            crashDetailBean.Q = this.c.f3726a;
            crashDetailBean.R = this.c.a();
            crashDetailBean.z = ap.a(this.c.Q, at.h);
            int iIndexOf2 = crashDetailBean.q.indexOf("java:\n");
            if (iIndexOf2 > 0 && (i = iIndexOf2 + 6) < crashDetailBean.q.length()) {
                String str13 = crashDetailBean.q;
                String strSubstring = str13.substring(i, str13.length() - 1);
                if (strSubstring.length() > 0 && crashDetailBean.z.containsKey(crashDetailBean.B) && (iIndexOf = (str12 = crashDetailBean.z.get(crashDetailBean.B)).indexOf(strSubstring)) > 0) {
                    String strSubstring2 = str12.substring(iIndexOf);
                    crashDetailBean.z.put(crashDetailBean.B, strSubstring2);
                    crashDetailBean.q = crashDetailBean.q.substring(0, i);
                    crashDetailBean.q += strSubstring2;
                }
            }
            if (str == null) {
                crashDetailBean.A = this.c.d;
            }
            crashDetailBean.U = this.c.z();
            crashDetailBean.V = this.c.x;
            crashDetailBean.W = this.c.t();
            crashDetailBean.X = this.c.y();
        } else {
            crashDetailBean.C = -1L;
            crashDetailBean.D = -1L;
            crashDetailBean.E = -1L;
            if (crashDetailBean.w == null) {
                crashDetailBean.w = "This crash occurred at last process! Log is miss, when get an terrible ABRT Native Exception etc.";
            }
            crashDetailBean.Q = -1L;
            crashDetailBean.U = -1;
            crashDetailBean.V = -1;
            crashDetailBean.W = map;
            crashDetailBean.X = this.c.y();
            crashDetailBean.z = null;
            if (str == null) {
                crashDetailBean.A = "unknown(record)";
            }
            if (bArr != null) {
                crashDetailBean.y = bArr;
            }
        }
        return crashDetailBean;
    }

    @Override // com.tencent.bugly.crashreport.crash.jni.NativeExceptionHandler
    public final boolean getAndUpdateAnrState() {
        if (ay.a() == null) {
            return false;
        }
        ay ayVarA = ay.a();
        if (ayVarA.f3766a.get()) {
            al.c("anr is processing, return", new Object[0]);
            return false;
        }
        ActivityManager activityManager = ayVarA.b;
        if (!((z.a(activityManager) || az.a(activityManager, 0L) == null) ? false : true)) {
            al.c("proc is not in anr, wait next check", new Object[0]);
            return false;
        }
        if (ayVarA.a(System.currentTimeMillis())) {
            return false;
        }
        return ayVarA.a(true);
    }

    @Override // com.tencent.bugly.crashreport.crash.jni.NativeExceptionHandler
    public final void handleNativeException(int i, int i2, long j, long j2, String str, String str2, String str3, String str4, int i3, String str5, int i4, int i5, int i6, String str6, String str7) {
        al.a("Native Crash Happen v1", new Object[0]);
        handleNativeException2(i, i2, j, j2, str, str2, str3, str4, i3, str5, i4, i5, i6, str6, str7, null);
    }

    /* JADX WARN: Code duplicated, block: B:44:0x0190 A[PHI: r4
  0x0190: PHI (r4v14 java.lang.String) = (r4v13 java.lang.String), (r4v18 java.lang.String) binds: [B:37:0x0162, B:41:0x0172] A[DONT_GENERATE, DONT_INLINE]] */
    /* JADX WARN: Code duplicated, block: B:77:0x024a  */
    /* JADX WARN: Code duplicated, block: B:82:? A[RETURN, SYNTHETIC] */
    @Override // com.tencent.bugly.crashreport.crash.jni.NativeExceptionHandler
    public final void handleNativeException2(int i, int i2, long j, long j2, String str, String str2, String str3, String str4, int i3, String str5, int i4, int i5, int i6, String str6, String str7, String[] strArr) {
        String str8;
        String str9;
        boolean z;
        String str10;
        String str11;
        al.a("Native Crash Happen v2", new Object[0]);
        if (i3 > 0) {
            try {
                str8 = str5;
                str9 = str + "(" + str8 + ")";
            } catch (Throwable th) {
                th = th;
                if (al.a(th)) {
                }
                th.printStackTrace();
            }
        } else {
            str8 = str5;
            str9 = str;
        }
        String strA = be.a(str3);
        Map<String, String> mapA = a(strArr);
        String str12 = mapA.get("HasPendingException");
        if (str12 == null || !str12.equals("true")) {
            z = false;
        } else {
            al.a("Native crash happened with a Java pending exception.", new Object[0]);
            z = true;
        }
        aa aaVar = this.c;
        String str13 = mapA.get("ExceptionProcessName");
        if (str13 == null || str13.length() == 0) {
            str13 = aaVar.d;
        } else {
            al.c("Name of crash process: %s", str13);
        }
        String str14 = str13;
        String str15 = mapA.get("ExceptionThreadName");
        al.c("crash thread name:%s tid:%s", str15, Integer.valueOf(i2));
        if (TextUtils.isEmpty(str15)) {
            str10 = Thread.currentThread().getName() + "(" + i2 + ")";
        } else {
            str10 = str15 + "(" + i2 + ")";
        }
        long j3 = (j2 / 1000) + (j * 1000);
        String str16 = mapA.get("SysLogPath");
        String str17 = mapA.get("JniLogPath");
        if (!this.d.b()) {
            al.d("no remote but still store!", new Object[0]);
        }
        if (!this.d.c().f && this.d.b()) {
            al.e("crash report was closed by remote , will not upload to Bugly , print local for helpful!", new Object[0]);
            as.a("NATIVE_CRASH", ap.a(), str14, str10, str9 + "\n" + str2 + "\n" + strA, null);
            ap.c(str4);
            return;
        }
        String str18 = i3 > 0 ? "KERNEL" : str8;
        String strA2 = "UNKNOWN";
        if (i3 > 0) {
            str11 = strA2;
        } else {
            strA2 = i4 > 0 ? z.a(i4) : "UNKNOWN";
            if (strA2.equals(String.valueOf(i4))) {
                str11 = strA2;
            } else {
                str11 = strA2 + "(" + i4 + ")";
            }
        }
        String str19 = str9;
        try {
            CrashDetailBean crashDetailBeanPackageCrashDatas = packageCrashDatas(str14, str10, j3, str9, str2, strA, str18, str11, str4, str16, str17, str7, null, null, true, z);
            if (crashDetailBeanPackageCrashDatas == null) {
                al.e("pkg crash datas fail!", new Object[0]);
                return;
            }
            as.a("NATIVE_CRASH", ap.a(), str14, str10, str19 + "\n" + str2 + "\n" + strA, crashDetailBeanPackageCrashDatas);
            try {
                as asVar = this.b;
                if (asVar == null) {
                    al.d("crashHandler is null. Won't upload native crash.", new Object[0]);
                    return;
                }
                boolean z2 = !asVar.a(crashDetailBeanPackageCrashDatas, true);
                be.a(true, NativeCrashHandler.getInstance() != null ? NativeCrashHandler.getDumpFilePath() : null);
                if (z2) {
                    this.b.b(crashDetailBeanPackageCrashDatas, true);
                }
                this.b.a(crashDetailBeanPackageCrashDatas);
                at.a().t.b();
            } catch (Throwable th2) {
                th = th2;
                if (al.a(th)) {
                    th.printStackTrace();
                }
            }
        } catch (Throwable th3) {
            th = th3;
        }
    }

    private static Map<String, String> a(String[] strArr) {
        HashMap map = new HashMap(strArr == null ? 1 : strArr.length);
        if (strArr != null) {
            for (int i = 0; i < strArr.length; i++) {
                String str = strArr[i];
                if (str != null) {
                    al.a("Extra message[%d]: %s", Integer.valueOf(i), str);
                    String[] strArrSplit = str.split("=");
                    if (strArrSplit.length == 2) {
                        map.put(strArrSplit[0], strArrSplit[1]);
                    } else {
                        al.d("bad extraMsg %s", str);
                    }
                }
            }
        } else {
            al.c("not found extraMsg", new Object[0]);
        }
        return map;
    }
}
