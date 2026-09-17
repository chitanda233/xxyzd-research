package com.tencent.turingfd.sdk.ams.ad;

import android.content.Context;
import android.content.res.Resources;
import android.media.MediaDrm;
import android.net.ConnectivityManager;
import android.net.NetworkInfo;
import android.net.Proxy;
import android.os.Build;
import android.os.Looper;
import android.os.Message;
import android.os.Process;
import android.os.SystemClock;
import android.text.TextUtils;
import android.util.Log;
import android.util.SparseArray;
import cn.thinkingdata.core.exception.TDHttpException;
import com.baidu.mobads.sdk.internal.cm;
import com.bykv.vk.component.ttvideo.ILivePlayer;
import com.bykv.vk.component.ttvideo.mediakit.medialoader.AVMDLDataLoader;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.kuaishou.weapon.p0.bg;
import com.kwad.sdk.core.response.model.SdkConfigData;
import com.sigmob.sdk.base.mta.PointType;
import java.io.File;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.HashSet;
import java.util.Iterator;
import java.util.LinkedHashSet;
import java.util.Locale;
import java.util.Map;
import java.util.Random;
import java.util.UUID;
import java.util.concurrent.ConcurrentHashMap;
import java.util.concurrent.FutureTask;
import java.util.concurrent.TimeUnit;
import java.util.concurrent.atomic.AtomicBoolean;
import java.util.concurrent.atomic.AtomicReference;

/* JADX INFO: loaded from: classes4.dex */
public final class n {
    public static final String i = Cinstanceof.a(Cinstanceof.Z0);
    public static final String j = Cinstanceof.a(Cinstanceof.a1);
    public static final String k = Cinstanceof.a(Cinstanceof.b1);
    public static final n l = new n();
    public static final long m = TimeUnit.MINUTES.toMillis(30);
    public static final int[] n = {0, 15, 30, 90, MediaPlayer.MEDIA_PLAYER_OPTION_GET_PLAY_WASTE_DATA, MediaPlayer.MEDIA_PLAYER_OPTION_ENABLE_DEMUXER_STALL, 600, 1200, 2400, 3200, 4800, 7200};

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public TuringSDK f3947a;
    public m b;
    public p d;
    public boolean c = false;
    public final Object e = new Object();
    public final AtomicReference f = new AtomicReference(null);
    public final AtomicReference g = new AtomicReference(Boolean.FALSE);
    public final AtomicReference h = new AtomicReference(null);

    /* JADX WARN: Code duplicated, block: B:78:0x017a  */
    /* JADX WARN: Code duplicated, block: B:81:0x0183  */
    /* JADX WARN: Code duplicated, block: B:84:0x018b  */
    public static void a(n nVar) {
        Context context;
        long jLongValue;
        Segment segmentA;
        String name;
        nVar.getClass();
        synchronized (Ccatch.class) {
            context = Ccatch.f3917a;
        }
        nVar.f3947a.getClass();
        s sVar = s.h;
        sVar.getClass();
        try {
            System.currentTimeMillis();
            sVar.a(context);
            System.currentTimeMillis();
            sVar.b();
        } catch (Throwable unused) {
        }
        if (sVar.a(39)) {
            nVar.d.getClass();
            if (TextUtils.isEmpty(p.b(context, "405"))) {
                StringBuilder sb = new StringBuilder();
                try {
                    String[] strArrSplit = new String(CanisMinor.a("/proc/self/maps")).split("\n");
                    HashSet hashSet = new HashSet();
                    for (String str : strArrSplit) {
                        String[] strArrSplit2 = str.split(" +");
                        if (strArrSplit2.length >= 2) {
                            String strTrim = strArrSplit2[strArrSplit2.length - 1].trim();
                            try {
                                File file = new File(strTrim);
                                if (file.exists()) {
                                    name = file.getName();
                                    if (name != null && name.contains("res") && name.endsWith(".apk") && !name.contains("mediatek") && !TextUtils.equals("/system/framework/framework-res.apk", strTrim) && !hashSet.contains(strTrim)) {
                                        hashSet.add(strTrim);
                                        String strA = CanisMajor.a(context, strTrim);
                                        if (strA != null && !TextUtils.equals(strA, "android.auto_generated_rro__") && !TextUtils.equals(strA, "android.overlay")) {
                                            if (sb.length() > 0) {
                                                sb.append(":");
                                            }
                                            sb.append(strA);
                                        }
                                    }
                                }
                            } catch (Throwable unused2) {
                                name = null;
                            }
                        }
                    }
                } catch (Throwable unused3) {
                }
                sb.append(",");
                String name2 = Resources.getSystem().getClass().getName();
                if (!TextUtils.equals("android.content.res.Resources", name2)) {
                    sb.append(name2);
                }
                String strReplace = sb.toString().replace("(\\|)|\\s*|\t|\r|\n", "");
                nVar.d.getClass();
                HashMap map = new HashMap();
                map.put("405", strReplace);
                p.a(context, map);
            }
        }
        if (nVar.f3947a.t && sVar.a(45)) {
            p pVar = nVar.d;
            int i2 = Sorosis.b;
            pVar.getClass();
            try {
                jLongValue = Long.valueOf(p.b(context, "902")).longValue();
            } catch (Throwable unused4) {
                jLongValue = 0;
            }
            if (Math.abs(jLongValue - System.currentTimeMillis()) >= Sorosis.f3893a) {
                if (TextUtils.isEmpty(p.b(context, "901"))) {
                    segmentA = Tangerine.a(context);
                    if (segmentA.f3890a != 0) {
                        segmentA = Tangerine.a();
                    }
                    if (segmentA.f3890a == 0) {
                        String str2 = segmentA.d;
                        HashMap map2 = new HashMap();
                        map2.put("901", str2);
                        p.a(context, map2);
                        String string = segmentA.toString();
                        HashMap map3 = new HashMap();
                        map3.put("904", string);
                        p.a(context, map3);
                    }
                } else {
                    long jAbs = Math.abs(jLongValue - System.currentTimeMillis());
                    q qVar = q.f;
                    long j2 = q.e;
                    String strA2 = qVar.a("sid_refresh_period");
                    if (strA2 != null) {
                        try {
                            j2 = Long.parseLong(strA2) * bg.s;
                        } catch (NumberFormatException unused5) {
                        }
                    }
                    if (jAbs >= j2) {
                        segmentA = Tangerine.a(context);
                        if (segmentA.f3890a != 0) {
                            segmentA = Tangerine.a();
                        }
                        if (segmentA.f3890a == 0) {
                            String str3 = segmentA.d;
                            HashMap map4 = new HashMap();
                            map4.put("901", str3);
                            p.a(context, map4);
                            String string2 = segmentA.toString();
                            HashMap map5 = new HashMap();
                            map5.put("904", string2);
                            p.a(context, map5);
                        }
                    }
                }
                long jCurrentTimeMillis = System.currentTimeMillis();
                HashMap map6 = new HashMap();
                map6.put("902", "" + jCurrentTimeMillis);
                p.a(context, map6);
            }
        }
        TuringSDK turingSDK = nVar.f3947a;
        if (turingSDK.q) {
            Lynx lynx = turingSDK.b;
            if (lynx == null) {
                lynx = e.I;
            }
            if (lynx.userAgreement()) {
                if (sVar.a(41)) {
                    ConcurrentHashMap concurrentHashMap = Blueberry.f3827a;
                    Ara.b.execute(new Blackberry(context));
                }
                nVar.a(Ccatch.a(), false, 0);
                Kiwifruit.a(context);
            }
        }
    }

    public final h b(Context context, boolean z, int i2) {
        h hVar;
        Context context2;
        if (!Carambola.b(context)) {
            return new h(-10012, 0, 0);
        }
        if (!this.f3947a.r) {
            synchronized (Ccatch.class) {
                context2 = Ccatch.f3917a;
            }
            long jCurrentTimeMillis = System.currentTimeMillis() / 1000;
            this.d.getClass();
            if (Math.abs(jCurrentTimeMillis - (p.a(context2, "109") / 1000)) <= 3600) {
                return new h(-30015, 0, 0);
            }
            if (!a(z)) {
                return new h(-10011, 0, 0);
            }
        }
        b(context);
        try {
            hVar = a(context, i2);
        } catch (Throwable th) {
            Log.w("TuringFdJava", th);
            hVar = new h(-10015, 0, 0);
        }
        a(context, hVar, i2);
        return hVar;
    }

    public final h c(Context context) {
        h hVarA;
        synchronized (this.f) {
            hVarA = (h) this.f.get();
            if (hVarA == null) {
                hVarA = this.d != null ? p.a(context) : new h(1, 0, 0);
                this.f.set(hVarA);
            }
        }
        return hVarA;
    }

    public final void b(Context context) {
        Context context2;
        p pVar = this.d;
        synchronized (Ccatch.class) {
            context2 = Ccatch.f3917a;
        }
        pVar.getClass();
        Triangulum triangulumB = p.b(context2);
        triangulumB.a(Long.valueOf(System.currentTimeMillis()));
        p pVar2 = this.d;
        Context contextA = Ccatch.a();
        pVar2.getClass();
        StringBuilder sb = new StringBuilder();
        for (int i2 = 0; i2 < triangulumB.b.size(); i2++) {
            sb.append(triangulumB.b.get(i2));
            if (i2 != triangulumB.b.size() - 1) {
                sb.append("_");
            }
        }
        String string = sb.toString();
        HashMap map = new HashMap();
        map.put(PointType.SIGMOB_CRASH, string);
        p.a(contextA, map);
        a(context);
        if (q.f.a("e_b_d", false)) {
            SparseArray sparseArray = new SparseArray();
            TNative$aa.c209308_501191CEF186C29F(sparseArray, context);
            Cantaloupe.a(sparseArray);
        }
    }

    public final void a(Context context, HashMap map) {
        String strA;
        String str;
        s sVar = s.h;
        q qVar = q.f;
        if (!sVar.a(41)) {
            map.put("2003", "0");
        } else {
            long jCurrentTimeMillis = System.currentTimeMillis();
            map.put("100", Blueberry.a(context).f3829a);
            Caelum.f3830a.put(20, Long.valueOf(System.currentTimeMillis() - jCurrentTimeMillis));
        }
        ITuringDeviceInfoProvider iTuringDeviceInfoProvider = this.f3947a.c;
        int i2 = 0;
        if (iTuringDeviceInfoProvider != null) {
            Object obj = new Object();
            AtomicBoolean atomicBoolean = new AtomicBoolean(false);
            long jCurrentTimeMillis2 = System.currentTimeMillis();
            new l(atomicBoolean, map, iTuringDeviceInfoProvider, obj).start();
            synchronized (obj) {
                try {
                    obj.wait(1000L);
                } catch (InterruptedException unused) {
                }
            }
            if (System.currentTimeMillis() - jCurrentTimeMillis2 > 1000) {
                Log.w("Turing", "invoke info impl timeout");
            }
            atomicBoolean.set(true);
        }
        map.put("264", Cprotected.a());
        if (sVar.a(22)) {
            map.put("205", Cimplements.a(context));
            Long lValueOf = Long.valueOf("" + Cimplements.f);
            lValueOf.getClass();
            Caelum.f3830a.put(8, lValueOf);
        }
        if (!sVar.a(AVMDLDataLoader.KeyIsStoPlayDldWinSizeKBLS)) {
            map.put("2005", "0");
        }
        if (!sVar.a(AVMDLDataLoader.KeyIsStoRingBufferSizeKB)) {
            map.put("2006", "0");
        }
        map.put("266", p.b(context, "901"));
        if (sVar.a(115)) {
            ArrayList arrayListA = Octans.a();
            int size = arrayListA.size();
            int i3 = 0;
            while (true) {
                if (i3 >= size) {
                    str = "";
                    break;
                }
                Object obj2 = arrayListA.get(i3);
                i3++;
                Cinterface cinterface = (Cinterface) obj2;
                if (cinterface.f3939a.contains(f.d)) {
                    str = cinterface.b;
                    break;
                }
            }
            if (str == null) {
                str = "";
            }
            map.put("268", str);
        }
        if (sVar.a(116)) {
            String strA2 = Lyra.a();
            if (strA2 == null) {
                strA2 = "";
            }
            map.put("269", strA2);
        }
        if (sVar.a(117)) {
            map.put("270", "" + Betelnut.a(context));
        }
        if (sVar.a(46)) {
            StringBuilder sb = new StringBuilder("");
            LinkedHashSet linkedHashSet = Crux.f3842a;
            if (linkedHashSet.isEmpty()) {
                linkedHashSet.add(Cinstanceof.a(Cinstanceof.R0));
                linkedHashSet.add(Cinstanceof.a(Cinstanceof.S0));
                linkedHashSet.add(Cinstanceof.a(Cinstanceof.T0));
                linkedHashSet.add(Cinstanceof.a(Cinstanceof.U0));
                linkedHashSet.add(Cinstanceof.a(Cinstanceof.V0));
                linkedHashSet.add(Cinstanceof.a(Cinstanceof.W0));
            }
            Iterator it = linkedHashSet.iterator();
            int i4 = 0;
            while (it.hasNext()) {
                try {
                    Class.forName((String) it.next());
                    i2 |= 1 << i4;
                } catch (Throwable unused2) {
                }
                i4++;
            }
            map.put("271", sb.append(i2).toString());
        }
        if (sVar.a(118)) {
            map.put("272", "" + Octans.b());
        }
        if (sVar.a(17) || sVar.a(40)) {
            ArrayList arrayListA2 = Damson.a(this.f3947a.d);
            HashSet hashSet = new HashSet();
            if (arrayListA2 != null && !arrayListA2.isEmpty()) {
                hashSet.addAll(arrayListA2);
            }
            HashSet hashSetC = qVar.c();
            if (hashSetC != null) {
                hashSet.addAll(hashSetC);
            }
            hashSet.add(context.getPackageName());
            map.put("277", Damson.a(hashSet));
        }
        if (sVar.a(122)) {
            try {
                strA = Cpackage.a();
            } catch (Throwable unused3) {
                strA = "exception";
            }
            map.put("280", strA);
        }
        if (sVar.a(126)) {
            map.put("281", String.valueOf(System.currentTimeMillis() - SystemClock.elapsedRealtime()));
        }
        String strA3 = qVar.a("x_l2_p_i");
        if (strA3 != null) {
            map.put("2014", strA3);
        }
        String strA4 = qVar.a("x_u_p_i");
        if (strA4 != null) {
            map.put("2015", strA4);
        }
        String strA5 = qVar.a(context);
        if (strA5 != null) {
            map.put("2013", strA5);
        }
    }

    /* JADX WARN: Code duplicated, block: B:240:0x06c2  */
    /* JADX WARN: Code duplicated, block: B:311:0x0150 A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:48:0x014d  */
    /* JADX WARN: Code duplicated, block: B:52:0x015a A[Catch: all -> 0x01c8, TryCatch #5 {, blocks: (B:50:0x0150, B:52:0x015a, B:53:0x016e), top: B:311:0x0150 }] */
    /* JADX WARN: Code duplicated, block: B:56:0x017b A[Catch: all -> 0x01c0, TryCatch #0 {all -> 0x01c0, blocks: (B:54:0x016f, B:56:0x017b, B:58:0x017f, B:61:0x0188, B:62:0x0190, B:66:0x01a0, B:67:0x01b8), top: B:301:0x016f }] */
    /* JADX WARN: Code duplicated, block: B:62:0x0190 A[Catch: all -> 0x01c0, TryCatch #0 {all -> 0x01c0, blocks: (B:54:0x016f, B:56:0x017b, B:58:0x017f, B:61:0x0188, B:62:0x0190, B:66:0x01a0, B:67:0x01b8), top: B:301:0x016f }] */
    /* JADX WARN: Code duplicated, block: B:64:0x019b  */
    /* JADX WARN: Code duplicated, block: B:65:0x019e  */
    /* JADX WARN: Code duplicated, block: B:67:0x01b8 A[Catch: all -> 0x01c0, TRY_LEAVE, TryCatch #0 {all -> 0x01c0, blocks: (B:54:0x016f, B:56:0x017b, B:58:0x017f, B:61:0x0188, B:62:0x0190, B:66:0x01a0, B:67:0x01b8), top: B:301:0x016f }] */
    public final h a(Context context, int i2) {
        long j2;
        long j3;
        Map<Integer, String> features;
        int i3;
        z zVar;
        h hVar;
        boolean zA;
        String str;
        String string;
        long j4;
        FutureTask futureTask;
        Centaurus centaurus;
        String str2;
        s sVar = s.h;
        sVar.getClass();
        long jCurrentTimeMillis = 0;
        if (!q.f.d()) {
            try {
                long jCurrentTimeMillis2 = System.currentTimeMillis();
                sVar.a(context);
                jCurrentTimeMillis = System.currentTimeMillis() - jCurrentTimeMillis2;
                sVar.b();
            } catch (Throwable unused) {
            }
        }
        long jCurrentTimeMillis3 = System.currentTimeMillis();
        String str3 = f.f3927a;
        long jCurrentTimeMillis4 = System.currentTimeMillis();
        Caelum.f3830a.clear();
        HashMap map = new HashMap();
        map.put("1", "" + Olive.f3871a);
        TuringSDK turingSDK = this.f3947a;
        if (turingSDK != null && turingSDK.u) {
            map.put("2", "1");
        }
        TuringSDK turingSDK2 = this.f3947a;
        map.put(PointType.ANTI_SPAM, TextUtils.isEmpty(turingSDK2.p) ? "" : turingSDK2.p);
        this.d.getClass();
        map.put("207", p.a(context).f3932a);
        TuringSDK turingSDK3 = this.f3947a;
        map.put("209", TextUtils.isEmpty(turingSDK3.g) ? "" : turingSDK3.g);
        map.put("210", Cvolatile.a(context, this.f3947a.s, i2, this.d));
        map.put("2001", sVar.a());
        q qVar = q.f;
        int i4 = Olive.f3871a;
        if ((i4 == 105668 || i4 == 105928) && !sVar.a(17) && !sVar.a(18)) {
            map.put("1001", "2");
        }
        StringBuilder sb = new StringBuilder("");
        String strA = qVar.a("m_p_s");
        if (strA == null) {
            j2 = 300;
        } else {
            try {
                j2 = Long.parseLong(strA);
            } catch (NumberFormatException unused2) {
                j2 = 300;
            }
        }
        map.put("2012", sb.append((int) j2).toString());
        if (sVar.a(MediaPlayer.MEDIA_PLAYER_OPTION_SET_PIPE_DECLARE_LENGTH) && context.checkPermission(k, Process.myPid(), Process.myUid()) == 0) {
            map.put("501", "1");
        }
        if (sVar.a(MediaPlayer.MEDIA_PLAYER_OPTION_SEEK_END_ENABLE)) {
            if (context.checkPermission(i, Process.myPid(), Process.myUid()) != 0) {
                try {
                    if (context.getPackageManager().getApplicationInfo(context.getPackageName(), 128).metaData.containsKey(j)) {
                        synchronized (this.h) {
                            futureTask = (FutureTask) this.h.get();
                            if (futureTask == null) {
                                futureTask = new FutureTask(new k());
                                Ara.b.submit(futureTask);
                                this.h.set(futureTask);
                            }
                            centaurus = (Centaurus) futureTask.get(1L, TimeUnit.SECONDS);
                            if (centaurus != null) {
                                if (!centaurus.b) {
                                    StringBuilder sb2 = new StringBuilder();
                                    if (centaurus.b) {
                                        str2 = "1";
                                    } else {
                                        str2 = "0";
                                    }
                                    map.put("2020", sb2.append(str2).append(",").append(centaurus.f3835a).toString());
                                } else {
                                    StringBuilder sb3 = new StringBuilder();
                                    if (centaurus.b) {
                                        str2 = "1";
                                    } else {
                                        str2 = "0";
                                    }
                                    map.put("2020", sb3.append(str2).append(",").append(centaurus.f3835a).toString());
                                }
                            } else {
                                map.put("2020", "-1");
                            }
                        }
                    } else {
                        map.put("2020", "-2");
                    }
                } catch (Throwable unused3) {
                }
            } else {
                synchronized (this.h) {
                    futureTask = (FutureTask) this.h.get();
                    if (futureTask == null) {
                        futureTask = new FutureTask(new k());
                        Ara.b.submit(futureTask);
                        this.h.set(futureTask);
                    }
                }
                try {
                    centaurus = (Centaurus) futureTask.get(1L, TimeUnit.SECONDS);
                    if (centaurus != null) {
                        if (!centaurus.b && !qVar.a("ig_g_a_l", false)) {
                            map.put("2020", "1");
                        } else {
                            StringBuilder sb4 = new StringBuilder();
                            if (centaurus.b) {
                                str2 = "1";
                            } else {
                                str2 = "0";
                            }
                            map.put("2020", sb4.append(str2).append(",").append(centaurus.f3835a).toString());
                        }
                    } else {
                        map.put("2020", "-1");
                    }
                } catch (Throwable unused4) {
                    map.put("2020", "-3");
                }
            }
        }
        int i5 = 2;
        if (sVar.a(MediaPlayer.MEDIA_PLAYER_OPTION_SPADE)) {
            String strA2 = q.f.a("d_i_l");
            if (strA2 == null) {
                strA2 = q.d;
            }
            if (TextUtils.isEmpty(strA2)) {
                j3 = jCurrentTimeMillis;
                string = null;
            } else {
                StringBuilder sb5 = new StringBuilder();
                String[] strArrSplit = strA2.split(",");
                int length = strArrSplit.length;
                int i6 = 0;
                while (i6 < length) {
                    String[] strArrSplit2 = strArrSplit[i6].split(":");
                    if (strArrSplit2.length != i5) {
                        j4 = jCurrentTimeMillis;
                    } else {
                        try {
                            j4 = jCurrentTimeMillis;
                            try {
                                String strA3 = a(Long.parseLong(strArrSplit2[0], 16), Long.parseLong(strArrSplit2[1], 16));
                                if (!TextUtils.isEmpty(strA3)) {
                                    if (sb5.length() > 0) {
                                        sb5.append(",");
                                    }
                                    sb5.append(strA3);
                                }
                            } catch (Throwable unused5) {
                            }
                        } catch (Throwable unused6) {
                            j4 = jCurrentTimeMillis;
                        }
                    }
                    i6++;
                    jCurrentTimeMillis = j4;
                    i5 = 2;
                }
                j3 = jCurrentTimeMillis;
                string = sb5.toString();
            }
            if (!TextUtils.isEmpty(string)) {
                map.put("2023", string);
            } else {
                map.put("2023", "");
            }
        } else {
            j3 = jCurrentTimeMillis;
        }
        a(context, map);
        s sVar2 = s.h;
        if (sVar2.a(39)) {
            this.d.getClass();
            map.put("239", p.b(context, "405"));
        }
        if (sVar2.a(100)) {
            long jCurrentTimeMillis5 = System.currentTimeMillis();
            String strA4 = Lyra.a(context);
            if (strA4 == null) {
                strA4 = "";
            }
            map.put("250", strA4);
            Caelum.f3830a.put(30, Long.valueOf(System.currentTimeMillis() - jCurrentTimeMillis5));
        }
        if (sVar2.a(101)) {
            long jCurrentTimeMillis6 = System.currentTimeMillis();
            int iB = t0.b(context);
            map.put("251", iB > 0 ? "1" : "0");
            map.put("288", String.valueOf(iB));
            Caelum.f3830a.put(31, Long.valueOf(System.currentTimeMillis() - jCurrentTimeMillis6));
        }
        if (sVar2.a(102)) {
            map.put("252", Tough.a(context) ? "1" : "0");
        }
        if (sVar2.a(103)) {
            map.put("253", "" + Betelnut.d(context));
        }
        if (sVar2.a(104)) {
            map.put("254", "" + Betelnut.b(context));
        }
        if (sVar2.a(105)) {
            map.put("255", "" + Csuper.a(context));
        }
        if (sVar2.a(106)) {
            long jCurrentTimeMillis7 = System.currentTimeMillis();
            ArrayList arrayListA = Octans.a();
            int size = arrayListA.size();
            int i7 = 0;
            while (true) {
                if (i7 >= size) {
                    str = "";
                    break;
                }
                Object obj = arrayListA.get(i7);
                int i8 = i7 + 1;
                Cinterface cinterface = (Cinterface) obj;
                if (cinterface.f3939a.contains(f.c)) {
                    str = cinterface.b;
                    break;
                }
                i7 = i8;
            }
            if (str == null) {
                str = "";
            }
            map.put("256", str);
            Caelum.f3830a.put(32, Long.valueOf(System.currentTimeMillis() - jCurrentTimeMillis7));
        }
        if (sVar2.a(107)) {
            String strE = Betelnut.e(context);
            if (strE == null) {
                strE = "";
            }
            map.put("257", strE);
        }
        if (sVar2.a(114)) {
            long jCurrentTimeMillis8 = System.currentTimeMillis();
            try {
                zA = Fig.a(context);
            } catch (Throwable unused7) {
                zA = false;
            }
            map.put("259", zA ? "1" : "0");
            Caelum.f3830a.put(41, Long.valueOf(System.currentTimeMillis() - jCurrentTimeMillis8));
        }
        if (sVar2.a(44)) {
            long jCurrentTimeMillis9 = System.currentTimeMillis();
            map.put("240", c.a());
            Caelum.f3830a.put(42, Long.valueOf(System.currentTimeMillis() - jCurrentTimeMillis9));
        }
        if (sVar2.a(MediaPlayer.MEDIA_PLAYER_OPTION_LOOP_END_TIME)) {
            map.put("282", Betelnut.c(context));
        }
        map.put("403", "" + this.f3947a.m);
        map.put(PointType.SIGMOB_CRASH, this.f3947a.k);
        map.put(cm.b, this.f3947a.l);
        map.put(PointType.GDPR_CONSENT, this.f3947a.n);
        this.f3947a.getClass();
        map.put("405", null);
        Map map2 = this.f3947a.o;
        StringBuilder sb6 = new StringBuilder();
        Iterator it = map2.keySet().iterator();
        while (it.hasNext()) {
            Integer num = (Integer) it.next();
            sb6.append(num.intValue());
            sb6.append("_");
            String strReplace = (String) map2.get(num);
            Tangor tangor = Teazle.f3900a;
            if (!TextUtils.isEmpty(strReplace)) {
                strReplace = strReplace.replace("_", "%5F");
            }
            if (!TextUtils.isEmpty(strReplace)) {
                strReplace = strReplace.replace(",", "%54");
            }
            sb6.append(strReplace);
            if (it.hasNext()) {
                sb6.append(",");
            }
        }
        map.put("406", sb6.toString());
        this.d.getClass();
        map.put("302", p.b(context, "201"));
        this.d.getClass();
        map.put("303", p.b(context, "202"));
        this.d.getClass();
        map.put("305", p.b(context, "203"));
        map.put("308", "" + ((int) Carambola.a(context)));
        this.d.getClass();
        map.put("309", p.b(context, cm.b));
        this.d.getClass();
        map.put("310", p.b(context, "205"));
        ITuringIoTFeatureMap iTuringIoTFeatureMap = this.f3947a.e;
        if (iTuringIoTFeatureMap == null || (features = iTuringIoTFeatureMap.getFeatures(context)) == null || features.isEmpty()) {
            features = null;
        }
        try {
            SparseArray<Object> sparseArrayA209308_501191CEF186C29F = TNative$aa.a209308_501191CEF186C29F(new SparseArray(), context, map, features, 0);
            p pVar = this.d;
            String str4 = (System.currentTimeMillis() - jCurrentTimeMillis4) + "_1";
            pVar.getClass();
            HashMap map3 = new HashMap();
            map3.put("201", str4);
            pVar.a(context, map3, false);
            int iA = Cantaloupe.a(sparseArrayA209308_501191CEF186C29F);
            byte[] bArr = (byte[]) Cantaloupe.a(sparseArrayA209308_501191CEF186C29F, 1, byte[].class);
            if (bArr == null) {
                bArr = new byte[0];
            }
            StringBuilder sb7 = new StringBuilder();
            i3 = 2;
            String str5 = (String) Cantaloupe.a(sparseArrayA209308_501191CEF186C29F, 2, String.class);
            Tangor tangor2 = Teazle.f3900a;
            if (str5 == null) {
                str5 = "";
            }
            StringBuilder sbAppend = sb7.append(str5);
            StringBuilder sb8 = new StringBuilder();
            for (Integer num2 : Caelum.f3830a.keySet()) {
                int iIntValue = num2.intValue();
                sb8.append(",");
                sb8.append(iIntValue);
                sb8.append("_");
                sb8.append(Caelum.f3830a.get(num2));
            }
            String string2 = sbAppend.append(sb8.toString()).toString();
            p pVar2 = this.d;
            pVar2.getClass();
            HashMap map4 = new HashMap();
            map4.put("205", string2);
            pVar2.a(context, map4, false);
            p pVar3 = this.d;
            long length2 = bArr.length;
            pVar3.getClass();
            HashMap map5 = new HashMap();
            map5.put("203", "" + length2 + "_1");
            pVar3.a(context, map5, false);
            if (iA != 0) {
                zVar = new z(iA, z.c);
            } else if (bArr.length == 0) {
                zVar = new z(-10003, z.c);
            } else {
                zVar = new z(0, bArr);
            }
        } catch (Throwable unused8) {
            i3 = 2;
            zVar = new z(-10006, z.c);
        }
        z zVar2 = zVar;
        long jCurrentTimeMillis10 = System.currentTimeMillis() - jCurrentTimeMillis3;
        int i9 = zVar2.f3973a;
        if (i9 != 0) {
            return new h(i9, 0, 0);
        }
        long jCurrentTimeMillis11 = System.currentTimeMillis();
        a0 a0VarA = w.a(1, zVar2.b, 8117, 18117, null);
        try {
            NetworkInfo activeNetworkInfo = ((ConnectivityManager) context.getSystemService("connectivity")).getActiveNetworkInfo();
            if (activeNetworkInfo == null || !(activeNetworkInfo.getState() == NetworkInfo.State.CONNECTING || activeNetworkInfo.getState() == NetworkInfo.State.CONNECTED)) {
                i3 = -1;
            } else if (activeNetworkInfo.getType() == 1) {
                i3 = 0;
            } else if (activeNetworkInfo.getType() != 0) {
                i3 = 3;
            } else if (Proxy.getDefaultHost() == null && Proxy.getHost(context) == null) {
                i3 = 1;
            }
        } catch (Throwable th) {
            String message = th.getMessage();
            if (message == null || !message.contains("ACCESS_NETWORK_STATE")) {
                i3 = -1;
            }
        }
        String str6 = i3 + "_" + (System.currentTimeMillis() - jCurrentTimeMillis11) + "_" + j3 + "_1_" + zVar2.b.length + "_" + jCurrentTimeMillis10 + "_" + (System.currentTimeMillis() - jCurrentTimeMillis3);
        p pVar4 = this.d;
        pVar4.getClass();
        HashMap map6 = new HashMap();
        map6.put("202", str6);
        pVar4.a(context, map6, false);
        int i10 = a0VarA.f3910a;
        if (i10 != 0) {
            return new h(i10, a0VarA.b, a0VarA.c);
        }
        byte[] bArr2 = a0VarA.d;
        String str7 = f.f3927a;
        try {
            SparseArray<Object> sparseArrayB209308_501191CEF186C29F = TNative$aa.b209308_501191CEF186C29F(new SparseArray(), bArr2, new HashMap(), 0);
            int iA2 = Cantaloupe.a(sparseArrayB209308_501191CEF186C29F);
            if (iA2 != 0) {
                return new h(iA2, 0, 0);
            }
            Integer num3 = (Integer) Cantaloupe.a(sparseArrayB209308_501191CEF186C29F, 102, Integer.class);
            if (num3 == null) {
                return new h(-30000, 0, 0);
            }
            if (num3.intValue() < 0) {
                hVar = new h(num3.intValue() - 30000, 0, 0);
            } else {
                String str8 = (String) Cantaloupe.a(sparseArrayB209308_501191CEF186C29F, 101, String.class);
                Tangor tangor3 = Teazle.f3900a;
                if (str8 == null) {
                    str8 = "";
                }
                if (TextUtils.isEmpty(str8)) {
                    hVar = new h(num3.intValue() - 10010, 0, 0);
                } else {
                    String str9 = (String) Cantaloupe.a(sparseArrayB209308_501191CEF186C29F, 104, String.class);
                    if (str9 == null) {
                        str9 = "";
                    }
                    String str10 = (String) Cantaloupe.a(sparseArrayB209308_501191CEF186C29F, 105, String.class);
                    if (str10 == null) {
                        str10 = "";
                    }
                    String str11 = (String) Cantaloupe.a(sparseArrayB209308_501191CEF186C29F, 106, String.class);
                    if (str11 == null) {
                        str11 = "";
                    }
                    Integer numValueOf = (Integer) Cantaloupe.a(sparseArrayB209308_501191CEF186C29F, 107, Integer.class);
                    String str12 = (String) Cantaloupe.a(sparseArrayB209308_501191CEF186C29F, 108, String.class);
                    if (str12 == null) {
                        str12 = "";
                    }
                    if (numValueOf == null || numValueOf.intValue() < 3600) {
                        numValueOf = Integer.valueOf(SdkConfigData.DEFAULT_REQUEST_INTERVAL);
                    }
                    long jCurrentTimeMillis12 = (System.currentTimeMillis() / 1000) + ((long) numValueOf.intValue());
                    g gVar = new g();
                    gVar.b = jCurrentTimeMillis12;
                    gVar.f3930a = str8;
                    gVar.c = str9;
                    gVar.d = str10;
                    gVar.e = str11;
                    gVar.f = str12;
                    h hVar2 = new h(gVar);
                    this.d.getClass();
                    HashMap map7 = new HashMap();
                    map7.put(PointType.ANTI_SPAM, hVar2.f3932a);
                    map7.put(PointType.ANTI_SPAM_TOUCH, "" + hVar2.b);
                    if (!TextUtils.isEmpty(hVar2.d)) {
                        map7.put("104", hVar2.d);
                    }
                    if (!TextUtils.isEmpty(hVar2.e)) {
                        map7.put("105", hVar2.e);
                    }
                    if (!TextUtils.isEmpty(hVar2.f)) {
                        map7.put("106", hVar2.f);
                    }
                    if (!TextUtils.isEmpty(hVar2.g)) {
                        map7.put("110", hVar2.g);
                    }
                    p.a(context, map7);
                    p pVar5 = this.d;
                    long jIntValue = numValueOf.intValue();
                    pVar5.getClass();
                    String str13 = "" + jIntValue;
                    HashMap map8 = new HashMap();
                    map8.put(PointType.WIND_ACTIVE, str13);
                    p.a(context, map8);
                    String str14 = "" + (System.currentTimeMillis() / 1000);
                    HashMap map9 = new HashMap();
                    map9.put("108", str14);
                    p.a(context, map9);
                    return hVar2;
                }
            }
            return hVar;
        } catch (Throwable unused9) {
            return new h(-10007, 0, 0);
        }
    }

    public final void a(Context context, h hVar, int i2) {
        long jLongValue;
        Context context2;
        if (hVar.c == -30015) {
            p pVar = this.d;
            long jCurrentTimeMillis = System.currentTimeMillis();
            pVar.getClass();
            HashMap map = new HashMap();
            map.put("109", "" + jCurrentTimeMillis);
            p.a(context, map);
        } else {
            this.d.getClass();
            if (p.a(context, "109") != 0) {
                this.d.getClass();
                HashMap map2 = new HashMap();
                map2.put("109", "0");
                p.a(context, map2);
            }
        }
        this.d.getClass();
        try {
            jLongValue = Long.valueOf(p.b(context, PointType.GDPR_CONSENT)).longValue();
        } catch (Throwable unused) {
            jLongValue = 0;
        }
        if (hVar.c < 0) {
            long j2 = jLongValue + 1;
            this.d.getClass();
            if (j2 >= Long.MAX_VALUE) {
                j2 = Long.MAX_VALUE;
            }
            HashMap map3 = new HashMap();
            map3.put(PointType.GDPR_CONSENT, "" + j2);
            p.a(context, map3);
        } else if (jLongValue != 0) {
            this.d.getClass();
            HashMap map4 = new HashMap();
            map4.put(PointType.GDPR_CONSENT, "0");
            p.a(context, map4);
        }
        this.d.getClass();
        if (!TextUtils.isEmpty(p.b(context, cm.b))) {
            this.d.getClass();
            HashMap map5 = new HashMap();
            map5.put(cm.b, "");
            p.a(context, map5);
        }
        if (hVar.c == 0) {
            p pVar2 = this.d;
            String str = i0.f3935a;
            long jC = p.c();
            if (jC == 0) {
                pVar2.getClass();
                synchronized (Ccatch.class) {
                    context2 = Ccatch.f3917a;
                }
                HashMap map6 = new HashMap();
                map6.put("503", "1");
                p.a(context2, map6);
            } else if (jC == -1) {
                pVar2.getClass();
                p.d();
            }
        }
        String str2 = String.format(Locale.SIMPLIFIED_CHINESE, "%d_%d_%d_%d_%d_%d", Integer.valueOf(hVar.c), 1, Integer.valueOf(i2), 0, Integer.valueOf(hVar.h), Integer.valueOf(hVar.i));
        p pVar3 = this.d;
        pVar3.getClass();
        HashMap map7 = new HashMap();
        map7.put("204", str2);
        pVar3.a(context, map7, false);
    }

    public final void a(h hVar, boolean z) {
        synchronized (this.f) {
            if (!z) {
                if (hVar.c != 0) {
                    return;
                }
            }
            this.f.set(hVar);
        }
    }

    public final void a() {
        synchronized (this.g) {
            if (((Boolean) this.g.get()).booleanValue()) {
                return;
            }
            this.g.set(Boolean.TRUE);
            this.b.sendMessageDelayed(Message.obtain(this.b, 2, 3), 0L);
        }
    }

    public final h a(Context context, boolean z, int i2) {
        h hVarC = c(context);
        if (this.f3947a == null) {
            return new h(TDHttpException.ERROR_EXCEPTION, 0, 0);
        }
        int iA = a(hVarC);
        if (iA != 1) {
            if (iA == 2) {
                if (Looper.myLooper() == Looper.getMainLooper()) {
                    a();
                    return new h(-10008, 0, 0);
                }
                synchronized (this.e) {
                    h hVarC2 = c(context);
                    if (hVarC2 != hVarC && a(hVarC2) == 1) {
                        return hVarC2;
                    }
                    synchronized (this.g) {
                        if (!((Boolean) this.g.get()).booleanValue()) {
                            this.g.set(Boolean.TRUE);
                            this.b.post(new j(this, context, i2));
                        }
                        try {
                            this.g.wait(z ? this.f3947a.v : ILivePlayer.RETRY_TIME_INTERVAL_DEFAULT);
                        } catch (InterruptedException unused) {
                        }
                    }
                    h hVarC3 = c(context);
                    if (hVarC3 == hVarC) {
                        hVarC3 = new h(-10004, 0, 0);
                    }
                    return hVarC3;
                }
            }
            if (iA == 3) {
                a();
            }
        }
        return hVarC;
    }

    public final int a(h hVar) {
        Context context;
        long jLongValue;
        if (this.f3947a.r || hVar.c != 0 || TextUtils.isEmpty(hVar.f3932a)) {
            return 2;
        }
        long jCurrentTimeMillis = System.currentTimeMillis() / 1000;
        if (jCurrentTimeMillis >= hVar.b) {
            this.f3947a.getClass();
            return 3;
        }
        p pVar = this.d;
        synchronized (Ccatch.class) {
            context = Ccatch.f3917a;
        }
        pVar.getClass();
        try {
            jLongValue = Long.valueOf(p.b(context, PointType.WIND_ACTIVE)).longValue();
        } catch (Throwable unused) {
            jLongValue = 0;
        }
        p pVar2 = this.d;
        Context contextA = Ccatch.a();
        pVar2.getClass();
        if (Math.abs(jCurrentTimeMillis - p.a(contextA, "108")) < jLongValue) {
            return 1;
        }
        this.f3947a.getClass();
        return 3;
    }

    public final void a(Context context) {
        String strA;
        synchronized (Core.class) {
            strA = Core.a(context, Core.f3841a);
        }
        if (TextUtils.isEmpty(strA)) {
            return;
        }
        this.d.getClass();
        HashMap map = new HashMap();
        map.put(cm.b, strA);
        p.a(context, map);
    }

    public static String a(long j2, long j3) {
        MediaDrm mediaDrm;
        try {
            UUID uuid = new UUID(j2, j3);
            mediaDrm = new MediaDrm(uuid);
            try {
                byte[] propertyByteArray = mediaDrm.getPropertyByteArray("deviceUniqueId");
                if (propertyByteArray.length == 0) {
                    try {
                        if (Build.VERSION.SDK_INT >= 28) {
                            mediaDrm.close();
                            return null;
                        }
                        mediaDrm.release();
                        return null;
                    } catch (Throwable unused) {
                    }
                } else {
                    String str = uuid + ":" + Teazle.a(propertyByteArray);
                    try {
                        if (Build.VERSION.SDK_INT >= 28) {
                            mediaDrm.close();
                            return str;
                        }
                        mediaDrm.release();
                        return str;
                    } catch (Throwable unused2) {
                    }
                }
            } catch (Throwable unused3) {
                try {
                    if (Build.VERSION.SDK_INT >= 28) {
                        if (mediaDrm != null) {
                            mediaDrm.close();
                        }
                    } else if (mediaDrm != null) {
                        mediaDrm.release();
                    }
                } catch (Throwable unused4) {
                }
                return null;
            }
        } catch (Throwable unused5) {
            mediaDrm = null;
        }
    }

    public final boolean a(boolean z) {
        Context context;
        p pVar = this.d;
        synchronized (Ccatch.class) {
            context = Ccatch.f3917a;
        }
        pVar.getClass();
        Triangulum triangulumB = p.b(context);
        if (triangulumB.b.size() == 0) {
            return true;
        }
        if (a(triangulumB)) {
            return triangulumB.b.size() < triangulumB.f3901a || Math.abs(System.currentTimeMillis() - ((Long) triangulumB.b.getFirst()).longValue()) >= m;
        }
        return z;
    }

    public final boolean a(Triangulum triangulum) {
        Context context;
        long jLongValue;
        p pVar = this.d;
        synchronized (Ccatch.class) {
            context = Ccatch.f3917a;
        }
        pVar.getClass();
        try {
            jLongValue = Long.valueOf(p.b(context, PointType.GDPR_CONSENT)).longValue();
        } catch (Throwable unused) {
            jLongValue = 0;
        }
        if (jLongValue <= 0) {
            return true;
        }
        long jAbs = Math.abs(System.currentTimeMillis() - ((Long) triangulum.b.getLast()).longValue());
        int[] iArr = n;
        int length = jLongValue < ((long) iArr.length) ? (int) jLongValue : iArr.length - 1;
        if (length < 1) {
            return true;
        }
        int i2 = iArr[length - 1];
        int i3 = iArr[length];
        if (i2 < i3) {
            return jAbs > TimeUnit.SECONDS.toMillis((long) (new Random().nextInt((i3 - i2) + 1) + i2));
        }
        throw new IllegalArgumentException("");
    }
}
