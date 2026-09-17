package com.tencent.turingfd.sdk.ams.ad;

import android.content.Context;
import android.content.pm.PackageManager;
import android.os.Build;
import android.os.Process;
import android.text.TextUtils;
import android.util.Base64;
import android.util.SparseArray;
import com.byazt.bv.BaseConstants;
import com.bytedance.sdk.openadsdk.mediation.MediationConstant;
import com.tencent.bugly.BuglyStrategy;
import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.lang.reflect.Field;
import java.lang.reflect.Method;
import java.util.ArrayList;
import java.util.regex.Pattern;

/* JADX INFO: renamed from: com.tencent.turingfd.sdk.ams.ad.implements, reason: invalid class name */
/* JADX INFO: loaded from: classes4.dex */
public abstract class Cimplements {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final String f3936a = Cinstanceof.a(Cinstanceof.b);
    public static final String b = Cinstanceof.a(Cinstanceof.c);
    public static final String c = Cinstanceof.a(Cinstanceof.d);
    public static final String d = Cinstanceof.a(Cinstanceof.e);
    public static final String e = Cinstanceof.a(Cinstanceof.f);
    public static long f = 0;
    public static final String[] g = {"^/data/user/\\d+$", "^/data/data$"};

    /* JADX WARN: Code duplicated, block: B:14:0x004b  */
    public static String a(Context context, String str) {
        String str2;
        long length;
        StringBuilder sb = new StringBuilder();
        sb.append(str);
        sb.append("_");
        try {
            str2 = context.getPackageManager().getApplicationInfo(str, 0).sourceDir;
        } catch (PackageManager.NameNotFoundException unused) {
            str2 = "";
        }
        try {
            sb.append((String) Date.a(new File(str2)).get(0));
        } catch (Throwable unused2) {
            sb.append("");
        }
        sb.append("_");
        if (TextUtils.isEmpty(str2)) {
            length = -1;
        } else {
            File file = new File(str2);
            if (file.exists()) {
                length = file.length();
            } else {
                length = -1;
            }
        }
        sb.append(length);
        sb.append("_");
        sb.append(Process.myUid());
        return sb.toString();
    }

    public static String b(Context context) {
        Method method;
        try {
            Class<?> cls = Class.forName("android.os.UserManager");
            Field field = context.getClass().getField("USER_SERVICE");
            field.setAccessible(true);
            Object systemService = context.getSystemService((String) field.get(context));
            if (systemService == null || (method = cls.getMethod("getUserName", null)) == null) {
                return "";
            }
            method.setAccessible(true);
            return (String) method.invoke(systemService, null);
        } catch (Throwable unused) {
            return "";
        }
    }

    public static boolean a() {
        try {
            return 999 == Process.myUid() / BuglyStrategy.a.MAX_USERDATA_VALUE_LENGTH;
        } catch (Throwable unused) {
            return false;
        }
    }

    /* JADX WARN: Code duplicated, block: B:108:0x021d  */
    /* JADX WARN: Code duplicated, block: B:110:0x0227  */
    /* JADX WARN: Code duplicated, block: B:112:0x022d  */
    /* JADX WARN: Code duplicated, block: B:114:0x0235  */
    /* JADX WARN: Code duplicated, block: B:116:0x023d  */
    /* JADX WARN: Code duplicated, block: B:118:0x0243  */
    /* JADX WARN: Code duplicated, block: B:119:0x0249  */
    /* JADX WARN: Code duplicated, block: B:121:0x0251  */
    /* JADX WARN: Code duplicated, block: B:123:0x0257  */
    /* JADX WARN: Code duplicated, block: B:124:0x025d  */
    /* JADX WARN: Code duplicated, block: B:126:0x0265  */
    /* JADX WARN: Code duplicated, block: B:128:0x026b  */
    /* JADX WARN: Code duplicated, block: B:129:0x0271 A[Catch: all -> 0x02c0, TRY_ENTER, TRY_LEAVE, TryCatch #1 {all -> 0x02c0, blocks: (B:99:0x01ef, B:101:0x0205, B:129:0x0271), top: B:169:0x01e5 }] */
    /* JADX WARN: Code duplicated, block: B:131:0x029d A[Catch: all -> 0x0232, TRY_ENTER, TRY_LEAVE, TryCatch #3 {all -> 0x0232, blocks: (B:103:0x020b, B:105:0x0213, B:106:0x0217, B:131:0x029d), top: B:169:0x01e5 }] */
    /* JADX WARN: Code duplicated, block: B:133:0x02a3  */
    /* JADX WARN: Code duplicated, block: B:135:0x02ab  */
    /* JADX WARN: Code duplicated, block: B:138:0x02c0 A[PHI: r0 r6
  0x02c0: PHI (r0v37 ??) = (r0v36 ??), (r0v35 ??), (r0v35 ??), (r0v35 ??), (r0v35 ??), (r0v35 ??), (r0v35 ??), (r0v35 ??), (r0v35 ??) binds: [B:166:0x02c0, B:134:0x02a9, B:136:0x02b5, B:130:0x029b, B:122:0x0255, B:117:0x0241, B:111:0x022b, B:100:0x0203, B:102:0x0209] A[DONT_GENERATE, DONT_INLINE]
  0x02c0: PHI (r6v12 ??) = (r6v11 ??), (r6v10 ??), (r6v10 ??), (r6v10 ??), (r6v10 ??), (r6v10 ??), (r6v10 ??), (r6v10 ??), (r6v10 ??) binds: [B:166:0x02c0, B:134:0x02a9, B:136:0x02b5, B:130:0x029b, B:122:0x0255, B:117:0x0241, B:111:0x022b, B:100:0x0203, B:102:0x0209] A[DONT_GENERATE, DONT_INLINE]] */
    /* JADX WARN: Code duplicated, block: B:141:0x02d5  */
    /* JADX WARN: Code duplicated, block: B:145:0x0314  */
    /* JADX WARN: Code duplicated, block: B:150:0x031d  */
    /* JADX WARN: Code duplicated, block: B:151:0x0325  */
    /* JADX WARN: Code duplicated, block: B:154:0x0336  */
    /* JADX WARN: Code duplicated, block: B:156:0x035b  */
    /* JADX WARN: Code duplicated, block: B:159:0x0397 A[LOOP:0: B:158:0x0395->B:159:0x0397, LOOP_END] */
    /* JADX WARN: Code duplicated, block: B:88:0x0199  */
    /* JADX WARN: Code duplicated, block: B:90:0x019c  */
    /* JADX WARN: Code duplicated, block: B:91:0x01a7  */
    /* JADX WARN: Code duplicated, block: B:94:0x01b7  */
    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r0v35, types: [java.lang.StringBuilder] */
    /* JADX WARN: Type inference failed for: r0v36 */
    /* JADX WARN: Type inference failed for: r0v37 */
    /* JADX WARN: Type inference failed for: r0v41, types: [int] */
    /* JADX WARN: Type inference failed for: r6v10, types: [int] */
    /* JADX WARN: Type inference failed for: r6v11 */
    /* JADX WARN: Type inference failed for: r6v12 */
    /* JADX WARN: Type inference failed for: r6v14, types: [boolean] */
    /* JADX WARN: Unsupported multi-entry loop pattern (BACK_EDGE: B:138:0x02c0 -> B:139:0x02c1). Please report as a decompilation issue!!! */
    public static String a(Context context) {
        File parentFile;
        boolean z;
        Ctransient ctransient;
        int iA;
        FileReader fileReader;
        BufferedReader bufferedReader;
        String str;
        String packageName;
        boolean z2;
        Ctransient ctransient2;
        int iIndexOf;
        ?? A;
        ?? sb;
        String strA;
        boolean z3;
        int i;
        StringBuilder sb2;
        Ctransient ctransient3;
        int i2;
        Ctransient ctransient4;
        int i3;
        int iA2;
        int size;
        int i4;
        String str2;
        String str3;
        int iMyUid;
        StringBuilder sb3 = new StringBuilder();
        long jCurrentTimeMillis = System.currentTimeMillis();
        ArrayList arrayList = new ArrayList();
        File parentFile2 = context.getApplicationContext().getFilesDir().getParentFile();
        if (parentFile2 == null || (parentFile = parentFile2.getParentFile()) == null) {
            ctransient = new Ctransient("", false);
        } else {
            String[] strArr = g;
            int length = strArr.length;
            int i5 = 0;
            while (true) {
                if (i5 >= length) {
                    z = true;
                    break;
                }
                if (Pattern.compile(strArr[i5]).matcher(parentFile.getAbsolutePath()).find()) {
                    z = false;
                    break;
                }
                i5++;
            }
            String absolutePath = parentFile2.getAbsolutePath();
            String packageName2 = context.getPackageName();
            String[] strArrSplit = absolutePath.split("/", 6);
            if (absolutePath.startsWith("/data/data/") && strArrSplit.length >= 4 && !TextUtils.isEmpty(strArrSplit[3])) {
                packageName2 = strArrSplit[3];
            } else if (absolutePath.startsWith("/data/user/") && strArrSplit.length >= 5 && !TextUtils.isEmpty(strArrSplit[4])) {
                packageName2 = strArrSplit[4];
            }
            if (z && !packageName2.equals(context.getPackageName())) {
                ctransient = new Ctransient(a(context, packageName2), z);
            } else {
                ctransient = new Ctransient("", z);
            }
        }
        if (!ctransient.f3966a || TextUtils.isEmpty(ctransient.b)) {
            iA = 0;
        } else {
            iA = Cthrow.a(0, 0, true);
            Cinterface cinterface = new Cinterface();
            cinterface.f3939a = f3936a + c;
            cinterface.b = ctransient.b;
            arrayList.add(cinterface);
        }
        Context applicationContext = context.getApplicationContext();
        if (applicationContext == null) {
            ctransient2 = new Ctransient("", false);
        } else {
            try {
                fileReader = new FileReader("/proc/self/maps");
                try {
                    bufferedReader = new BufferedReader(fileReader);
                    while (true) {
                        try {
                            String line = bufferedReader.readLine();
                            if (line == null) {
                                str = null;
                                break;
                            }
                            int iIndexOf2 = line.indexOf(47);
                            if (iIndexOf2 != -1) {
                                String strTrim = line.substring(iIndexOf2).trim();
                                if (strTrim.startsWith("/data/app/") && strTrim.endsWith("/base.odex")) {
                                    String[] strArrSplit2 = strTrim.split("/");
                                    if (strArrSplit2.length >= 7) {
                                        str = strArrSplit2[3];
                                        break;
                                    }
                                }
                            }
                        } catch (Throwable th) {
                            th = th;
                            try {
                                th.printStackTrace();
                                GalacticCore.a(fileReader);
                                GalacticCore.a(bufferedReader);
                                str = null;
                            } catch (Throwable th2) {
                                GalacticCore.a(fileReader);
                                GalacticCore.a(bufferedReader);
                                throw th2;
                            }
                        }
                    }
                    GalacticCore.a(fileReader);
                    GalacticCore.a(bufferedReader);
                } catch (Throwable th3) {
                    th = th3;
                    bufferedReader = null;
                    th.printStackTrace();
                    GalacticCore.a(fileReader);
                    GalacticCore.a(bufferedReader);
                    str = null;
                    packageName = applicationContext.getPackageName();
                    if (TextUtils.isEmpty(str)) {
                        z2 = false;
                    } else {
                        z2 = false;
                    }
                    if (z2) {
                        ctransient2 = new Ctransient(a(context, packageName), z2);
                    } else {
                        ctransient2 = new Ctransient("", z2);
                    }
                    A = Cthrow.a(iA, 1, ctransient2.f3966a);
                    if (ctransient2.f3966a) {
                        Cinterface cinterface2 = new Cinterface();
                        cinterface2.f3939a = f3936a + d;
                        cinterface2.b = ctransient2.b;
                        arrayList.add(cinterface2);
                    }
                    sb = new StringBuilder();
                    strA = Cinstanceof.a(Cinstanceof.c1);
                    try {
                        if (strA == null) {
                            str3 = Build.BRAND;
                            if (MediationConstant.ADN_XIAOMI.equalsIgnoreCase(str3)) {
                                if (a()) {
                                    sb.append("XiaoMi");
                                    z3 = true;
                                    sb2 = sb;
                                    i = A;
                                } else {
                                    z3 = false;
                                    sb2 = sb;
                                    i = A;
                                }
                            } else if ("redmi".equalsIgnoreCase(str3)) {
                                if (a()) {
                                    sb.append("Redmi");
                                    z3 = true;
                                    sb2 = sb;
                                    i = A;
                                } else {
                                    z3 = false;
                                    sb2 = sb;
                                    i = A;
                                }
                            } else if ("oppo".equalsIgnoreCase(str3)) {
                                if (a()) {
                                    sb.append(BaseConstants.ROM_OPPO_UPPER_CONSTANT);
                                    z3 = true;
                                    sb2 = sb;
                                    i = A;
                                } else {
                                    z3 = false;
                                    sb2 = sb;
                                    i = A;
                                }
                            } else if ("vivo".equalsIgnoreCase(str3)) {
                                if (a()) {
                                    sb.append("VIVO_A");
                                } else if (new String(CanisMinor.a("/proc/self/mountinfo")).contains(context.getApplicationContext().getPackageName() + "_cloned")) {
                                    sb.append("VIVO_B");
                                } else {
                                    z3 = false;
                                    sb2 = sb;
                                    i = A;
                                }
                                z3 = true;
                                sb2 = sb;
                                i = A;
                            } else {
                                if ("samsung".equalsIgnoreCase(str3)) {
                                }
                                z3 = false;
                                sb2 = sb;
                                i = A;
                            }
                        } else {
                            str3 = Build.BRAND;
                            if (MediationConstant.ADN_XIAOMI.equalsIgnoreCase(str3)) {
                                if (a()) {
                                    sb.append("XiaoMi");
                                    z3 = true;
                                    sb2 = sb;
                                    i = A;
                                } else {
                                    z3 = false;
                                    sb2 = sb;
                                    i = A;
                                }
                            } else if ("redmi".equalsIgnoreCase(str3)) {
                                if (a()) {
                                    sb.append("Redmi");
                                    z3 = true;
                                    sb2 = sb;
                                    i = A;
                                } else {
                                    z3 = false;
                                    sb2 = sb;
                                    i = A;
                                }
                            } else if ("oppo".equalsIgnoreCase(str3)) {
                                if (a()) {
                                    sb.append(BaseConstants.ROM_OPPO_UPPER_CONSTANT);
                                    z3 = true;
                                    sb2 = sb;
                                    i = A;
                                } else {
                                    z3 = false;
                                    sb2 = sb;
                                    i = A;
                                }
                            } else if ("vivo".equalsIgnoreCase(str3)) {
                                if (a()) {
                                    sb.append("VIVO_A");
                                } else if (new String(CanisMinor.a("/proc/self/mountinfo")).contains(context.getApplicationContext().getPackageName() + "_cloned")) {
                                    sb.append("VIVO_B");
                                } else {
                                    z3 = false;
                                    sb2 = sb;
                                    i = A;
                                }
                                z3 = true;
                                sb2 = sb;
                                i = A;
                            } else {
                                if ("samsung".equalsIgnoreCase(str3)) {
                                }
                                z3 = false;
                                sb2 = sb;
                                i = A;
                            }
                        }
                    } catch (Throwable unused) {
                    }
                    ctransient3 = new Ctransient(sb2.toString(), z3);
                    sb = Cthrow.a(i, 2, ctransient3.f3966a);
                    A = ctransient3.f3966a;
                    if (A != 0) {
                        Cinterface cinterface3 = new Cinterface();
                        cinterface3.f3939a = f3936a + e;
                        cinterface3.b = ctransient3.b;
                        arrayList.add(cinterface3);
                    }
                    new SparseArray();
                    str2 = (String) Cantaloupe.a(TNative$aa.d209308_501191CEF186C29F(new SparseArray(), context, 206), 206, String.class);
                    Tangor tangor = Teazle.f3900a;
                    if (str2 == null) {
                        str2 = "";
                    }
                    i2 = Integer.parseInt(str2);
                    if (i2 > 0) {
                        ctransient4 = new Ctransient("", true);
                        i3 = 0;
                    } else {
                        i3 = 0;
                        ctransient4 = new Ctransient("", false);
                    }
                    iA2 = Cthrow.a(sb, 4, ctransient4.f3966a);
                    if (ctransient4.f3966a) {
                        Cinterface cinterface4 = new Cinterface();
                        cinterface4.f3939a = f3936a + "dual_e";
                        cinterface4.b = ctransient3.b;
                        arrayList.add(cinterface4);
                    }
                    if (iA2 > 0) {
                        Cinterface cinterface5 = new Cinterface();
                        cinterface5.f3939a = f3936a + b;
                        cinterface5.b = "" + iA2;
                        arrayList.add(cinterface5);
                    }
                    f = System.currentTimeMillis() - jCurrentTimeMillis;
                    size = arrayList.size();
                    i4 = i3;
                    while (i4 < size) {
                        Object obj = arrayList.get(i4);
                        i4++;
                        Cinterface cinterface6 = (Cinterface) obj;
                        sb3.append(cinterface6.f3939a);
                        sb3.append(":");
                        sb3.append(cinterface6.b);
                        sb3.append(",");
                    }
                    return sb3.toString();
                }
            } catch (Throwable th4) {
                th = th4;
                fileReader = null;
            }
            packageName = applicationContext.getPackageName();
            if (TextUtils.isEmpty(str) || (iIndexOf = str.indexOf("-")) == -1) {
                z2 = false;
            } else {
                String strSubstring = str.substring(0, iIndexOf);
                if (TextUtils.isEmpty(strSubstring)) {
                    z2 = false;
                } else {
                    File file = new File("/data/data/" + strSubstring);
                    if (!file.exists() || !file.canWrite()) {
                        strSubstring = packageName;
                    }
                    z2 = !TextUtils.equals(packageName, strSubstring);
                    packageName = strSubstring;
                }
            }
            if (z2) {
                ctransient2 = new Ctransient(a(context, packageName), z2);
            } else {
                ctransient2 = new Ctransient("", z2);
            }
        }
        A = Cthrow.a(iA, 1, ctransient2.f3966a);
        if (ctransient2.f3966a) {
            Cinterface cinterface7 = new Cinterface();
            cinterface7.f3939a = f3936a + d;
            cinterface7.b = ctransient2.b;
            arrayList.add(cinterface7);
        }
        sb = new StringBuilder();
        strA = Cinstanceof.a(Cinstanceof.c1);
        try {
            if (strA == null && strA.equalsIgnoreCase(Build.BRAND)) {
                String strB = b(context);
                String str4 = new String(Base64.decode("5YiG6Lqr5bqU55So", 0));
                if (TextUtils.isEmpty(strB) || !str4.equals(strB)) {
                    z3 = false;
                    sb2 = sb;
                    i = A;
                } else {
                    String strA2 = Cinstanceof.a(Cinstanceof.d1);
                    if (strA2 != null) {
                        sb.append(strA2);
                    } else {
                        sb.append("H");
                    }
                    z3 = true;
                    sb2 = sb;
                    i = A;
                }
            } else {
                str3 = Build.BRAND;
                if (MediationConstant.ADN_XIAOMI.equalsIgnoreCase(str3)) {
                    if (a()) {
                        sb.append("XiaoMi");
                        z3 = true;
                        sb2 = sb;
                        i = A;
                    } else {
                        z3 = false;
                        sb2 = sb;
                        i = A;
                    }
                } else if ("redmi".equalsIgnoreCase(str3)) {
                    if (a()) {
                        sb.append("Redmi");
                        z3 = true;
                        sb2 = sb;
                        i = A;
                    } else {
                        z3 = false;
                        sb2 = sb;
                        i = A;
                    }
                } else if ("oppo".equalsIgnoreCase(str3)) {
                    if (a()) {
                        sb.append(BaseConstants.ROM_OPPO_UPPER_CONSTANT);
                        z3 = true;
                        sb2 = sb;
                        i = A;
                    } else {
                        z3 = false;
                        sb2 = sb;
                        i = A;
                    }
                } else if ("vivo".equalsIgnoreCase(str3)) {
                    if (a()) {
                        sb.append("VIVO_A");
                    } else if (new String(CanisMinor.a("/proc/self/mountinfo")).contains(context.getApplicationContext().getPackageName() + "_cloned")) {
                        sb.append("VIVO_B");
                    } else {
                        z3 = false;
                        sb2 = sb;
                        i = A;
                    }
                    z3 = true;
                    sb2 = sb;
                    i = A;
                } else if ("samsung".equalsIgnoreCase(str3) || (iMyUid = Process.myUid() / BuglyStrategy.a.MAX_USERDATA_VALUE_LENGTH) <= 50) {
                    z3 = false;
                    sb2 = sb;
                    i = A;
                } else {
                    sb.append("samsung").append(iMyUid);
                    z3 = true;
                    sb2 = sb;
                    i = A;
                }
            }
        } catch (Throwable unused2) {
        }
        ctransient3 = new Ctransient(sb2.toString(), z3);
        sb = Cthrow.a(i, 2, ctransient3.f3966a);
        A = ctransient3.f3966a;
        if (A != 0) {
            Cinterface cinterface8 = new Cinterface();
            cinterface8.f3939a = f3936a + e;
            cinterface8.b = ctransient3.b;
            arrayList.add(cinterface8);
        }
        new SparseArray();
        try {
            str2 = (String) Cantaloupe.a(TNative$aa.d209308_501191CEF186C29F(new SparseArray(), context, 206), 206, String.class);
            Tangor tangor2 = Teazle.f3900a;
            if (str2 == null) {
                str2 = "";
            }
            i2 = Integer.parseInt(str2);
        } catch (Throwable unused3) {
            i2 = 0;
        }
        if (i2 > 0) {
            ctransient4 = new Ctransient("", true);
            i3 = 0;
        } else {
            i3 = 0;
            ctransient4 = new Ctransient("", false);
        }
        iA2 = Cthrow.a(sb, 4, ctransient4.f3966a);
        if (ctransient4.f3966a) {
            Cinterface cinterface9 = new Cinterface();
            cinterface9.f3939a = f3936a + "dual_e";
            cinterface9.b = ctransient3.b;
            arrayList.add(cinterface9);
        }
        if (iA2 > 0) {
            Cinterface cinterface10 = new Cinterface();
            cinterface10.f3939a = f3936a + b;
            cinterface10.b = "" + iA2;
            arrayList.add(cinterface10);
        }
        f = System.currentTimeMillis() - jCurrentTimeMillis;
        size = arrayList.size();
        i4 = i3;
        while (i4 < size) {
            Object obj2 = arrayList.get(i4);
            i4++;
            Cinterface cinterface11 = (Cinterface) obj2;
            sb3.append(cinterface11.f3939a);
            sb3.append(":");
            sb3.append(cinterface11.b);
            sb3.append(",");
        }
        return sb3.toString();
    }
}
