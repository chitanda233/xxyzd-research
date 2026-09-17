package com.tencent.turingfd.sdk.ams.ad;

import android.content.Context;
import android.os.Build;
import android.text.TextUtils;
import android.util.Log;
import android.util.SparseArray;
import com.bykv.vk.component.ttvideo.mediakit.medialoader.AVMDLDataLoader;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.bytedance.sdk.openadsdk.mediation.MediationConstant;
import com.sigmob.sdk.base.mta.PointType;
import java.util.Collections;
import java.util.HashMap;
import java.util.HashSet;
import java.util.Map;
import java.util.Set;

/* JADX INFO: loaded from: classes4.dex */
public final class s {
    public static final s h = new s();
    public static final Set i;
    public TuringSDK e;
    public p f;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final HashSet f3959a = new HashSet();
    public final HashSet b = new HashSet();
    public final HashSet c = new HashSet();
    public final Object d = new Object();
    public final r g = new r();

    static {
        HashSet hashSet = new HashSet();
        hashSet.add(40);
        hashSet.add(43);
        hashSet.add(36);
        hashSet.add(45);
        hashSet.add(Integer.valueOf(MediaPlayer.MEDIA_PLAYER_OPTION_SET_PIPE_DECLARE_LENGTH));
        hashSet.add(Integer.valueOf(MediaPlayer.MEDIA_PLAYER_OPTION_SEEK_END_ENABLE));
        hashSet.add(Integer.valueOf(MediaPlayer.MEDIA_PLAYER_OPTION_SPADE));
        hashSet.add(114);
        hashSet.add(Integer.valueOf(AVMDLDataLoader.KeyIsStoPlayDldWinSizeKBLS));
        hashSet.add(Integer.valueOf(AVMDLDataLoader.KeyIsStoRingBufferSizeKB));
        int i2 = Olive.f3871a;
        if (i2 == 105668 || i2 == 105928 || i2 == 108168) {
            hashSet.add(18);
        }
        i = Collections.unmodifiableSet(hashSet);
    }

    public final void a(TuringSDK turingSDK, p pVar) {
        this.e = turingSDK;
        this.f = pVar;
        HashSet hashSet = turingSDK.B;
        if (hashSet != null) {
            synchronized (this.b) {
                this.b.addAll(hashSet);
            }
        }
        String str = Build.BRAND;
        if (MediationConstant.ADN_XIAOMI.equalsIgnoreCase(str) || "redmi".equalsIgnoreCase(str)) {
            synchronized (this.b) {
                this.b.add(Integer.valueOf(MediaPlayer.MEDIA_PLAYER_OPTION_EANABLE_DROPPING_DTS_ROLLBACK));
            }
        }
        if (turingSDK.C) {
            this.f3959a.add(Integer.valueOf(MediaPlayer.MEDIA_PLAYER_OPTION_SPADE));
        }
        if (turingSDK.A) {
            this.f3959a.add(114);
        }
        b();
    }

    public final void b() {
        Map map;
        try {
            Auriga aurigaB = q.f.b();
            if (aurigaB == null || (map = aurigaB.e) == null) {
                map = Collections.EMPTY_MAP;
            }
            HashSet hashSet = new HashSet();
            HashSet hashSet2 = new HashSet();
            for (Map.Entry entry : map.entrySet()) {
                if (((Integer) entry.getValue()).intValue() == 0) {
                    hashSet.add(entry.getKey());
                } else {
                    hashSet2.add(entry.getKey());
                }
            }
            synchronized (this.c) {
                this.c.clear();
                this.c.addAll(i);
                this.c.addAll(hashSet);
                this.c.removeAll(hashSet2);
                synchronized (this.b) {
                    this.c.addAll(this.b);
                }
                synchronized (this.f3959a) {
                    this.c.removeAll(this.f3959a);
                }
            }
        } catch (Throwable unused) {
        }
    }

    /* JADX WARN: Code duplicated, block: B:10:0x0024  */
    public final void a(Context context) {
        long j;
        try {
            synchronized (this.d) {
                q qVar = q.f;
                if (qVar.d()) {
                    this.f.getClass();
                    long jA = p.a(context, "501");
                    Auriga aurigaB = qVar.b();
                    if (aurigaB != null) {
                        j = aurigaB.f;
                        if (j <= 0) {
                            j = 57600;
                        }
                    } else {
                        j = 57600;
                    }
                    if (Math.abs(System.currentTimeMillis() - jA) <= j * 1000) {
                        return;
                    }
                }
                Lynx lynx = this.e.b;
                if (lynx == null) {
                    lynx = e.I;
                }
                boolean zUserAgreement = lynx.userAgreement();
                byte[] bArrA = a(context, zUserAgreement);
                if (bArrA.length == 0) {
                    return;
                }
                Auriga aurigaA = a(w.a(4, bArrA, 8119, 18119, this.g).d);
                if (aurigaA == null) {
                    return;
                }
                qVar.a(aurigaA, zUserAgreement);
                if (zUserAgreement) {
                    this.f.getClass();
                    String str = "" + System.currentTimeMillis();
                    HashMap map = new HashMap();
                    map.put("501", str);
                    p.a(context, map);
                }
            }
        } catch (Throwable unused) {
        }
    }

    public final byte[] a(Context context, boolean z) {
        byte[] bArr = new byte[0];
        HashMap map = new HashMap();
        map.put("1", "" + Olive.f3871a);
        TuringSDK turingSDK = this.e;
        map.put(PointType.ANTI_SPAM, TextUtils.isEmpty(turingSDK.p) ? "" : turingSDK.p);
        Auriga aurigaB = q.f.b();
        if (aurigaB != null) {
            map.put("2026", String.valueOf(aurigaB.f3821a));
            map.put("2027", String.valueOf(aurigaB.c));
        }
        map.put("207", n.l.c(context).f3932a);
        if (z) {
            map.put("264", Cprotected.a());
        } else {
            map.put("264", "PPNA");
        }
        try {
            SparseArray sparseArray = new SparseArray();
            String str = f.f3927a;
            SparseArray<Object> sparseArrayE209308_501191CEF186C29F = TNative$aa.e209308_501191CEF186C29F(sparseArray, context, map, 0);
            if (Cantaloupe.a(sparseArrayE209308_501191CEF186C29F) == 0) {
                byte[] bArr2 = (byte[]) Cantaloupe.a(sparseArrayE209308_501191CEF186C29F, 1, byte[].class);
                return bArr2 == null ? new byte[0] : bArr2;
            }
        } catch (Throwable unused) {
        }
        return bArr;
    }

    public static Auriga a(byte[] bArr) {
        String str = f.f3927a;
        try {
            Loquat loquat = new Loquat();
            loquat.a(new Perseus(bArr));
            int i2 = loquat.f3862a;
            if (i2 < 0) {
                return null;
            }
            if (i2 == 1) {
                return new Auriga();
            }
            Auriga auriga = loquat.b;
            if (auriga == null) {
                return new Auriga();
            }
            Log.e("D" + Olive.f3871a, "s:" + auriga.f3821a + ",v:" + auriga.c);
            for (Map.Entry entry : auriga.e.entrySet()) {
            }
            Map map = auriga.g;
            if (map != null) {
                for (String str2 : map.keySet()) {
                }
            }
            return auriga;
        } catch (Throwable unused) {
            return null;
        }
    }

    public final boolean a(int i2) {
        boolean z;
        synchronized (this.c) {
            z = !this.c.contains(Integer.valueOf(i2));
        }
        return z;
    }

    public final String a() {
        StringBuilder sb = new StringBuilder();
        synchronized (this.c) {
            for (Integer num : this.c) {
                if (sb.length() > 0) {
                    sb.append(",");
                }
                sb.append(num);
            }
        }
        return sb.toString();
    }
}
