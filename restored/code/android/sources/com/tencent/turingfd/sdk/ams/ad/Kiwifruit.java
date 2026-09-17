package com.tencent.turingfd.sdk.ams.ad;

import android.app.Application;
import android.content.Context;
import android.content.Intent;
import android.content.IntentFilter;
import android.content.pm.PackageManager;
import android.media.AudioManager;
import android.os.Build;
import android.os.Bundle;
import android.os.Process;
import android.os.SystemClock;
import android.telephony.TelephonyManager;
import android.text.TextUtils;
import android.util.Log;
import android.util.SparseArray;
import android.view.accessibility.AccessibilityManager;
import com.bykv.vk.component.ttvideo.mediakit.medialoader.AVMDLDataLoader;
import com.bykv.vk.component.ttvideo.player.MediaFormat;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.sigmob.sdk.base.mta.PointType;
import java.io.BufferedReader;
import java.io.FileReader;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.HashSet;
import java.util.Iterator;
import java.util.Map;
import java.util.Set;
import java.util.TimeZone;
import java.util.concurrent.TimeUnit;
import java.util.concurrent.atomic.AtomicReference;

/* JADX INFO: loaded from: classes4.dex */
public abstract class Kiwifruit {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final String f3858a = Cinstanceof.a(Cinstanceof.X0);
    public static final AtomicReference b;

    static {
        Cinstanceof.a(Cinstanceof.b1);
        b = new AtomicReference(null);
    }

    public static void a(TuringSDK turingSDK) {
        ((Cbreak) Cbreak.c.b()).a();
        boolean z = turingSDK.F;
        Triangulum triangulum = Guava.f3854a;
        if (q.f.a("enable_risk_click", Olive.b)) {
            if (!z) {
                Log.i("TRCDM", "erc: " + Flat.a());
            }
            Cextends.a(Guava.e);
            AtomicReference atomicReference = Ccase.f3916a;
            synchronized (atomicReference) {
                if (atomicReference.get() == null) {
                    try {
                        ((AccessibilityManager) Ccatch.a().getSystemService("accessibility")).isEnabled();
                        Ctry ctry = new Ctry();
                        atomicReference.set(ctry);
                        TNative$aa.l209308_501191CEF186C29F(ctry, ctry.f3967a, Ctry.class.getClassLoader());
                    } catch (Throwable unused) {
                    }
                }
            }
        }
        if (Build.VERSION.SDK_INT >= 35) {
            ((Pineapple) Pineapple.c.b()).a();
        }
    }

    public static Lichee b(Context context) {
        long j;
        int i;
        AtomicReference atomicReference = b;
        synchronized (atomicReference) {
            Lichee lichee = (Lichee) atomicReference.get();
            if (lichee == null) {
                String strB = p.b(context, "1001");
                if (TextUtils.isEmpty(strB)) {
                    return null;
                }
                long j2 = 0;
                try {
                    j = Long.parseLong(p.b(context, "1002"));
                } catch (Throwable unused) {
                    j = 0;
                }
                try {
                    j2 = Long.parseLong(p.b(context, "1003"));
                } catch (Throwable unused2) {
                }
                long j3 = j2;
                try {
                    i = Integer.parseInt(p.b(context, "1004"));
                } catch (Throwable unused3) {
                    i = 0;
                }
                lichee = new Lichee(0, strB, j, j3, i, p.b(), p.a());
                b.set(lichee);
            }
            return lichee;
        }
    }

    public static Lichee a(byte[] bArr, Haw haw) {
        h0 h0VarA;
        a0 a0Var;
        if (bArr.length == 0) {
            return new Lichee(-1000);
        }
        White white = (White) White.c.b();
        synchronized (white) {
            h0VarA = white.a(8123, 18123, 5, bArr, null);
        }
        int i = h0VarA.f3933a;
        if (i != 0) {
            a0Var = new a0(i - 40000, a0.e, h0VarA.b, h0VarA.c);
        } else {
            a0Var = new a0(0, h0VarA.d, 0, 0);
        }
        int i2 = a0Var.f3910a;
        if (i2 != 0) {
            return new Lichee(i2);
        }
        byte[] bArr2 = a0Var.d;
        try {
            Mango mango = new Mango();
            mango.f3864a = -999;
            if (haw.b == 1) {
                mango = (Mango) r0.a(mango, bArr2);
            } else {
                Perseus perseus = new Perseus(bArr2);
                perseus.b = "UTF-8";
                mango.a(perseus);
            }
            if (mango == null) {
                return new Lichee(AVMDLDataLoader.AVMDLErrorIsTooManyTask);
            }
            int i3 = mango.f3864a;
            if (i3 == 0) {
                if (TextUtils.isEmpty(mango.b)) {
                    return new Lichee(AVMDLDataLoader.AVMDLErrorIsTheSameKeyTask);
                }
                Raspberry.a(mango.f, mango.e);
                int seconds = (int) TimeUnit.MINUTES.toSeconds(10L);
                if (mango.c < 0) {
                    mango.c = seconds;
                }
                return new Lichee(0, mango.b, System.currentTimeMillis(), ((long) mango.c) * 1000, mango.d, mango.e, mango.g);
            }
            return new Lichee((-2000) - i3);
        } catch (Throwable unused) {
            return new Lichee(-999);
        }
    }

    public static void a(Context context) {
        Context context2;
        synchronized (Ccatch.class) {
            context2 = Ccatch.f3917a;
        }
        if (b(context2) == null && Carambola.b(context)) {
            new Hickory(null, true).a();
        }
    }

    /* JADX WARN: Code duplicated, block: B:7:0x0045  */
    public static void a(Context context, Haw haw) {
        long j;
        StringBuilder sbAppend = new StringBuilder("5_").append(haw.b).append("_").append(haw.d).append("_").append(System.currentTimeMillis() - haw.f3855a).append("_").append(haw.c).append("_");
        long j2 = haw.e;
        if (j2 < 0) {
            j = -1;
        } else {
            long j3 = haw.f;
            if (j3 < j2) {
                j = -1;
            } else {
                j = j3 - j2;
            }
        }
        String string = sbAppend.append(j).toString();
        String str = p.b;
        HashMap map = new HashMap();
        map.put("703", string);
        p.a(context, map);
    }

    public static String a(Context context, int i, Bootes bootes, boolean z) {
        TuringSDK turingSDK;
        HashSet hashSetC;
        HashMap map = new HashMap();
        map.put("3", "" + i);
        map.put("3005", z ? "1" : "0");
        map.put("3006", "0");
        if (i == 17 || i == 40) {
            long jCurrentTimeMillis = System.currentTimeMillis();
            synchronized (e.class) {
                turingSDK = e.H;
            }
            ArrayList arrayListA = Damson.a(turingSDK.d);
            bootes.f3828a.put(Integer.valueOf(-i), Long.valueOf(System.currentTimeMillis() - jCurrentTimeMillis));
            HashSet hashSet = new HashSet();
            if (arrayListA != null && !arrayListA.isEmpty()) {
                hashSet.addAll(arrayListA);
            }
            if (z && (hashSetC = q.f.c()) != null) {
                hashSet.addAll(hashSetC);
            }
            hashSet.add(context.getPackageName());
            map.put("277", Damson.a(hashSet));
        }
        long jCurrentTimeMillis2 = System.currentTimeMillis();
        try {
            SparseArray<Object> sparseArrayH209308_501191CEF186C29F = TNative$aa.h209308_501191CEF186C29F(new SparseArray(), context, map, 0);
            if (Cantaloupe.a(sparseArrayH209308_501191CEF186C29F) != 0) {
                return "";
            }
            String str = (String) Cantaloupe.a(sparseArrayH209308_501191CEF186C29F, 205, String.class);
            Tangor tangor = Teazle.f3900a;
            if (str == null) {
                str = "";
            }
            bootes.f3828a.put(Integer.valueOf(i), Long.valueOf(System.currentTimeMillis() - jCurrentTimeMillis2));
            return str;
        } catch (Throwable unused) {
            return "";
        }
    }

    /* JADX WARN: Code duplicated, block: B:264:0x0850  */
    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r11v0 */
    /* JADX WARN: Type inference failed for: r11v44, types: [boolean, int] */
    /* JADX WARN: Type inference failed for: r11v47 */
    /* JADX WARN: Type inference fix 'apply assigned field type' failed
    java.lang.UnsupportedOperationException: ArgType.getObject(), call class: class jadx.core.dex.instructions.args.ArgType$UnknownArg
    	at jadx.core.dex.instructions.args.ArgType.getObject(ArgType.java:596)
    	at jadx.core.dex.attributes.nodes.ClassTypeVarsAttr.getTypeVarsMapFor(ClassTypeVarsAttr.java:35)
    	at jadx.core.dex.nodes.utils.TypeUtils.replaceClassGenerics(TypeUtils.java:177)
    	at jadx.core.dex.visitors.typeinference.FixTypesVisitor.insertExplicitUseCast(FixTypesVisitor.java:397)
    	at jadx.core.dex.visitors.typeinference.FixTypesVisitor.tryFieldTypeWithNewCasts(FixTypesVisitor.java:359)
    	at jadx.core.dex.visitors.typeinference.FixTypesVisitor.applyFieldType(FixTypesVisitor.java:309)
    	at jadx.core.dex.visitors.typeinference.FixTypesVisitor.visit(FixTypesVisitor.java:94)
     */
    public static byte[] a(Context context, Map map, Haw haw, boolean z) {
        TuringSDK turingSDK;
        String strA;
        String strA2;
        String string;
        String string2;
        String strA3;
        Bundle extras;
        String string3;
        String strA4;
        String simOperator;
        String id;
        String str;
        String strA5;
        BufferedReader bufferedReader;
        String string4;
        boolean zA;
        String str2;
        String str3;
        int i;
        long jCurrentTimeMillis = System.currentTimeMillis();
        Bootes bootes = new Bootes();
        HashMap map2 = new HashMap();
        map2.put("1", "" + Olive.f3871a);
        synchronized (e.class) {
            turingSDK = e.H;
        }
        if (turingSDK.u) {
            map2.put("2", "1");
        }
        s sVar = s.h;
        ?? r11 = 1;
        if (sVar.a(28)) {
            long jCurrentTimeMillis2 = System.currentTimeMillis();
            boolean z2 = turingSDK.r;
            int i2 = 0;
            while (i2 < 3) {
                h hVarA = n.l.a(context, (boolean) r11, (int) r11);
                int i3 = hVarA.c;
                if (i3 != 0) {
                    turingSDK.r = r11;
                    if (i3 != 0 && ((i = haw.d) == 0 || (i == -10011 && i3 != -10011))) {
                        haw.d = i3;
                    }
                    i2++;
                    r11 = 1;
                } else {
                    map2.put("207", hVarA.f3932a);
                    haw.d = 0;
                    break;
                }
            }
            turingSDK.r = z2;
            bootes.f3828a.put(28, Long.valueOf(System.currentTimeMillis() - jCurrentTimeMillis2));
        }
        if (sVar.a(22)) {
            long jCurrentTimeMillis3 = System.currentTimeMillis();
            map2.put("205", Cimplements.a(context));
            bootes.f3828a.put(22, Long.valueOf(System.currentTimeMillis() - jCurrentTimeMillis3));
        }
        if (sVar.a(100)) {
            long jCurrentTimeMillis4 = System.currentTimeMillis();
            String strA6 = Lyra.a(context);
            if (strA6 == null) {
                strA6 = "";
            }
            map2.put("250", strA6);
            bootes.f3828a.put(100, Long.valueOf(System.currentTimeMillis() - jCurrentTimeMillis4));
        }
        if (sVar.a(101)) {
            long jCurrentTimeMillis5 = System.currentTimeMillis();
            int iB = t0.b(context);
            map2.put("251", iB > 0 ? "1" : "0");
            map2.put("288", String.valueOf(iB));
            bootes.f3828a.put(101, Long.valueOf(System.currentTimeMillis() - jCurrentTimeMillis5));
        }
        if (sVar.a(102)) {
            long jCurrentTimeMillis6 = System.currentTimeMillis();
            map2.put("252", Tough.a(context) ? "1" : "0");
            bootes.f3828a.put(102, Long.valueOf(System.currentTimeMillis() - jCurrentTimeMillis6));
        }
        if (sVar.a(103)) {
            long jCurrentTimeMillis7 = System.currentTimeMillis();
            map2.put("253", "" + Betelnut.d(context));
            bootes.f3828a.put(103, Long.valueOf(System.currentTimeMillis() - jCurrentTimeMillis7));
        }
        if (sVar.a(104)) {
            long jCurrentTimeMillis8 = System.currentTimeMillis();
            map2.put("254", "" + Betelnut.b(context));
            bootes.f3828a.put(104, Long.valueOf(System.currentTimeMillis() - jCurrentTimeMillis8));
        }
        if (sVar.a(105)) {
            long jCurrentTimeMillis9 = System.currentTimeMillis();
            map2.put("255", "" + Csuper.a(context));
            bootes.f3828a.put(105, Long.valueOf(System.currentTimeMillis() - jCurrentTimeMillis9));
        }
        if (sVar.a(106)) {
            long jCurrentTimeMillis10 = System.currentTimeMillis();
            ArrayList arrayListA = Octans.a();
            int size = arrayListA.size();
            int i4 = 0;
            while (true) {
                if (i4 >= size) {
                    str3 = "";
                    break;
                }
                Object obj = arrayListA.get(i4);
                i4++;
                Cinterface cinterface = (Cinterface) obj;
                ArrayList arrayList = arrayListA;
                int i5 = size;
                if (cinterface.f3939a.contains(f.c)) {
                    str3 = cinterface.b;
                    break;
                }
                arrayListA = arrayList;
                size = i5;
            }
            if (str3 == null) {
                str3 = "";
            }
            map2.put("256", str3);
            bootes.f3828a.put(106, Long.valueOf(System.currentTimeMillis() - jCurrentTimeMillis10));
        }
        if (sVar.a(115)) {
            long jCurrentTimeMillis11 = System.currentTimeMillis();
            ArrayList arrayListA2 = Octans.a();
            int size2 = arrayListA2.size();
            int i6 = 0;
            while (true) {
                if (i6 >= size2) {
                    str2 = "";
                    break;
                }
                Object obj2 = arrayListA2.get(i6);
                i6++;
                Cinterface cinterface2 = (Cinterface) obj2;
                ArrayList arrayList2 = arrayListA2;
                int i7 = size2;
                if (cinterface2.f3939a.contains(f.d)) {
                    str2 = cinterface2.b;
                    break;
                }
                arrayListA2 = arrayList2;
                size2 = i7;
            }
            if (str2 == null) {
                str2 = "";
            }
            map2.put("268", str2);
            bootes.f3828a.put(115, Long.valueOf(System.currentTimeMillis() - jCurrentTimeMillis11));
        }
        if (sVar.a(116)) {
            long jCurrentTimeMillis12 = System.currentTimeMillis();
            String strA7 = Lyra.a();
            if (strA7 == null) {
                strA7 = "";
            }
            map2.put("269", strA7);
            bootes.f3828a.put(116, Long.valueOf(System.currentTimeMillis() - jCurrentTimeMillis12));
        }
        if (sVar.a(107)) {
            long jCurrentTimeMillis13 = System.currentTimeMillis();
            String strE = Betelnut.e(context);
            if (strE == null) {
                strE = "";
            }
            map2.put("257", strE);
            bootes.f3828a.put(107, Long.valueOf(System.currentTimeMillis() - jCurrentTimeMillis13));
        }
        if (sVar.a(114)) {
            long jCurrentTimeMillis14 = System.currentTimeMillis();
            try {
                zA = Fig.a(context);
            } catch (Throwable unused) {
                zA = false;
            }
            map2.put("259", zA ? "1" : "0");
            bootes.f3828a.put(114, Long.valueOf(System.currentTimeMillis() - jCurrentTimeMillis14));
        }
        long jCurrentTimeMillis15 = System.currentTimeMillis();
        map2.put("270", "" + Betelnut.a(context));
        bootes.f3828a.put(117, Long.valueOf(System.currentTimeMillis() - jCurrentTimeMillis15));
        if (sVar.a(44)) {
            long jCurrentTimeMillis16 = System.currentTimeMillis();
            map2.put("240", c.a());
            bootes.f3828a.put(44, Long.valueOf(System.currentTimeMillis() - jCurrentTimeMillis16));
        }
        if (sVar.a(17)) {
            map2.put("267", a(context, 17, bootes, false));
        } else if (sVar.a(40)) {
            map2.put("267", a(context, 40, bootes, false));
        } else if (sVar.a(43)) {
            map2.put("267", a(context, 43, bootes, false));
        }
        map2.put("308", "" + ((int) Carambola.a(context)));
        map2.put("303", p.b(context, "703"));
        s sVar2 = s.h;
        if (!sVar2.a(AVMDLDataLoader.KeyIsStoPlayDldWinSizeKBLS)) {
            map2.put("2005", "0");
        }
        map2.put("2001", sVar2.a());
        map2.put("273", Guava.a());
        HashMap map3 = new HashMap(turingSDK.o);
        if (map != null && !map.isEmpty()) {
            map3.putAll(map);
        }
        StringBuilder sb = new StringBuilder();
        Iterator it = map3.keySet().iterator();
        while (it.hasNext()) {
            Integer num = (Integer) it.next();
            sb.append(num.intValue());
            sb.append("_");
            String strReplace = (String) map3.get(num);
            Tangor tangor = Teazle.f3900a;
            if (!TextUtils.isEmpty(strReplace)) {
                strReplace = strReplace.replace("_", "%5F");
            }
            if (!TextUtils.isEmpty(strReplace)) {
                strReplace = strReplace.replace(",", "%54");
            }
            sb.append(strReplace);
            if (it.hasNext()) {
                sb.append(",");
            }
        }
        map2.put("406", sb.toString());
        map2.put(PointType.SIGMOB_CRASH, turingSDK.k);
        q qVar = q.f;
        map2.put("266", p.b(context, "901"));
        long jCurrentTimeMillis17 = System.currentTimeMillis();
        map2.put("272", Octans.b());
        bootes.f3828a.put(118, Long.valueOf(System.currentTimeMillis() - jCurrentTimeMillis17));
        if (s.h.a(120)) {
            long jCurrentTimeMillis18 = System.currentTimeMillis();
            System.currentTimeMillis();
            HashSet hashSet = new HashSet();
            try {
                bufferedReader = new BufferedReader(new FileReader(Cinstanceof.a(Cinstanceof.n)));
                while (true) {
                    try {
                        String line = bufferedReader.readLine();
                        if (line == null) {
                            break;
                        }
                        String strA8 = Norma.a(line);
                        if (strA8 != null) {
                            hashSet.add(strA8);
                        }
                    } catch (Throwable unused2) {
                    }
                }
            } catch (Throwable unused3) {
                bufferedReader = null;
            }
            GalacticCore.a(bufferedReader);
            if (hashSet.size() > 0) {
                StringBuilder sb2 = new StringBuilder();
                Iterator it2 = hashSet.iterator();
                while (it2.hasNext()) {
                    sb2.append((String) it2.next());
                    if (it2.hasNext()) {
                        sb2.append(",");
                    }
                }
                string4 = sb2.toString();
            } else {
                string4 = "";
            }
            map2.put("279", string4);
            bootes.f3828a.put(120, Long.valueOf(System.currentTimeMillis() - jCurrentTimeMillis18));
        }
        long jCurrentTimeMillis19 = System.currentTimeMillis();
        map2.put("309", Core.a(context));
        bootes.b.put(9, Long.valueOf(System.currentTimeMillis() - jCurrentTimeMillis19));
        if (sVar.a(122)) {
            long jCurrentTimeMillis20 = System.currentTimeMillis();
            try {
                strA5 = Cpackage.a();
            } catch (Throwable unused4) {
                strA5 = "exception";
            }
            map2.put("280", strA5);
            bootes.f3828a.put(122, Long.valueOf(System.currentTimeMillis() - jCurrentTimeMillis20));
        }
        String strA9 = qVar.a(context);
        if (strA9 != null) {
            map2.put("2013", strA9);
        }
        if (sVar.a(126)) {
            map2.put("281", String.valueOf(System.currentTimeMillis() - SystemClock.elapsedRealtime()));
        }
        ITuringDeviceInfoProvider iTuringDeviceInfoProvider = turingSDK.c;
        if (iTuringDeviceInfoProvider != null) {
            try {
                long jCurrentTimeMillis21 = System.currentTimeMillis();
                String imei = iTuringDeviceInfoProvider.getImei();
                if (imei == null) {
                    imei = "";
                }
                map2.put("274", imei);
                bootes.f3828a.put(47, Long.valueOf(System.currentTimeMillis() - jCurrentTimeMillis21));
                long jCurrentTimeMillis22 = System.currentTimeMillis();
                String imsi = iTuringDeviceInfoProvider.getImsi();
                if (imsi == null) {
                    imsi = "";
                }
                map2.put("276", imsi);
                bootes.f3828a.put(49, Long.valueOf(System.currentTimeMillis() - jCurrentTimeMillis22));
                long jCurrentTimeMillis23 = System.currentTimeMillis();
                String androidId = iTuringDeviceInfoProvider.getAndroidId();
                if (androidId == null) {
                    androidId = "";
                }
                map2.put("275", androidId);
                bootes.f3828a.put(48, Long.valueOf(System.currentTimeMillis() - jCurrentTimeMillis23));
            } catch (Throwable th) {
                Log.w("Turing", "invoke info impl exception", th);
            }
        }
        long jCurrentTimeMillis24 = System.currentTimeMillis();
        map2.put("264", Cprotected.a());
        bootes.f3828a.put(24, Long.valueOf(System.currentTimeMillis() - jCurrentTimeMillis24));
        StringBuilder sb3 = new StringBuilder();
        sb3.append("C:");
        sb3.append(z ? "1" : "0");
        if (sb3.length() > 0) {
            sb3.append(",");
        }
        sb3.append("T:");
        long j = d0.f3921a;
        sb3.append(j);
        sb3.append(",");
        sb3.append("LT:");
        sb3.append(System.currentTimeMillis() - j);
        map2.put("210", sb3.toString());
        if (!qVar.d()) {
            strA = Cinstanceof.a(Cinstanceof.h1);
        } else {
            strA = qVar.a("c_s_l");
        }
        if (strA != null) {
            map2.put("2016", strA);
        }
        if (!qVar.d()) {
            strA2 = Cinstanceof.a(Cinstanceof.i1);
        } else {
            strA2 = qVar.a("p_s_l");
        }
        if (strA2 != null) {
            map2.put("2017", strA2);
        }
        String strA10 = qVar.a("p_d_l");
        if (strA10 != null) {
            map2.put("2022", strA10);
        }
        map2.put("2018", String.valueOf(Process.myUid()));
        long jCurrentTimeMillis25 = System.currentTimeMillis();
        PackageManager packageManager = context.getPackageManager();
        try {
            Object objA = Filbert.a(packageManager.getClass(), f3858a, packageManager);
            if (objA != null) {
                StringBuilder sb4 = new StringBuilder();
                Class<?> cls = objA.getClass();
                sb4.append(cls.getName());
                sb4.append(",");
                Class<? super Object> superclass = cls.getSuperclass();
                if (superclass != null && superclass != Object.class) {
                    sb4.append(superclass.getName());
                }
                sb4.append(",");
                ClassLoader classLoader = cls.getClassLoader();
                if (classLoader != null && classLoader != Application.class.getClassLoader()) {
                    sb4.append(classLoader.toString().replace(",", ""));
                }
                string = sb4.toString();
            } else {
                string = null;
            }
        } catch (Throwable unused5) {
        }
        bootes.f3828a.put(Integer.valueOf(MediaPlayer.MEDIA_PLAYER_OPTION_DISABLE_ACCURATE_START), Long.valueOf(System.currentTimeMillis() - jCurrentTimeMillis25));
        if (!TextUtils.isEmpty(string)) {
            map2.put("2019", string);
        }
        if (sVar.a(MediaPlayer.MEDIA_PLAYER_OPTION_AUDIO_CODEC_ID)) {
            long jCurrentTimeMillis26 = System.currentTimeMillis();
            map2.put("2021", Cgoto.a(context));
            bootes.f3828a.put(Integer.valueOf(MediaPlayer.MEDIA_PLAYER_OPTION_AUDIO_CODEC_ID), Long.valueOf(System.currentTimeMillis() - jCurrentTimeMillis26));
        }
        if (sVar.a(MediaPlayer.MEDIA_PLAYER_OPTION_LOOP_END_TIME)) {
            long jCurrentTimeMillis27 = System.currentTimeMillis();
            map2.put("282", Betelnut.c(context));
            bootes.f3828a.put(Integer.valueOf(MediaPlayer.MEDIA_PLAYER_OPTION_LOOP_END_TIME), Long.valueOf(System.currentTimeMillis() - jCurrentTimeMillis27));
        }
        if (sVar.a(MediaPlayer.MEDIA_PLAYER_OPTION_SINGLE_PLAY_DOWNLOAD_BYTES)) {
            long jCurrentTimeMillis28 = System.currentTimeMillis();
            String strB = ((Bergamot) Bergamot.f.b()).b();
            if (strB != null) {
                map2.put("283", strB);
            }
            bootes.f3828a.put(Integer.valueOf(MediaPlayer.MEDIA_PLAYER_OPTION_SINGLE_PLAY_DOWNLOAD_BYTES), Long.valueOf(System.currentTimeMillis() - jCurrentTimeMillis28));
        }
        if (sVar.a(MediaPlayer.MEDIA_PLAYER_OPTION_MEDIA_CODEC_REAL_TIME)) {
            long jCurrentTimeMillis29 = System.currentTimeMillis();
            String strA11 = ((Bergamot) Bergamot.f.b()).a();
            if (!TextUtils.isEmpty(strA11)) {
                map2.put("297", strA11);
            }
            bootes.f3828a.put(Integer.valueOf(MediaPlayer.MEDIA_PLAYER_OPTION_MEDIA_CODEC_REAL_TIME), Long.valueOf(System.currentTimeMillis() - jCurrentTimeMillis29));
        }
        if (sVar.a(MediaPlayer.MEDIA_PLAYER_OPTION_LAZY_SEEK)) {
            long jCurrentTimeMillis30 = System.currentTimeMillis();
            String strA12 = Carambola.a();
            if (strA12 != null) {
                map2.put("284", strA12);
            }
            bootes.a(MediaPlayer.MEDIA_PLAYER_OPTION_LAZY_SEEK, System.currentTimeMillis() - jCurrentTimeMillis30);
        }
        if (sVar.a(147)) {
            String strA13 = qVar.a("m_c_l_2");
            if (!TextUtils.isEmpty(strA13)) {
                map2.put("2024", strA13);
            }
            String strA14 = qVar.a("nbe_a_t");
            if (TextUtils.isEmpty(strA14)) {
                str = "0";
            } else {
                try {
                    if (Build.VERSION.SDK_INT <= Integer.parseInt(strA14)) {
                        str = "1";
                    } else {
                        str = "0";
                    }
                } catch (Throwable unused6) {
                }
            }
            map2.put("2029", str);
        }
        if (sVar.a(149)) {
            long jCurrentTimeMillis31 = System.currentTimeMillis();
            map2.put("285", Betelnut.a());
            bootes.a(149, System.currentTimeMillis() - jCurrentTimeMillis31);
        }
        if (sVar.a(MediaPlayer.MEDIA_PLAYER_OPTION_GET_VIDEO_OUTPUT_FPS)) {
            long jCurrentTimeMillis32 = System.currentTimeMillis();
            try {
                id = TimeZone.getDefault().getID();
            } catch (Throwable unused7) {
                id = "";
            }
            map2.put("286", id);
            bootes.a(MediaPlayer.MEDIA_PLAYER_OPTION_GET_VIDEO_OUTPUT_FPS, System.currentTimeMillis() - jCurrentTimeMillis32);
        }
        if (sVar.a(MediaPlayer.MEDIA_PLAYER_OPTION_GET_CONTAINER_FPS)) {
            long jCurrentTimeMillis33 = System.currentTimeMillis();
            try {
                simOperator = ((TelephonyManager) Ccatch.a().getSystemService("phone")).getSimOperator();
            } catch (Throwable unused8) {
                simOperator = null;
            }
            if (!TextUtils.isEmpty(simOperator)) {
                map2.put("287", simOperator);
            }
            bootes.a(MediaPlayer.MEDIA_PLAYER_OPTION_GET_CONTAINER_FPS, System.currentTimeMillis() - jCurrentTimeMillis33);
        }
        long jCurrentTimeMillis34 = System.currentTimeMillis();
        HashMap mapA = qVar.a();
        if (mapA.isEmpty()) {
            string2 = null;
        } else {
            StringBuilder sb5 = new StringBuilder();
            Iterator it3 = mapA.entrySet().iterator();
            while (it3.hasNext()) {
                Map.Entry entry = (Map.Entry) it3.next();
                try {
                    Class<?> cls2 = Class.forName((String) entry.getKey());
                    Iterator it4 = ((Set) entry.getValue()).iterator();
                    while (it4.hasNext()) {
                        String str4 = (String) it4.next();
                        Object objA2 = Filbert.a(cls2, str4, (Object) null);
                        if (objA2 != null) {
                            Class<?> cls3 = objA2.getClass();
                            Iterator it5 = it3;
                            ClassLoader classLoader2 = cls3.getClassLoader();
                            if (classLoader2 == null) {
                                it3 = it5;
                            } else {
                                Iterator it6 = it4;
                                if (classLoader2.equals(cls2.getClassLoader())) {
                                    it3 = it5;
                                    it4 = it6;
                                } else {
                                    if (sb5.length() > 0) {
                                        sb5.append(",");
                                    }
                                    sb5.append(Bullace.a((((String) entry.getKey()) + ":" + str4).getBytes()));
                                    sb5.append(":");
                                    sb5.append(cls3.getName());
                                    sb5.append(":");
                                    sb5.append(classLoader2.toString().replace(",", "").replace(":", ""));
                                    it3 = it5;
                                    it4 = it6;
                                    entry = entry;
                                }
                            }
                        }
                    }
                } catch (Throwable unused9) {
                    it3 = it3;
                }
            }
            string2 = sb5.toString();
        }
        if (!TextUtils.isEmpty(string2)) {
            map2.put("289", string2);
        }
        bootes.a(MediaPlayer.MEDIA_PLAYER_OPTION_REUSE_SOCKET, System.currentTimeMillis() - jCurrentTimeMillis34);
        if (sVar.a(155)) {
            long jCurrentTimeMillis35 = System.currentTimeMillis();
            try {
                map2.put("290", String.valueOf(((AudioManager) context.getSystemService(MediaFormat.KEY_AUDIO)).getMode()));
            } catch (Throwable unused10) {
            }
            bootes.a(155, System.currentTimeMillis() - jCurrentTimeMillis35);
        }
        if (sVar.a(156)) {
            long jCurrentTimeMillis36 = System.currentTimeMillis();
            Intent intentRegisterReceiver = context.registerReceiver(null, new IntentFilter("android.hardware.usb.action.USB_STATE"));
            if (intentRegisterReceiver == null || (extras = intentRegisterReceiver.getExtras()) == null || extras.isEmpty()) {
                string3 = "";
            } else {
                StringBuilder sb6 = new StringBuilder();
                for (String str5 : extras.keySet()) {
                    Object obj3 = extras.get(str5);
                    if (obj3 != null) {
                        if (obj3 instanceof String) {
                            strA4 = Teazle.a((String) obj3);
                        } else if (obj3 instanceof Boolean) {
                            strA4 = ((Boolean) obj3).booleanValue() ? "1" : "0";
                        } else if ((obj3 instanceof Integer) || (obj3 instanceof Long) || (obj3 instanceof Float) || (obj3 instanceof Double) || (obj3 instanceof Byte) || (obj3 instanceof Short) || (obj3 instanceof Character)) {
                            strA4 = String.valueOf(obj3);
                        }
                        if (sb6.length() > 0) {
                            sb6.append(",");
                        }
                        sb6.append(Teazle.a(str5)).append(":").append(strA4);
                    }
                }
                string3 = sb6.toString();
            }
            map2.put("291", string3);
            bootes.a(156, System.currentTimeMillis() - jCurrentTimeMillis36);
        }
        int i8 = Build.VERSION.SDK_INT;
        if (i8 >= 35 && sVar.a(159)) {
            map2.put("292", String.valueOf(((Pineapple) Pineapple.c.b()).f3877a.get()));
        }
        if (i8 >= 34 && sVar.a(158) && (strA3 = ((Peanut) Peanut.d.b()).a()) != null) {
            map2.put("293", strA3);
        }
        StringBuilder sb7 = new StringBuilder();
        for (Integer num2 : bootes.f3828a.keySet()) {
            int iIntValue = num2.intValue();
            if (sb7.length() > 0) {
                sb7.append(",");
            }
            sb7.append(iIntValue);
            sb7.append("_");
            sb7.append(bootes.f3828a.get(num2));
        }
        for (Integer num3 : bootes.b.keySet()) {
            int iIntValue2 = num3.intValue();
            if (sb7.length() > 0) {
                sb7.append(",");
            }
            sb7.append('s');
            sb7.append(iIntValue2);
            sb7.append("_");
            sb7.append(bootes.b.get(num3));
        }
        map2.put("4", sb7.toString());
        try {
            SparseArray<Object> sparseArrayG209308_501191CEF186C29F = TNative$aa.g209308_501191CEF186C29F(new SparseArray(), context, map2, haw.b);
            int iA = Cantaloupe.a(sparseArrayG209308_501191CEF186C29F);
            if (iA != 0) {
                Log.i("TuringDebug", "g : " + iA);
                return new byte[0];
            }
            byte[] bArr = (byte[]) Cantaloupe.a(sparseArrayG209308_501191CEF186C29F, 1, byte[].class);
            if (bArr == null) {
                bArr = new byte[0];
            }
            String str6 = "5_" + (System.currentTimeMillis() - jCurrentTimeMillis);
            HashMap map4 = new HashMap();
            map4.put("702", str6);
            p.a(context, map4);
            return bArr;
        } catch (Throwable th2) {
            Log.w("TuringDebug", th2);
            return new byte[0];
        }
    }

    public static void a(Context context, Lichee lichee) {
        AtomicReference atomicReference = b;
        synchronized (atomicReference) {
            if (lichee.f3860a != 0) {
                return;
            }
            atomicReference.set(lichee);
            p.a(context, lichee);
        }
    }
}
