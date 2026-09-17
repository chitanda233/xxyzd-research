package com.tencent.bugly.proguard;

import android.content.Context;
import android.text.TextUtils;
import com.tencent.bugly.crashreport.crash.CrashDetailBean;
import com.tencent.bugly.crashreport.crash.jni.NativeExceptionHandler;
import java.io.BufferedInputStream;
import java.io.BufferedReader;
import java.io.ByteArrayOutputStream;
import java.io.File;
import java.io.FileInputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.regex.Pattern;

/* JADX INFO: compiled from: BUGLY */
/* JADX INFO: loaded from: classes4.dex */
public final class be {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static List<File> f3776a = new ArrayList();

    private static Map<String, Integer> d(String str) {
        if (str == null) {
            return null;
        }
        try {
            HashMap map = new HashMap();
            for (String str2 : str.split(",")) {
                String[] strArrSplit = str2.split(":");
                if (strArrSplit.length != 2) {
                    al.e("error format at %s", str2);
                    return null;
                }
                map.put(strArrSplit[0], Integer.valueOf(Integer.parseInt(strArrSplit[1])));
            }
            return map;
        } catch (Exception e) {
            al.e("error format intStateStr %s", str);
            e.printStackTrace();
            return null;
        }
    }

    protected static String a(String str) {
        if (str == null) {
            return "";
        }
        String[] strArrSplit = str.split("\n");
        if (strArrSplit == null || strArrSplit.length == 0) {
            return str;
        }
        StringBuilder sb = new StringBuilder();
        for (String str2 : strArrSplit) {
            if (!str2.contains("java.lang.Thread.getStackTrace(")) {
                sb.append(str2).append("\n");
            }
        }
        return sb.toString();
    }

    private static <KeyT, ValueT> ValueT a(Map<KeyT, ValueT> map, KeyT keyt, ValueT valuet) {
        try {
            ValueT valuet2 = map.get(keyt);
            return valuet2 != null ? valuet2 : valuet;
        } catch (Exception e) {
            al.a(e);
        }
    }

    private static String a(BufferedInputStream bufferedInputStream) throws IOException {
        ByteArrayOutputStream byteArrayOutputStream;
        try {
            byteArrayOutputStream = new ByteArrayOutputStream(1024);
            while (true) {
                try {
                    int i = bufferedInputStream.read();
                    if (i == -1) {
                        break;
                    }
                    if (i == 0) {
                        String str = new String(byteArrayOutputStream.toByteArray(), "UTf-8");
                        byteArrayOutputStream.close();
                        return str;
                    }
                    byteArrayOutputStream.write(i);
                } catch (Throwable th) {
                    th = th;
                    try {
                        al.a(th);
                        if (byteArrayOutputStream != null) {
                            break;
                        }
                        return null;
                    } finally {
                        if (byteArrayOutputStream != null) {
                            byteArrayOutputStream.close();
                        }
                    }
                }
            }
        } catch (Throwable th2) {
            th = th2;
            byteArrayOutputStream = null;
        }
        return null;
    }

    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r7v3, types: [boolean] */
    public static CrashDetailBean a(Context context, String str, NativeExceptionHandler nativeExceptionHandler) {
        BufferedInputStream bufferedInputStream;
        String str2;
        String strA;
        BufferedInputStream bufferedInputStream2 = 0;
        if (context == null || str == null || nativeExceptionHandler == null) {
            al.e("get eup record file args error", new Object[0]);
            return null;
        }
        File file = new File(str, "rqd_record.eup");
        if (file.exists()) {
            ?? CanRead = file.canRead();
            try {
                if (CanRead != 0) {
                    try {
                        bufferedInputStream = new BufferedInputStream(new FileInputStream(file));
                        try {
                            String strA2 = a(bufferedInputStream);
                            if (strA2 != null && strA2.equals("NATIVE_RQD_REPORT")) {
                                HashMap map = new HashMap();
                                loop0: while (true) {
                                    str2 = null;
                                    while (true) {
                                        strA = a(bufferedInputStream);
                                        if (strA == null) {
                                            break loop0;
                                        }
                                        if (str2 == null) {
                                            str2 = strA;
                                        }
                                    }
                                    map.put(str2, strA);
                                }
                                if (str2 != null) {
                                    al.e("record not pair! drop! %s", str2);
                                    try {
                                        bufferedInputStream.close();
                                    } catch (IOException e) {
                                        e.printStackTrace();
                                    }
                                    return null;
                                }
                                CrashDetailBean crashDetailBeanA = a(context, map, nativeExceptionHandler);
                                try {
                                    bufferedInputStream.close();
                                } catch (IOException e2) {
                                    e2.printStackTrace();
                                }
                                return crashDetailBeanA;
                            }
                            al.e("record read fail! %s", strA2);
                            try {
                                bufferedInputStream.close();
                            } catch (IOException e3) {
                                e3.printStackTrace();
                            }
                            return null;
                        } catch (IOException e4) {
                            e = e4;
                            e.printStackTrace();
                            if (bufferedInputStream != null) {
                                try {
                                    bufferedInputStream.close();
                                } catch (IOException e5) {
                                    e5.printStackTrace();
                                }
                            }
                            return null;
                        }
                    } catch (IOException e6) {
                        e = e6;
                        bufferedInputStream = null;
                    } catch (Throwable th) {
                        th = th;
                        if (bufferedInputStream2 != 0) {
                            try {
                                bufferedInputStream2.close();
                            } catch (IOException e7) {
                                e7.printStackTrace();
                            }
                        }
                        throw th;
                    }
                }
            } catch (Throwable th2) {
                th = th2;
                bufferedInputStream2 = CanRead;
            }
        }
        return null;
    }

    private static String b(String str, String str2) {
        BufferedReader bufferedReaderB = ap.b(str, "reg_record.txt");
        if (bufferedReaderB == null) {
            return null;
        }
        try {
            StringBuilder sb = new StringBuilder();
            String line = bufferedReaderB.readLine();
            if (line != null && line.startsWith(str2)) {
                int i = 18;
                int i2 = 0;
                int length = 0;
                while (true) {
                    String line2 = bufferedReaderB.readLine();
                    if (line2 == null) {
                        break;
                    }
                    if (i2 % 4 == 0) {
                        if (i2 > 0) {
                            sb.append("\n");
                        }
                        sb.append("  ");
                    } else {
                        if (line2.length() > 16) {
                            i = 28;
                        }
                        sb.append("                ".substring(0, i - length));
                    }
                    length = line2.length();
                    sb.append(line2);
                    i2++;
                }
                sb.append("\n");
                String string = sb.toString();
                if (bufferedReaderB != null) {
                    try {
                        bufferedReaderB.close();
                    } catch (Exception e) {
                        al.a(e);
                    }
                }
                return string;
            }
            if (bufferedReaderB != null) {
                try {
                    bufferedReaderB.close();
                } catch (Exception e2) {
                    al.a(e2);
                }
            }
            return null;
        } catch (Throwable th) {
            try {
                al.a(th);
                return null;
            } finally {
                if (bufferedReaderB != null) {
                    try {
                        bufferedReaderB.close();
                    } catch (Exception e3) {
                        al.a(e3);
                    }
                }
            }
        }
    }

    private static String c(String str, String str2) {
        BufferedReader bufferedReaderB = ap.b(str, "map_record.txt");
        if (bufferedReaderB == null) {
            return null;
        }
        try {
            StringBuilder sb = new StringBuilder();
            String line = bufferedReaderB.readLine();
            if (line != null && line.startsWith(str2)) {
                while (true) {
                    String line2 = bufferedReaderB.readLine();
                    if (line2 == null) {
                        break;
                    }
                    sb.append("  ");
                    sb.append(line2);
                    sb.append("\n");
                }
                String string = sb.toString();
                if (bufferedReaderB != null) {
                    try {
                        bufferedReaderB.close();
                    } catch (Exception e) {
                        al.a(e);
                    }
                }
                return string;
            }
            if (bufferedReaderB != null) {
                try {
                    bufferedReaderB.close();
                } catch (Exception e2) {
                    al.a(e2);
                }
            }
            return null;
        } catch (Throwable th) {
            try {
                al.a(th);
                return null;
            } finally {
                if (bufferedReaderB != null) {
                    try {
                        bufferedReaderB.close();
                    } catch (Exception e3) {
                        al.a(e3);
                    }
                }
            }
        }
    }

    public static String a(String str, String str2) {
        if (str == null || str2 == null) {
            return null;
        }
        StringBuilder sb = new StringBuilder();
        String strB = b(str, str2);
        if (strB != null && !strB.isEmpty()) {
            sb.append("Register infos:\n");
            sb.append(strB);
        }
        String strC = c(str, str2);
        if (strC != null && !strC.isEmpty()) {
            if (sb.length() > 0) {
                sb.append("\n");
            }
            sb.append("System SO infos:\n");
            sb.append(strC);
        }
        return sb.toString();
    }

    public static String b(String str) {
        if (str == null) {
            return null;
        }
        File file = new File(str, "backup_record.txt");
        if (file.exists()) {
            return file.getAbsolutePath();
        }
        return null;
    }

    public static void c(String str) {
        File[] fileArrListFiles;
        if (str == null) {
            return;
        }
        try {
            File file = new File(str);
            if (file.canRead() && file.isDirectory() && (fileArrListFiles = file.listFiles()) != null) {
                for (File file2 : fileArrListFiles) {
                    if (file2.canRead() && file2.canWrite() && file2.length() == 0) {
                        file2.delete();
                        al.c("Delete empty record file %s", file2.getAbsoluteFile());
                    }
                }
            }
        } catch (Throwable th) {
            al.a(th);
        }
    }

    public static void a(boolean z, String str) {
        if (str != null) {
            f3776a.add(new File(str, "rqd_record.eup"));
            f3776a.add(new File(str, "reg_record.txt"));
            f3776a.add(new File(str, "map_record.txt"));
            f3776a.add(new File(str, "backup_record.txt"));
            if (z) {
                c(str);
            }
        }
        List<File> list = f3776a;
        if (list == null || list.size() <= 0) {
            return;
        }
        for (File file : f3776a) {
            if (file.exists() && file.canWrite()) {
                file.delete();
                al.c("Delete record file %s", file.getAbsoluteFile());
            }
        }
    }

    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r6v1, types: [java.lang.StringBuilder] */
    /* JADX WARN: Type inference failed for: r6v11 */
    /* JADX WARN: Type inference failed for: r6v12 */
    /* JADX WARN: Type inference failed for: r6v7, types: [java.lang.String] */
    public static String a(String str, int i, String str2, boolean z) {
        BufferedReader bufferedReader = null;
        if (str != null && i > 0) {
            File file = new File(str);
            if (file.exists() && file.canRead()) {
                al.a("Read system log from native record file(length: %s bytes): %s", Long.valueOf(file.length()), file.getAbsolutePath());
                f3776a.add(file);
                al.c("Add this record file to list for cleaning lastly.", new Object[0]);
                if (str2 == null) {
                    return ap.a(new File(str), i, z);
                }
                String sb = new StringBuilder();
                try {
                    try {
                        BufferedReader bufferedReader2 = new BufferedReader(new InputStreamReader(new FileInputStream(file), "utf-8"));
                        while (true) {
                            try {
                                String line = bufferedReader2.readLine();
                                if (line == null) {
                                    break;
                                }
                                if (Pattern.compile(str2 + "[ ]*:").matcher(line).find()) {
                                    sb.append(line).append("\n");
                                }
                                if (i > 0 && sb.length() > i) {
                                    if (z) {
                                        sb.delete(i, sb.length());
                                        break;
                                    }
                                    sb.delete(0, sb.length() - i);
                                }
                            } catch (Throwable th) {
                                th = th;
                                bufferedReader = bufferedReader2;
                                try {
                                    al.a(th);
                                    String string = sb.append("\n[error:" + th.toString() + "]").toString();
                                    if (bufferedReader == null) {
                                        return string;
                                    }
                                    bufferedReader.close();
                                    sb = string;
                                } catch (Throwable th2) {
                                    if (bufferedReader != null) {
                                        try {
                                            bufferedReader.close();
                                        } catch (Exception e) {
                                            al.a(e);
                                        }
                                    }
                                    throw th2;
                                }
                            }
                        }
                        String string2 = sb.toString();
                        bufferedReader2.close();
                        sb = string2;
                    } catch (Exception e2) {
                        al.a(e2);
                        return sb;
                    }
                } catch (Throwable th3) {
                    th = th3;
                }
                return sb;
            }
        }
        return null;
    }

    private static Map<String, String> a(Map<String, String> map) {
        String str = map.get("key-value");
        if (str == null) {
            return null;
        }
        HashMap map2 = new HashMap();
        for (String str2 : str.split("\n")) {
            String[] strArrSplit = str2.split("=");
            if (strArrSplit.length == 2) {
                map2.put(strArrSplit[0], strArrSplit[1]);
            }
        }
        return map2;
    }

    private static long b(Map<String, String> map) {
        String str = map.get("launchTime");
        if (str == null) {
            return -1L;
        }
        al.c("[Native record info] launchTime: %s", str);
        try {
            return Long.parseLong(str);
        } catch (NumberFormatException e) {
            if (al.a(e)) {
                return -1L;
            }
            e.printStackTrace();
            return -1L;
        }
    }

    /* JADX WARN: Code duplicated, block: B:15:0x0037 A[RETURN] */
    /* JADX WARN: Code duplicated, block: B:16:0x0038  */
    /* JADX WARN: Code duplicated, block: B:18:0x0044  */
    /* JADX WARN: Code duplicated, block: B:22:0x007c A[Catch: all -> 0x0254, TryCatch #0 {all -> 0x0254, blocks: (B:20:0x0056, B:22:0x007c, B:24:0x0084, B:26:0x00ab, B:27:0x00c2, B:30:0x00d0, B:32:0x00d6, B:34:0x00f6, B:36:0x0100, B:38:0x0106, B:40:0x0111, B:42:0x0123, B:43:0x013c, B:45:0x0150, B:46:0x0169, B:48:0x017c, B:49:0x0195, B:51:0x01f2, B:53:0x0236, B:55:0x0247), top: B:60:0x0056 }] */
    /* JADX WARN: Code duplicated, block: B:24:0x0084 A[Catch: all -> 0x0254, TryCatch #0 {all -> 0x0254, blocks: (B:20:0x0056, B:22:0x007c, B:24:0x0084, B:26:0x00ab, B:27:0x00c2, B:30:0x00d0, B:32:0x00d6, B:34:0x00f6, B:36:0x0100, B:38:0x0106, B:40:0x0111, B:42:0x0123, B:43:0x013c, B:45:0x0150, B:46:0x0169, B:48:0x017c, B:49:0x0195, B:51:0x01f2, B:53:0x0236, B:55:0x0247), top: B:60:0x0056 }] */
    /* JADX WARN: Code duplicated, block: B:26:0x00ab A[Catch: all -> 0x0254, TryCatch #0 {all -> 0x0254, blocks: (B:20:0x0056, B:22:0x007c, B:24:0x0084, B:26:0x00ab, B:27:0x00c2, B:30:0x00d0, B:32:0x00d6, B:34:0x00f6, B:36:0x0100, B:38:0x0106, B:40:0x0111, B:42:0x0123, B:43:0x013c, B:45:0x0150, B:46:0x0169, B:48:0x017c, B:49:0x0195, B:51:0x01f2, B:53:0x0236, B:55:0x0247), top: B:60:0x0056 }] */
    /* JADX WARN: Code duplicated, block: B:33:0x00f4  */
    /* JADX WARN: Code duplicated, block: B:39:0x010f  */
    /* JADX WARN: Code duplicated, block: B:42:0x0123 A[Catch: all -> 0x0254, TryCatch #0 {all -> 0x0254, blocks: (B:20:0x0056, B:22:0x007c, B:24:0x0084, B:26:0x00ab, B:27:0x00c2, B:30:0x00d0, B:32:0x00d6, B:34:0x00f6, B:36:0x0100, B:38:0x0106, B:40:0x0111, B:42:0x0123, B:43:0x013c, B:45:0x0150, B:46:0x0169, B:48:0x017c, B:49:0x0195, B:51:0x01f2, B:53:0x0236, B:55:0x0247), top: B:60:0x0056 }] */
    /* JADX WARN: Code duplicated, block: B:45:0x0150 A[Catch: all -> 0x0254, TryCatch #0 {all -> 0x0254, blocks: (B:20:0x0056, B:22:0x007c, B:24:0x0084, B:26:0x00ab, B:27:0x00c2, B:30:0x00d0, B:32:0x00d6, B:34:0x00f6, B:36:0x0100, B:38:0x0106, B:40:0x0111, B:42:0x0123, B:43:0x013c, B:45:0x0150, B:46:0x0169, B:48:0x017c, B:49:0x0195, B:51:0x01f2, B:53:0x0236, B:55:0x0247), top: B:60:0x0056 }] */
    /* JADX WARN: Code duplicated, block: B:48:0x017c A[Catch: all -> 0x0254, TryCatch #0 {all -> 0x0254, blocks: (B:20:0x0056, B:22:0x007c, B:24:0x0084, B:26:0x00ab, B:27:0x00c2, B:30:0x00d0, B:32:0x00d6, B:34:0x00f6, B:36:0x0100, B:38:0x0106, B:40:0x0111, B:42:0x0123, B:43:0x013c, B:45:0x0150, B:46:0x0169, B:48:0x017c, B:49:0x0195, B:51:0x01f2, B:53:0x0236, B:55:0x0247), top: B:60:0x0056 }] */
    /* JADX WARN: Code duplicated, block: B:51:0x01f2 A[Catch: all -> 0x0254, TryCatch #0 {all -> 0x0254, blocks: (B:20:0x0056, B:22:0x007c, B:24:0x0084, B:26:0x00ab, B:27:0x00c2, B:30:0x00d0, B:32:0x00d6, B:34:0x00f6, B:36:0x0100, B:38:0x0106, B:40:0x0111, B:42:0x0123, B:43:0x013c, B:45:0x0150, B:46:0x0169, B:48:0x017c, B:49:0x0195, B:51:0x01f2, B:53:0x0236, B:55:0x0247), top: B:60:0x0056 }] */
    /* JADX WARN: Code duplicated, block: B:53:0x0236 A[Catch: all -> 0x0254, TryCatch #0 {all -> 0x0254, blocks: (B:20:0x0056, B:22:0x007c, B:24:0x0084, B:26:0x00ab, B:27:0x00c2, B:30:0x00d0, B:32:0x00d6, B:34:0x00f6, B:36:0x0100, B:38:0x0106, B:40:0x0111, B:42:0x0123, B:43:0x013c, B:45:0x0150, B:46:0x0169, B:48:0x017c, B:49:0x0195, B:51:0x01f2, B:53:0x0236, B:55:0x0247), top: B:60:0x0056 }] */
    /* JADX WARN: Code duplicated, block: B:54:0x0246  */
    /* JADX WARN: Code duplicated, block: B:60:0x0056 A[EXC_TOP_SPLITTER, SYNTHETIC] */
    private static CrashDetailBean a(Context context, Map<String, String> map, NativeExceptionHandler nativeExceptionHandler) {
        boolean z;
        Map<String, Integer> mapD;
        String str;
        String str2;
        String str3;
        String str4;
        String str5;
        Integer num;
        String str6;
        String str7;
        String str8;
        byte[] bArrA;
        String str9;
        Integer num2;
        String str10;
        Integer num3;
        String str11;
        Integer num4;
        CrashDetailBean crashDetailBeanPackageCrashDatas;
        String str12;
        boolean zEqualsIgnoreCase;
        if (aa.a(context) == null) {
            al.e("abnormal com info not created", new Object[0]);
        } else {
            String str13 = map.get("intStateStr");
            if (str13 == null || str13.trim().length() <= 0) {
                al.e("no intStateStr", new Object[0]);
            } else {
                z = true;
            }
            if (!z) {
                return null;
            }
            mapD = d(map.get("intStateStr"));
            if (mapD == null) {
                al.e("parse intSateMap fail", Integer.valueOf(map.size()));
                return null;
            }
            try {
                mapD.get("sino").intValue();
                mapD.get("sud").intValue();
                str = map.get("soVersion");
                if (TextUtils.isEmpty(str)) {
                    al.e("error format at version", new Object[0]);
                    return null;
                }
                str2 = (String) a(map, "codeMsg", "unknown");
                str3 = (String) a(map, "signalName", "unknown");
                map.get("errnoMsg");
                str4 = (String) a(map, "stack", "unknown");
                str5 = map.get("jstack");
                if (str5 != null) {
                    str4 = str4 + "java:\n" + str5;
                }
                num = mapD.get("sico");
                if (num != null || num.intValue() <= 0) {
                    str6 = str2;
                    str7 = str3;
                } else {
                    str7 = str3 + "(" + str2 + ")";
                    str6 = "KERNEL";
                }
                str8 = map.get("nativeLog");
                if (str8 != null || str8.isEmpty()) {
                    bArrA = null;
                } else {
                    bArrA = ap.a(str8, "BuglyNativeLog.txt");
                }
                str9 = (String) a(map, "sendingProcess", "unknown");
                num2 = mapD.get("spd");
                if (num2 != null) {
                    str9 = str9 + "(" + num2 + ")";
                }
                String str14 = str9;
                str10 = (String) a(map, "threadName", "unknown");
                num3 = mapD.get("et");
                if (num3 != null) {
                    str10 = str10 + "(" + num3 + ")";
                }
                String str15 = str10;
                str11 = (String) a(map, "processName", "unknown");
                num4 = mapD.get("ep");
                if (num4 != null) {
                    str11 = str11 + "(" + num4 + ")";
                }
                crashDetailBeanPackageCrashDatas = nativeExceptionHandler.packageCrashDatas(str11, str15, (((long) mapD.get("ets").intValue()) * 1000) + (((long) mapD.get("etms").intValue()) / 1000), str7, (String) a(map, "errorAddr", "unknown"), a(str4), str6, str14, (String) a(map, "tombPath", "unknown"), map.get("sysLogPath"), map.get("jniLogPath"), str, bArrA, a(map), false, false);
                if (crashDetailBeanPackageCrashDatas != null) {
                    crashDetailBeanPackageCrashDatas.m = (String) a(map, "userId", crashDetailBeanPackageCrashDatas.m);
                    al.c("[Native record info] userId: %s", crashDetailBeanPackageCrashDatas.m);
                    crashDetailBeanPackageCrashDatas.w = (String) a(map, "sysLog", crashDetailBeanPackageCrashDatas.w);
                    crashDetailBeanPackageCrashDatas.f = (String) a(map, "appVersion", crashDetailBeanPackageCrashDatas.w);
                    al.c("[Native record info] appVersion: %s", crashDetailBeanPackageCrashDatas.f);
                    str12 = map.get("isAppForeground");
                    if (str12 != null) {
                        al.c("[Native record info] isAppForeground: %s", str12);
                        zEqualsIgnoreCase = str12.equalsIgnoreCase("true");
                    } else {
                        zEqualsIgnoreCase = false;
                    }
                    crashDetailBeanPackageCrashDatas.R = zEqualsIgnoreCase;
                    crashDetailBeanPackageCrashDatas.Q = b(map);
                    crashDetailBeanPackageCrashDatas.z = null;
                    crashDetailBeanPackageCrashDatas.k = true;
                }
                return crashDetailBeanPackageCrashDatas;
            } catch (Throwable th) {
                al.e("error format", new Object[0]);
                th.printStackTrace();
                return null;
            }
        }
        z = false;
        if (!z) {
            return null;
        }
        mapD = d(map.get("intStateStr"));
        if (mapD == null) {
            al.e("parse intSateMap fail", Integer.valueOf(map.size()));
            return null;
        }
        mapD.get("sino").intValue();
        mapD.get("sud").intValue();
        str = map.get("soVersion");
        if (TextUtils.isEmpty(str)) {
            al.e("error format at version", new Object[0]);
            return null;
        }
        str2 = (String) a(map, "codeMsg", "unknown");
        str3 = (String) a(map, "signalName", "unknown");
        map.get("errnoMsg");
        str4 = (String) a(map, "stack", "unknown");
        str5 = map.get("jstack");
        if (str5 != null) {
            str4 = str4 + "java:\n" + str5;
        }
        num = mapD.get("sico");
        if (num != null) {
            str6 = str2;
            str7 = str3;
        } else {
            str6 = str2;
            str7 = str3;
        }
        str8 = map.get("nativeLog");
        if (str8 != null) {
            bArrA = null;
        } else {
            bArrA = null;
        }
        str9 = (String) a(map, "sendingProcess", "unknown");
        num2 = mapD.get("spd");
        if (num2 != null) {
            str9 = str9 + "(" + num2 + ")";
        }
        String str16 = str9;
        str10 = (String) a(map, "threadName", "unknown");
        num3 = mapD.get("et");
        if (num3 != null) {
            str10 = str10 + "(" + num3 + ")";
        }
        String str17 = str10;
        str11 = (String) a(map, "processName", "unknown");
        num4 = mapD.get("ep");
        if (num4 != null) {
            str11 = str11 + "(" + num4 + ")";
        }
        crashDetailBeanPackageCrashDatas = nativeExceptionHandler.packageCrashDatas(str11, str17, (((long) mapD.get("ets").intValue()) * 1000) + (((long) mapD.get("etms").intValue()) / 1000), str7, (String) a(map, "errorAddr", "unknown"), a(str4), str6, str16, (String) a(map, "tombPath", "unknown"), map.get("sysLogPath"), map.get("jniLogPath"), str, bArrA, a(map), false, false);
        if (crashDetailBeanPackageCrashDatas != null) {
            crashDetailBeanPackageCrashDatas.m = (String) a(map, "userId", crashDetailBeanPackageCrashDatas.m);
            al.c("[Native record info] userId: %s", crashDetailBeanPackageCrashDatas.m);
            crashDetailBeanPackageCrashDatas.w = (String) a(map, "sysLog", crashDetailBeanPackageCrashDatas.w);
            crashDetailBeanPackageCrashDatas.f = (String) a(map, "appVersion", crashDetailBeanPackageCrashDatas.w);
            al.c("[Native record info] appVersion: %s", crashDetailBeanPackageCrashDatas.f);
            str12 = map.get("isAppForeground");
            if (str12 != null) {
                al.c("[Native record info] isAppForeground: %s", str12);
                zEqualsIgnoreCase = str12.equalsIgnoreCase("true");
            } else {
                zEqualsIgnoreCase = false;
            }
            crashDetailBeanPackageCrashDatas.R = zEqualsIgnoreCase;
            crashDetailBeanPackageCrashDatas.Q = b(map);
            crashDetailBeanPackageCrashDatas.z = null;
            crashDetailBeanPackageCrashDatas.k = true;
        }
        return crashDetailBeanPackageCrashDatas;
    }
}
