package com.tencent.turingfd.sdk.ams.ad;

import android.content.Context;
import android.content.SharedPreferences;
import android.os.Handler;
import android.text.TextUtils;
import android.util.Base64;
import com.sigmob.sdk.base.mta.PointType;
import java.util.HashMap;

/* JADX INFO: loaded from: classes4.dex */
public final class p {
    public static final String b = "turingfd_conf_" + Olive.f3871a + "_ad";

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final Handler f3952a;

    public p(m mVar) {
        this.f3952a = mVar;
    }

    public static h a(Context context) {
        long jLongValue;
        try {
            String strB = b(context, PointType.ANTI_SPAM);
            if (TextUtils.isEmpty(strB)) {
                return new h(1, 0, 0);
            }
            try {
                jLongValue = Long.valueOf(b(context, PointType.ANTI_SPAM_TOUCH)).longValue();
            } catch (Throwable unused) {
                jLongValue = 0;
            }
            String strB2 = b(context, "104");
            String strB3 = b(context, "105");
            String strB4 = b(context, "106");
            String strB5 = b(context, "110");
            g gVar = new g();
            gVar.b = jLongValue;
            gVar.f3930a = strB;
            gVar.c = strB2;
            gVar.d = strB3;
            gVar.e = strB4;
            gVar.f = strB5;
            return new h(gVar);
        } catch (Throwable unused2) {
            return new h(1, 0, 0);
        }
    }

    public static Triangulum b(Context context) {
        System.currentTimeMillis();
        Triangulum triangulum = new Triangulum(30);
        for (String str : b(context, PointType.SIGMOB_CRASH).split("_")) {
            try {
                Long lValueOf = Long.valueOf(str);
                lValueOf.getClass();
                triangulum.a(lValueOf);
            } catch (NumberFormatException unused) {
            }
        }
        return triangulum;
    }

    public static long c() {
        Context context;
        try {
            synchronized (Ccatch.class) {
                context = Ccatch.f3917a;
            }
            return Long.parseLong(b(context, "503"));
        } catch (Throwable unused) {
            return 0L;
        }
    }

    public static void d() {
        Context context;
        SharedPreferences sharedPreferences;
        SharedPreferences.Editor editorEdit;
        byte[] bArrB;
        synchronized (Ccatch.class) {
            context = Ccatch.f3917a;
        }
        String strA = null;
        try {
            sharedPreferences = context.getSharedPreferences(b, 0);
        } catch (Throwable unused) {
            sharedPreferences = null;
        }
        if (sharedPreferences == null || (editorEdit = sharedPreferences.edit()) == null) {
            return;
        }
        editorEdit.remove("504");
        String strValueOf = String.valueOf(1);
        byte[] bArrA = Cstrictfp.a();
        if (bArrA != null && (bArrB = Cstrictfp.b(strValueOf.getBytes(), bArrA)) != null) {
            strA = Teazle.a(bArrB);
        }
        if (strA != null) {
            editorEdit.putString("503", strA);
        }
        try {
            editorEdit.commit();
        } catch (Throwable unused2) {
        }
    }

    public static String b(Context context, String str) {
        SharedPreferences sharedPreferences;
        try {
            sharedPreferences = context.getSharedPreferences(b, 0);
        } catch (Throwable unused) {
            sharedPreferences = null;
        }
        if (sharedPreferences == null) {
            return "";
        }
        String string = sharedPreferences.getString(str, "");
        if (TextUtils.isEmpty(string)) {
            return string;
        }
        try {
            Tangor tangor = Teazle.f3900a;
            int length = string.length() / 2;
            byte[] bArr = new byte[length];
            char[] charArray = string.toUpperCase().toCharArray();
            for (int i = 0; i < length; i++) {
                int i2 = i * 2;
                bArr[i] = (byte) (((byte) "0123456789ABCDEF".indexOf(charArray[i2 + 1])) | (((byte) "0123456789ABCDEF".indexOf(charArray[i2])) << 4));
            }
            return Teazle.a("UTF-8", Cstrictfp.a(bArr, Cstrictfp.a()));
        } catch (Throwable unused2) {
            return "";
        }
    }

    public static void a(Context context, HashMap map) {
        SharedPreferences sharedPreferences;
        SharedPreferences.Editor editorEdit;
        try {
            sharedPreferences = context.getSharedPreferences(b, 0);
        } catch (Throwable unused) {
            sharedPreferences = null;
        }
        if (sharedPreferences == null || (editorEdit = sharedPreferences.edit()) == null) {
            return;
        }
        for (String str : map.keySet()) {
            try {
                editorEdit.putString(str, Teazle.a(Cstrictfp.b(((String) map.get(str)).getBytes(), Cstrictfp.a())));
            } catch (Throwable unused2) {
            }
        }
        try {
            editorEdit.commit();
        } catch (Throwable unused3) {
        }
    }

    public final void b(long j) {
        Context context;
        synchronized (Ccatch.class) {
            context = Ccatch.f3917a;
        }
        HashMap map = new HashMap();
        map.put("502", "" + j);
        a(context, map, false);
    }

    public final void a(Context context, HashMap map, boolean z) {
        Handler handler;
        if (!z && (handler = this.f3952a) != null) {
            handler.post(new o(context, map));
        } else {
            a(context, map);
        }
    }

    public static long a(Context context, String str) {
        try {
            return Long.parseLong(b(context, str));
        } catch (Throwable unused) {
            return 0L;
        }
    }

    public static String b() {
        Context context;
        synchronized (Ccatch.class) {
            context = Ccatch.f3917a;
        }
        return b(context, "1005");
    }

    public static void a(long j) {
        Context context;
        SharedPreferences sharedPreferences;
        SharedPreferences.Editor editorEdit;
        byte[] bArrB;
        byte[] bArrB2;
        synchronized (Ccatch.class) {
            context = Ccatch.f3917a;
        }
        String strA = null;
        try {
            sharedPreferences = context.getSharedPreferences(b, 0);
        } catch (Throwable unused) {
            sharedPreferences = null;
        }
        if (sharedPreferences == null || (editorEdit = sharedPreferences.edit()) == null) {
            return;
        }
        editorEdit.remove("502");
        editorEdit.remove(PointType.ANTI_SPAM);
        editorEdit.remove("902");
        editorEdit.remove("901");
        editorEdit.remove("1001");
        String strValueOf = String.valueOf(-1);
        byte[] bArrA = Cstrictfp.a();
        String strA2 = (bArrA == null || (bArrB2 = Cstrictfp.b(strValueOf.getBytes(), bArrA)) == null) ? null : Teazle.a(bArrB2);
        if (strA2 != null) {
            editorEdit.putString("503", strA2);
        }
        String strValueOf2 = String.valueOf(j);
        byte[] bArrA2 = Cstrictfp.a();
        if (bArrA2 != null && (bArrB = Cstrictfp.b(strValueOf2.getBytes(), bArrA2)) != null) {
            strA = Teazle.a(bArrB);
        }
        if (strA != null) {
            editorEdit.putString("504", strA);
        }
        try {
            editorEdit.commit();
        } catch (Throwable unused2) {
        }
    }

    public static void a(Context context, Lichee lichee) {
        String strEncodeToString;
        String str;
        if (TextUtils.isEmpty(lichee.b)) {
            return;
        }
        HashMap map = new HashMap();
        map.put("1001", lichee.b);
        map.put("1002", String.valueOf(lichee.c));
        map.put("1003", String.valueOf(lichee.d));
        map.put("1004", String.valueOf(lichee.e));
        String str2 = lichee.f;
        Tangor tangor = Teazle.f3900a;
        if (str2 == null) {
            str2 = "";
        }
        map.put("1005", str2);
        Longan longan = lichee.g;
        if (longan == null) {
            str = "";
        } else {
            String str3 = TextUtils.isEmpty(longan.f3861a) ? "" : longan.f3861a;
            byte[] bArr = longan.b;
            if (bArr == null || bArr.length <= 0) {
                strEncodeToString = "";
            } else {
                try {
                    strEncodeToString = Base64.encodeToString(bArr, 0);
                } catch (Exception unused) {
                    strEncodeToString = "";
                }
            }
            str = str3 + "|" + strEncodeToString + "|" + longan.c;
        }
        map.put("2010", str != null ? str : "");
        a(context, map);
    }

    public static Longan a() {
        Context context;
        synchronized (Ccatch.class) {
            context = Ccatch.f3917a;
        }
        String strB = b(context, "2010");
        if (TextUtils.isEmpty(strB)) {
            return null;
        }
        String[] strArrSplit = strB.split("\\|", 3);
        if (strArrSplit.length != 3) {
            return null;
        }
        try {
            return new Longan(strArrSplit[0], !TextUtils.isEmpty(strArrSplit[1]) ? Base64.decode(strArrSplit[1], 0) : null, Integer.parseInt(strArrSplit[2]));
        } catch (Exception unused) {
            return null;
        }
    }
}
