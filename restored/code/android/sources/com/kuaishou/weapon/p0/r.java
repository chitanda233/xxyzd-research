package com.kuaishou.weapon.p0;

import android.app.Application;
import android.content.Context;
import android.content.pm.PackageInfo;
import android.os.Build;
import android.text.TextUtils;
import android.util.Pair;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.util.ArrayList;
import java.util.HashSet;
import java.util.List;
import java.util.Map;
import java.util.Random;
import java.util.concurrent.ConcurrentHashMap;
import java.util.zip.ZipEntry;
import java.util.zip.ZipInputStream;

/* JADX INFO: loaded from: classes3.dex */
public class r {
    private static r c;
    private static Application d;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public boolean f2730a;
    private String e;
    private static Random f = new Random();
    private static Map<String, s> g = new ConcurrentHashMap();
    private static Map<String, s> h = new ConcurrentHashMap();
    public static List<Integer> b = new ArrayList();

    public static r a(Context context, boolean z) {
        try {
            if (c == null) {
                d = (Application) context.getApplicationContext();
                c = new r();
            }
        } catch (Throwable unused) {
        }
        return c;
    }

    private r() {
    }

    public static r a() {
        return c;
    }

    public boolean a(s sVar, boolean z) {
        this.f2730a = z;
        this.e = sVar.d;
        return a(sVar);
    }

    private synchronized boolean a(s sVar) {
        boolean z;
        if (sVar != null) {
            if (!TextUtils.isEmpty(sVar.e)) {
                s sVar2 = g.get(sVar.e);
                if (sVar2 != null) {
                    if (sVar2.d.equals(sVar.d)) {
                        return true;
                    }
                    a(sVar2.e);
                }
                try {
                    sVar.f = d;
                    if (sVar.p == 1) {
                        try {
                            try {
                                if (TextUtils.isEmpty(sVar.c) || TextUtils.isEmpty(sVar.e)) {
                                    throw new RuntimeException("apkPackageName or apkPkgPath is null");
                                }
                                sVar.m = d.getFilesDir().getCanonicalPath() + bg.j + sVar.f2731a;
                                String str = sVar.m + "/dex";
                                String str2 = sVar.m + "/lib/" + this.e;
                                dl.c(sVar.m + "/lib");
                                String str3 = str2 + "/" + f.nextInt();
                                e(str);
                                dl.a(str, Boolean.FALSE);
                                e(str3);
                                a(sVar, str3, str, false);
                                h.put(sVar.c, sVar);
                                g.put(sVar.e, sVar);
                            } catch (Throwable unused) {
                                a(sVar.e);
                                z = true;
                            }
                        } catch (Throwable unused2) {
                            return false;
                        }
                    }
                    z = false;
                    if (sVar.p != 1 || z) {
                        PackageInfo packageArchiveInfo = sVar.r;
                        if (packageArchiveInfo == null || TextUtils.isEmpty(packageArchiveInfo.packageName) || TextUtils.isEmpty(packageArchiveInfo.versionName)) {
                            packageArchiveInfo = d.getPackageManager().getPackageArchiveInfo(sVar.e, 1);
                        }
                        if (TextUtils.isEmpty(packageArchiveInfo.packageName) || !packageArchiveInfo.packageName.startsWith("com.kuaishou.weapon")) {
                            throw new Exception("weapon package name check failed");
                        }
                        if (sVar.p != 1 && sVar.b != 1 && !((Boolean) a(sVar.j, sVar.e).first).booleanValue()) {
                            return false;
                        }
                        sVar.c = packageArchiveInfo.packageName;
                        sVar.o = packageArchiveInfo.applicationInfo.className;
                        sVar.d = packageArchiveInfo.versionName;
                        sVar.l = packageArchiveInfo.activities;
                        sVar.q = packageArchiveInfo.applicationInfo.theme;
                        sVar.m = d.getFilesDir().getCanonicalPath() + bg.j + sVar.f2731a;
                        String str4 = sVar.m + "/dex";
                        String str5 = sVar.m + "/lib/" + this.e;
                        dl.c(sVar.m + "/lib");
                        String str6 = str5 + "/" + f.nextInt();
                        e(str4);
                        dl.a(str4, Boolean.FALSE);
                        e(str6);
                        a(sVar, str6, str4, true);
                        h.put(sVar.c, sVar);
                        g.put(sVar.e, sVar);
                        b.add(Integer.valueOf(sVar.f2731a));
                    }
                    return true;
                } catch (Throwable unused3) {
                    a(sVar.e);
                    return false;
                }
            }
        }
        return false;
    }

    private Pair<Boolean, String> a(String str, String str2) {
        if (TextUtils.isEmpty(str) || TextUtils.isEmpty(str2)) {
            return new Pair<>(Boolean.FALSE, "");
        }
        File file = new File(str2);
        if (!dl.a(file)) {
            return new Pair<>(Boolean.FALSE, "");
        }
        String strA = f.a(file);
        if (TextUtils.isEmpty(strA)) {
            return new Pair<>(Boolean.FALSE, "");
        }
        if (!strA.equalsIgnoreCase(str)) {
            return new Pair<>(Boolean.FALSE, strA);
        }
        return new Pair<>(Boolean.TRUE, "");
    }

    public boolean a(String str) {
        s sVar = g.get(str);
        if (sVar == null) {
            return false;
        }
        g.remove(str);
        h.remove(sVar.c);
        dl.c(sVar.m);
        Application application = d;
        if (application == null) {
            return true;
        }
        dl.c(application.getFileStreamPath(sVar.c).getAbsolutePath());
        return true;
    }

    public boolean b(String str) {
        s sVar = h.get(str);
        if (sVar == null) {
            return false;
        }
        g.remove(sVar.e);
        h.remove(str);
        dl.c(sVar.m);
        Application application = d;
        if (application == null) {
            return true;
        }
        dl.c(application.getFileStreamPath(sVar.c).getAbsolutePath());
        return true;
    }

    public s c(String str) {
        try {
            return g.get(str);
        } catch (Throwable unused) {
            return null;
        }
    }

    public s d(String str) {
        try {
            return h.get(str);
        } catch (Throwable unused) {
            return null;
        }
    }

    public static boolean e(String str) {
        try {
            File file = new File(str);
            if (file.exists() && !file.isDirectory()) {
                file.delete();
            }
            if (file.exists()) {
                return true;
            }
            file.mkdirs();
            return true;
        } catch (Throwable unused) {
            return false;
        }
    }

    public Map<String, s> b() {
        return h;
    }

    /* JADX WARN: Code duplicated, block: B:12:0x0031  */
    /* JADX WARN: Code duplicated, block: B:153:0x02c7  */
    /* JADX WARN: Code duplicated, block: B:155:0x02cc  */
    /* JADX WARN: Code duplicated, block: B:163:0x02e5  */
    /* JADX WARN: Code duplicated, block: B:165:0x02ea  */
    /* JADX WARN: Code duplicated, block: B:173:0x0303  */
    /* JADX WARN: Code duplicated, block: B:175:0x0308  */
    /* JADX WARN: Code duplicated, block: B:177:0x030d A[PHI: r11 r17 r18 r21 r22
  0x030d: PHI (r11v11 ??) = (r11v8 ??), (r11v9 ??), (r11v12 ??), (r11v16 ??) binds: [B:156:0x02cf, B:176:0x030b, B:166:0x02ed, B:124:0x0242] A[DONT_GENERATE, DONT_INLINE]
  0x030d: PHI (r17v12 java.io.InputStream) = (r17v9 java.io.InputStream), (r17v10 java.io.InputStream), (r17v13 java.io.InputStream), (r17v20 java.io.InputStream) binds: [B:156:0x02cf, B:176:0x030b, B:166:0x02ed, B:124:0x0242] A[DONT_GENERATE, DONT_INLINE]
  0x030d: PHI (r18v9 ??) = (r18v6 ??), (r18v7 ??), (r18v10 ??), (r18v14 ??) binds: [B:156:0x02cf, B:176:0x030b, B:166:0x02ed, B:124:0x0242] A[DONT_GENERATE, DONT_INLINE]
  0x030d: PHI (r21v12 ??) = (r21v8 ??), (r21v9 ??), (r21v13 ??), (r21v23 ??) binds: [B:156:0x02cf, B:176:0x030b, B:166:0x02ed, B:124:0x0242] A[DONT_GENERATE, DONT_INLINE]
  0x030d: PHI (r22v12 java.lang.String) = (r22v8 java.lang.String), (r22v9 java.lang.String), (r22v13 java.lang.String), (r22v23 java.lang.String) binds: [B:156:0x02cf, B:176:0x030b, B:166:0x02ed, B:124:0x0242] A[DONT_GENERATE, DONT_INLINE]] */
    /* JADX WARN: Code duplicated, block: B:180:0x031e  */
    /* JADX WARN: Code duplicated, block: B:183:0x033d A[Catch: all -> 0x0356, TRY_LEAVE, TryCatch #40 {all -> 0x0356, blocks: (B:181:0x0335, B:183:0x033d), top: B:267:0x0335 }] */
    /* JADX WARN: Code duplicated, block: B:187:0x035a  */
    /* JADX WARN: Code duplicated, block: B:188:0x037c  */
    /* JADX WARN: Code duplicated, block: B:191:0x039e A[Catch: all -> 0x03c3, TRY_LEAVE, TryCatch #22 {all -> 0x03c3, blocks: (B:189:0x0396, B:191:0x039e), top: B:248:0x0396 }] */
    /* JADX WARN: Code duplicated, block: B:193:0x03c3  */
    /* JADX WARN: Code duplicated, block: B:196:0x03cb  */
    /* JADX WARN: Code duplicated, block: B:198:0x03d5  */
    /* JADX WARN: Code duplicated, block: B:200:0x03db  */
    /* JADX WARN: Code duplicated, block: B:209:0x042d A[Catch: all -> 0x04ac, TryCatch #5 {, blocks: (B:206:0x040c, B:207:0x041f, B:209:0x042d, B:211:0x0437, B:215:0x0487, B:216:0x04ab, B:213:0x0441), top: B:242:0x040c, inners: #27 }] */
    /* JADX WARN: Code duplicated, block: B:211:0x0437 A[Catch: all -> 0x04ac, TRY_LEAVE, TryCatch #5 {, blocks: (B:206:0x040c, B:207:0x041f, B:209:0x042d, B:211:0x0437, B:215:0x0487, B:216:0x04ab, B:213:0x0441), top: B:242:0x040c, inners: #27 }] */
    /* JADX WARN: Code duplicated, block: B:217:0x04ac A[ORIG_RETURN, RETURN] */
    /* JADX WARN: Code duplicated, block: B:221:0x04b2  */
    /* JADX WARN: Code duplicated, block: B:223:0x04b7  */
    /* JADX WARN: Code duplicated, block: B:225:0x04bc  */
    /* JADX WARN: Code duplicated, block: B:248:0x0396 A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code restructure failed: missing block: B:124:0x0242, code lost:
    
        if (r18 != 0) goto L177;
     */
    /* JADX WARN: Code restructure failed: missing block: B:298:?, code lost:
    
        return;
     */
    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r11v0, types: [java.lang.String] */
    /* JADX WARN: Type inference failed for: r11v10 */
    /* JADX WARN: Type inference failed for: r11v11 */
    /* JADX WARN: Type inference failed for: r11v12, types: [java.util.zip.ZipFile] */
    /* JADX WARN: Type inference failed for: r11v16, types: [java.lang.CharSequence] */
    /* JADX WARN: Type inference failed for: r11v17 */
    /* JADX WARN: Type inference failed for: r11v18 */
    /* JADX WARN: Type inference failed for: r11v19 */
    /* JADX WARN: Type inference failed for: r11v21 */
    /* JADX WARN: Type inference failed for: r11v4 */
    /* JADX WARN: Type inference failed for: r11v46 */
    /* JADX WARN: Type inference failed for: r11v47 */
    /* JADX WARN: Type inference failed for: r11v48 */
    /* JADX WARN: Type inference failed for: r11v51 */
    /* JADX WARN: Type inference failed for: r11v52 */
    /* JADX WARN: Type inference failed for: r11v53 */
    /* JADX WARN: Type inference failed for: r11v54 */
    /* JADX WARN: Type inference failed for: r11v8, types: [java.util.zip.ZipFile] */
    /* JADX WARN: Type inference failed for: r11v9, types: [java.util.zip.ZipFile] */
    /* JADX WARN: Type inference failed for: r16v0 */
    /* JADX WARN: Type inference failed for: r16v1, types: [java.util.zip.ZipFile] */
    /* JADX WARN: Type inference failed for: r16v2 */
    /* JADX WARN: Type inference failed for: r16v5 */
    /* JADX WARN: Type inference failed for: r16v6 */
    /* JADX WARN: Type inference failed for: r18v0 */
    /* JADX WARN: Type inference failed for: r18v1, types: [java.io.OutputStream] */
    /* JADX WARN: Type inference failed for: r18v10 */
    /* JADX WARN: Type inference failed for: r18v11 */
    /* JADX WARN: Type inference failed for: r18v12 */
    /* JADX WARN: Type inference failed for: r18v13 */
    /* JADX WARN: Type inference failed for: r18v14 */
    /* JADX WARN: Type inference failed for: r18v15 */
    /* JADX WARN: Type inference failed for: r18v16 */
    /* JADX WARN: Type inference failed for: r18v17 */
    /* JADX WARN: Type inference failed for: r18v18 */
    /* JADX WARN: Type inference failed for: r18v19 */
    /* JADX WARN: Type inference failed for: r18v20 */
    /* JADX WARN: Type inference failed for: r18v21 */
    /* JADX WARN: Type inference failed for: r18v22 */
    /* JADX WARN: Type inference failed for: r18v23 */
    /* JADX WARN: Type inference failed for: r18v24 */
    /* JADX WARN: Type inference failed for: r18v25 */
    /* JADX WARN: Type inference failed for: r18v26 */
    /* JADX WARN: Type inference failed for: r18v27 */
    /* JADX WARN: Type inference failed for: r18v28 */
    /* JADX WARN: Type inference failed for: r18v29 */
    /* JADX WARN: Type inference failed for: r18v3 */
    /* JADX WARN: Type inference failed for: r18v30 */
    /* JADX WARN: Type inference failed for: r18v31 */
    /* JADX WARN: Type inference failed for: r18v32 */
    /* JADX WARN: Type inference failed for: r18v33 */
    /* JADX WARN: Type inference failed for: r18v34 */
    /* JADX WARN: Type inference failed for: r18v4 */
    /* JADX WARN: Type inference failed for: r18v5 */
    /* JADX WARN: Type inference failed for: r18v6 */
    /* JADX WARN: Type inference failed for: r18v7 */
    /* JADX WARN: Type inference failed for: r18v8 */
    /* JADX WARN: Type inference failed for: r18v9, types: [java.io.OutputStream] */
    /* JADX WARN: Type inference failed for: r21v10 */
    /* JADX WARN: Type inference failed for: r21v11 */
    /* JADX WARN: Type inference failed for: r21v12 */
    /* JADX WARN: Type inference failed for: r21v13 */
    /* JADX WARN: Type inference failed for: r21v17 */
    /* JADX WARN: Type inference failed for: r21v18 */
    /* JADX WARN: Type inference failed for: r21v19 */
    /* JADX WARN: Type inference failed for: r21v20 */
    /* JADX WARN: Type inference failed for: r21v21 */
    /* JADX WARN: Type inference failed for: r21v22 */
    /* JADX WARN: Type inference failed for: r21v23 */
    /* JADX WARN: Type inference failed for: r21v26 */
    /* JADX WARN: Type inference failed for: r21v27 */
    /* JADX WARN: Type inference failed for: r21v28 */
    /* JADX WARN: Type inference failed for: r21v31 */
    /* JADX WARN: Type inference failed for: r21v32 */
    /* JADX WARN: Type inference failed for: r21v33 */
    /* JADX WARN: Type inference failed for: r21v37 */
    /* JADX WARN: Type inference failed for: r21v39 */
    /* JADX WARN: Type inference failed for: r21v40 */
    /* JADX WARN: Type inference failed for: r21v41 */
    /* JADX WARN: Type inference failed for: r21v42 */
    /* JADX WARN: Type inference failed for: r21v43 */
    /* JADX WARN: Type inference failed for: r21v44 */
    /* JADX WARN: Type inference failed for: r21v45 */
    /* JADX WARN: Type inference failed for: r21v46 */
    /* JADX WARN: Type inference failed for: r21v47 */
    /* JADX WARN: Type inference failed for: r21v48 */
    /* JADX WARN: Type inference failed for: r21v8 */
    /* JADX WARN: Type inference failed for: r21v9 */
    /* JADX WARN: Type inference failed for: r2v12, types: [java.lang.Object] */
    /* JADX WARN: Type inference failed for: r3v4, types: [java.lang.String] */
    /*
        Code decompiled incorrectly, please refer to instructions dump.
        To view partially-correct add '--show-bad-code' argument
    */
    private void a(com.kuaishou.weapon.p0.s r25, java.lang.String r26, java.lang.String r27, boolean r28) throws java.lang.Throwable {
        /*
            Method dump skipped, instruction units count: 1216
            To view this dump add '--comments-level debug' option
        */
        throw new UnsupportedOperationException("Method not decompiled: com.kuaishou.weapon.p0.r.a(com.kuaishou.weapon.p0.s, java.lang.String, java.lang.String, boolean):void");
    }

    private void a(s sVar, String str, String str2, HashSet<String> hashSet, byte[] bArr, StringBuilder sb, boolean z) throws Throwable {
        File file;
        String str3;
        ZipInputStream zipInputStream = new ZipInputStream(new FileInputStream(sVar.e));
        FileOutputStream fileOutputStream = null;
        while (true) {
            try {
                ZipEntry nextEntry = zipInputStream.getNextEntry();
                if (nextEntry == null) {
                    break;
                }
                String name = nextEntry.getName();
                if (!name.contains("../")) {
                    if (name.startsWith("lib/") && !nextEntry.isDirectory()) {
                        String str4 = Build.CPU_ABI;
                        try {
                            str3 = Build.CPU_ABI2;
                        } catch (Throwable unused) {
                            str3 = null;
                        }
                        if (name.contains(str4) || ((!TextUtils.isEmpty(str3) && name.contains(str3)) || (name.contains("armeabi") && ("armeabi-v7a".equalsIgnoreCase(str4) || (!TextUtils.isEmpty(str3) && "armeabi-v7a".equalsIgnoreCase(str3)))))) {
                            String str5 = str + name.substring(3).replace(".so", str2 + ".so");
                            String strSubstring = str5.substring(0, str5.lastIndexOf(47));
                            hashSet.add(strSubstring.substring(strSubstring.lastIndexOf(47) + 1));
                            e(strSubstring);
                            File file2 = new File(str5);
                            file2.delete();
                            file2.createNewFile();
                            FileOutputStream fileOutputStream2 = new FileOutputStream(str5);
                            while (true) {
                                try {
                                    int i = zipInputStream.read(bArr);
                                    if (i <= 0) {
                                        break;
                                    } else {
                                        fileOutputStream2.write(bArr, 0, i);
                                    }
                                } catch (Throwable th) {
                                    th = th;
                                    fileOutputStream = fileOutputStream2;
                                    zipInputStream.close();
                                    if (fileOutputStream != null) {
                                        fileOutputStream.close();
                                    }
                                    throw th;
                                }
                            }
                            fileOutputStream2.close();
                            dl.a(str5, Boolean.TRUE);
                            fileOutputStream = fileOutputStream2;
                        }
                    }
                    try {
                        if (name.endsWith(".dex") && !nextEntry.isDirectory() && z) {
                            String str6 = sVar.m;
                            e(str6);
                            file = new File(str6, sVar.f2731a + "-" + sVar.d + ".dex");
                            try {
                                file.delete();
                                file.createNewFile();
                                FileOutputStream fileOutputStream3 = new FileOutputStream(file);
                                while (true) {
                                    try {
                                        int i2 = zipInputStream.read(bArr);
                                        if (i2 <= 0) {
                                            break;
                                        } else {
                                            fileOutputStream3.write(bArr, 0, i2);
                                        }
                                    } catch (Throwable unused2) {
                                        fileOutputStream = fileOutputStream3;
                                        if (file != null && file.exists()) {
                                            file.delete();
                                        }
                                    }
                                }
                                fileOutputStream3.close();
                                if (sb.length() > 0) {
                                    sb.setLength(0);
                                }
                                sb.append(file.getAbsolutePath());
                                dl.a(sb.toString(), Boolean.TRUE);
                                fileOutputStream = fileOutputStream3;
                            } catch (Throwable unused3) {
                            }
                        }
                    } catch (Throwable unused4) {
                        file = null;
                    }
                    zipInputStream.closeEntry();
                }
            } catch (Throwable th2) {
                th = th2;
            }
        }
        zipInputStream.close();
        if (fileOutputStream != null) {
            fileOutputStream.close();
        }
    }
}
