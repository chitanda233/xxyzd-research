package com.tencent.turingfd.sdk.ams.ad;

import android.os.Process;
import android.text.TextUtils;
import java.io.File;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.HashSet;
import java.util.Iterator;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/* JADX INFO: loaded from: classes4.dex */
public abstract class Octans {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final HashSet f3870a;
    public static final String[] b;
    public static final HashSet c;

    static {
        HashSet hashSet = new HashSet();
        f3870a = hashSet;
        b = new String[0];
        hashSet.add(Cinstanceof.a(Cinstanceof.K));
        hashSet.add(Cinstanceof.a(Cinstanceof.L));
        hashSet.add(Cinstanceof.a(Cinstanceof.M));
        hashSet.add(Cinstanceof.a(Cinstanceof.N));
        hashSet.add(Cinstanceof.a(Cinstanceof.O));
        hashSet.add(Cinstanceof.a(Cinstanceof.P));
        hashSet.add(Cinstanceof.a(Cinstanceof.Q));
        hashSet.add(Cinstanceof.a(Cinstanceof.R));
        hashSet.add(Cinstanceof.a(Cinstanceof.S));
        hashSet.add(Cinstanceof.a(Cinstanceof.T));
        hashSet.add(Cinstanceof.a(Cinstanceof.U));
        hashSet.add(Cinstanceof.a(Cinstanceof.V));
        HashSet hashSet2 = new HashSet();
        c = hashSet2;
        hashSet2.add(Cinstanceof.a(Cinstanceof.J));
    }

    public static ArrayList a() {
        Dew dewB;
        ArrayList arrayList = new ArrayList();
        ArrayList arrayList2 = new ArrayList();
        String[] list = new File("/proc").list();
        if (list != null) {
            for (String str : list) {
                if (!TextUtils.isEmpty(str)) {
                    try {
                        char cCharAt = str.charAt(0);
                        if (cCharAt <= '9' && cCharAt >= '0' && (dewB = Durian.b(Integer.parseInt(str))) != null) {
                            arrayList2.add(dewB);
                        }
                    } catch (Exception unused) {
                    }
                }
            }
        }
        ArrayList arrayList3 = new ArrayList();
        int iMyPid = Process.myPid();
        int size = arrayList2.size();
        int i = 0;
        int i2 = 0;
        while (i < size) {
            Object obj = arrayList2.get(i);
            i++;
            Dew dew = (Dew) obj;
            if (iMyPid == dew.f3845a) {
                i2 = dew.e;
            }
        }
        if (i2 != 0 && iMyPid != i2) {
            int size2 = arrayList2.size();
            String str2 = "";
            int i3 = 0;
            while (i3 < size2) {
                Object obj2 = arrayList2.get(i3);
                i3++;
                Dew dew2 = (Dew) obj2;
                if (i2 == dew2.f3845a) {
                    str2 = dew2.d;
                }
            }
            if (!TextUtils.isEmpty(str2)) {
                Cinterface cinterface = new Cinterface();
                cinterface.f3939a = f.f3927a + f.e;
                cinterface.b = str2;
                arrayList3.add(cinterface);
            }
        }
        arrayList.addAll(arrayList3);
        StringBuilder sb = new StringBuilder();
        ArrayList arrayList4 = new ArrayList();
        int size3 = arrayList2.size();
        int i4 = 0;
        while (i4 < size3) {
            Object obj3 = arrayList2.get(i4);
            i4++;
            Dew dew3 = (Dew) obj3;
            Iterator it = f3870a.iterator();
            while (it.hasNext()) {
                if (dew3.d.contains((String) it.next())) {
                    sb.append(dew3.d);
                    sb.append("_");
                }
            }
        }
        String string = sb.toString();
        if (!TextUtils.isEmpty(string)) {
            Cinterface cinterface2 = new Cinterface();
            cinterface2.f3939a = f.f3927a + f.c;
            cinterface2.b = string.substring(0, string.length() - 1);
            arrayList4.add(cinterface2);
        }
        arrayList.addAll(arrayList4);
        ArrayList arrayList5 = new ArrayList();
        StringBuilder sb2 = new StringBuilder();
        HashSet hashSet = new HashSet();
        int size4 = arrayList2.size();
        int i5 = 0;
        int i6 = 0;
        while (i5 < size4) {
            Object obj4 = arrayList2.get(i5);
            i5++;
            Dew dew4 = (Dew) obj4;
            if (dew4.c == 0 && dew4.d.startsWith("/") && !dew4.d.startsWith("/system") && !dew4.d.startsWith("/dev") && !dew4.d.startsWith("/sbin") && !dew4.d.startsWith("/init") && !dew4.d.startsWith("/vendor") && !dew4.d.startsWith("/bin") && !dew4.d.startsWith("/usr") && !dew4.d.contains("kinguser") && !dew4.d.endsWith("so")) {
                Iterator it2 = f3870a.iterator();
                do {
                    if (!it2.hasNext()) {
                        Iterator it3 = c.iterator();
                        do {
                            if (!it3.hasNext()) {
                                hashSet.add(dew4.d);
                                int i7 = i6 + 1;
                                if (i6 < 8) {
                                    i6 = i7;
                                    break;
                                }
                                break;
                            }
                        } while (!dew4.d.contains((String) it3.next()));
                    }
                } while (!dew4.d.contains((String) it2.next()));
            }
        }
        if (hashSet.size() > 0) {
            Iterator it4 = hashSet.iterator();
            while (it4.hasNext()) {
                sb2.append((String) it4.next());
                sb2.append("%3B");
            }
            String string2 = sb2.toString();
            Cinterface cinterface3 = new Cinterface();
            cinterface3.f3939a = f.f3927a + f.d;
            cinterface3.b = string2.substring(0, string2.length() - 1);
            arrayList5.add(cinterface3);
        }
        arrayList.addAll(arrayList5);
        return arrayList;
    }

    public static String b() {
        StringBuffer stringBuffer = new StringBuffer();
        String strA = a(Cinstanceof.a(Cinstanceof.m0), Cinstanceof.a(Cinstanceof.A0), "v4");
        if (!TextUtils.isEmpty(strA)) {
            stringBuffer.append(strA);
        }
        String strA2 = a(Cinstanceof.a(Cinstanceof.n0), "(.{32}:.{3,4})\\s(.{32}:.{3,4})\\s(.{2})\\s.{8}:.{8}\\s.{2}:.{8}\\s.{8}\\s+(.{4,5})", "v6");
        if (!TextUtils.isEmpty(strA2)) {
            if (!TextUtils.isEmpty(strA)) {
                stringBuffer.append("_");
            }
            stringBuffer.append(strA2);
        }
        return stringBuffer.toString();
    }

    public static String a(String str, String str2, String str3) {
        String[] strArrSplit;
        String[] strArrSplit2;
        StringBuffer stringBuffer = new StringBuffer();
        try {
            String str4 = new String(CanisMinor.a(str));
            if (TextUtils.isEmpty(str4) || (strArrSplit = str4.split("\n")) == null || strArrSplit.length == 0) {
                strArrSplit = b;
            }
        } catch (Throwable unused) {
            strArrSplit = null;
        }
        if (strArrSplit == null) {
            stringBuffer.append(str3.concat(";-1"));
            return stringBuffer.toString();
        }
        stringBuffer.append(str3.concat(";0"));
        new HashMap();
        HashMap map = new HashMap();
        Pattern patternCompile = Pattern.compile(str2);
        for (String str5 : strArrSplit) {
            Matcher matcher = patternCompile.matcher(str5);
            if (matcher.find()) {
                String strTrim = matcher.group(4).trim();
                if ("0A".equals(matcher.group(3)) && (strArrSplit2 = matcher.group(1).split(":")) != null && strArrSplit2.length >= 2) {
                    map.put(strArrSplit2[1], strTrim);
                }
            }
        }
        if (!map.isEmpty()) {
            stringBuffer.append(com.alipay.sdk.m.y.l.b);
            Iterator it = map.keySet().iterator();
            while (it.hasNext()) {
                String str6 = (String) it.next();
                stringBuffer.append((String) map.get(str6));
                stringBuffer.append(":");
                stringBuffer.append(str6);
                if (it.hasNext()) {
                    stringBuffer.append(",");
                }
            }
        }
        return stringBuffer.toString();
    }
}
