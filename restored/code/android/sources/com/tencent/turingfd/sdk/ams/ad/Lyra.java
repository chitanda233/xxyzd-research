package com.tencent.turingfd.sdk.ams.ad;

import android.content.Context;
import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.HashSet;
import java.util.Iterator;
import java.util.regex.Pattern;

/* JADX INFO: loaded from: classes4.dex */
public abstract class Lyra {
    public static String a(Context context) {
        BufferedReader bufferedReader;
        int i;
        Pattern[] patternArr;
        System.currentTimeMillis();
        HashSet hashSet = new HashSet();
        try {
            String packageName = context.getPackageName();
            Pattern patternCompile = Pattern.compile("^/data/user/\\d+/" + packageName);
            String str = context.getApplicationInfo().nativeLibraryDir;
            bufferedReader = new BufferedReader(new FileReader(Cinstanceof.a(Cinstanceof.n)));
            while (true) {
                try {
                    String line = bufferedReader.readLine();
                    if (line == null) {
                        break;
                    }
                    String strA = a(line, packageName, patternCompile, str);
                    if (strA != null) {
                        hashSet.add(strA);
                    }
                } catch (Throwable unused) {
                }
            }
        } catch (Throwable unused2) {
            bufferedReader = null;
        }
        GalacticCore.a(bufferedReader);
        String[] strArr = Foxnut.f3849a;
        synchronized (Foxnut.class) {
            i = 0;
            if (Foxnut.b != null) {
                patternArr = Foxnut.b;
            } else {
                String[] strArr2 = Foxnut.f3849a;
                Foxnut.b = new Pattern[strArr2.length];
                ArrayList arrayList = new ArrayList();
                for (int i2 = 0; i2 < Foxnut.b.length; i2++) {
                    try {
                        arrayList.add(Pattern.compile(strArr2[i2]));
                    } catch (Throwable unused3) {
                    }
                }
                Foxnut.b = (Pattern[]) arrayList.toArray(new Pattern[0]);
                patternArr = Foxnut.b;
            }
        }
        Iterator it = hashSet.iterator();
        while (it.hasNext()) {
            String str2 = (String) it.next();
            for (Pattern pattern : patternArr) {
                if (pattern.matcher(str2).find()) {
                    it.remove();
                    break;
                }
            }
        }
        if (hashSet.size() <= 0) {
            return "";
        }
        StringBuilder sb = new StringBuilder();
        Iterator it2 = hashSet.iterator();
        while (it2.hasNext()) {
            i++;
            sb.append((String) it2.next());
            if (i >= 8) {
                break;
            }
            if (it2.hasNext()) {
                sb.append("_");
            }
        }
        return sb.toString();
    }

    public static String a() {
        try {
            File file = new File("/system/lib");
            if (!file.canRead()) {
                return "";
            }
            for (File file2 : file.listFiles()) {
                if (file2.getName().contains("rockchip")) {
                    return file2.getAbsolutePath();
                }
            }
            return "";
        } catch (Throwable unused) {
            return "";
        }
    }

    public static String a(String str, String str2, Pattern pattern, String str3) {
        int iIndexOf;
        String canonicalPath;
        boolean zEndsWith = str.endsWith(".so");
        boolean z = !zEndsWith && str.endsWith(".jar");
        if ((!zEndsWith && !z) || (iIndexOf = str.indexOf(47)) == -1) {
            return null;
        }
        String strTrim = str.substring(iIndexOf).trim();
        if (!strTrim.startsWith("/data/")) {
            return null;
        }
        if (zEndsWith && str3 != null && strTrim.startsWith(str3)) {
            return null;
        }
        String str4 = "/data/data/" + str2 + "/";
        if (strTrim.startsWith(str4) || strTrim.startsWith("/data/app/" + str2) || pattern.matcher(strTrim).find()) {
            return null;
        }
        if (zEndsWith) {
            File file = new File(str4 + "lib");
            HashMap map = CanisMinor.f3832a;
            try {
                canonicalPath = file.getCanonicalPath();
            } catch (IOException unused) {
                canonicalPath = null;
            }
            if (canonicalPath == null || strTrim.startsWith(canonicalPath)) {
                return null;
            }
        }
        return strTrim;
    }
}
