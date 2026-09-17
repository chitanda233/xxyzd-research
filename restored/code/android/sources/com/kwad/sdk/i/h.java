package com.kwad.sdk.i;

import android.text.TextUtils;
import java.util.Iterator;
import java.util.List;
import java.util.Random;
import java.util.concurrent.ConcurrentLinkedQueue;
import java.util.concurrent.atomic.AtomicBoolean;
import java.util.concurrent.atomic.AtomicInteger;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class h {
    private d biC;
    private g biD;
    private ConcurrentLinkedQueue<i> biE;
    private f biF;
    private final AtomicBoolean biy;
    private final AtomicBoolean mHasInit;
    private static final AtomicBoolean biA = new AtomicBoolean(false);
    private static final AtomicInteger biB = new AtomicInteger(0);
    private static final float aJw = new Random().nextFloat();

    /* synthetic */ h(byte b) {
        this();
    }

    private h() {
        this.mHasInit = new AtomicBoolean(false);
        this.biy = new AtomicBoolean(false);
    }

    static final class a {
        private static final h biI = new h(0);
    }

    public static h RZ() {
        return a.biI;
    }

    public final void a(String str, g gVar, f fVar) {
        if (this.mHasInit.get()) {
            return;
        }
        try {
            j.Sk();
            this.biD = gVar;
            this.biF = fVar;
            this.biC = gU(str);
            this.mHasInit.set(true);
            Sg();
        } catch (Throwable unused) {
            biA.set(true);
            j.Sj();
        }
    }

    public final void Sa() {
        if (!this.mHasInit.get() || this.biC == null) {
            return;
        }
        j.Sk();
        m.Sm();
    }

    public final synchronized void Sb() {
        this.biy.set(true);
    }

    public final synchronized void Sc() {
        this.biy.set(false);
    }

    public final g Sd() {
        return this.biD;
    }

    public final f Se() {
        return this.biF;
    }

    public final long Sf() {
        return this.biC.RS();
    }

    private static d gU(String str) {
        try {
            if (TextUtils.isEmpty(str)) {
                return null;
            }
            JSONObject jSONObject = new JSONObject(str);
            d dVar = new d();
            dVar.parseJson(jSONObject);
            return dVar;
        } catch (Throwable unused) {
            j.Sj();
            return null;
        }
    }

    public final void g(String str, String str2, String str3) {
        try {
            if (!TextUtils.isEmpty(str) && !TextUtils.isEmpty(str2) && !TextUtils.isEmpty(str3)) {
                if (this.biy.get()) {
                    j.Sk();
                    return;
                }
                i iVarGX = i.Si().gV(str).gW(str2).gX(str3);
                if (this.mHasInit.get()) {
                    b(iVarGX);
                } else {
                    if (biA.get()) {
                        return;
                    }
                    j.Sk();
                    a(iVarGX);
                }
            }
        } catch (Throwable unused) {
            j.Sj();
        }
    }

    private void a(i iVar) {
        if (this.biE == null) {
            this.biE = new ConcurrentLinkedQueue<>();
        }
        AtomicInteger atomicInteger = biB;
        if (atomicInteger.get() >= 500) {
            return;
        }
        atomicInteger.incrementAndGet();
        this.biE.add(iVar);
    }

    private void Sg() {
        ConcurrentLinkedQueue<i> concurrentLinkedQueue = this.biE;
        if (concurrentLinkedQueue == null) {
            return;
        }
        Iterator<i> it = concurrentLinkedQueue.iterator();
        while (it.hasNext()) {
            b(it.next());
        }
        this.biE.clear();
        this.biE = null;
    }

    private void b(final i iVar) {
        d dVar = this.biC;
        if (dVar == null || j.R(dVar.bil) || this.biD == null || this.biF == null) {
            return;
        }
        j.a(new n() { // from class: com.kwad.sdk.i.h.1
            @Override // com.kwad.sdk.i.n
            public final void doTask() {
                h hVar = h.this;
                e eVarA = hVar.a(hVar.biC, iVar);
                if (eVarA == null) {
                    return;
                }
                iVar.l(eVarA.aJX);
                m.a(iVar, eVarA.bim == 2);
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public e a(d dVar, i iVar) {
        List<e> list = dVar.bil;
        if (j.R(list)) {
            return null;
        }
        for (e eVar : list) {
            if (a(eVar.bin) && a(eVar.bio, iVar) && eVar.aJX > 0.0d && aJw <= eVar.aJX) {
                return eVar;
            }
        }
        return null;
    }

    private boolean a(e.b bVar) {
        if (bVar.biv != e.b.bis) {
            return bVar.RT();
        }
        bVar.cc(b(bVar) && c(bVar) && d(bVar));
        return bVar.RT();
    }

    private boolean b(e.b bVar) {
        List<String> list = bVar.bds;
        if (j.R(list)) {
            return true;
        }
        Iterator<String> it = list.iterator();
        while (it.hasNext()) {
            if (TextUtils.equals(this.biD.getAppId(), it.next())) {
                return true;
            }
        }
        return false;
    }

    private boolean c(e.b bVar) {
        List<String> list = bVar.bdt;
        if (j.R(list)) {
            return true;
        }
        Iterator<String> it = list.iterator();
        while (it.hasNext()) {
            if (TextUtils.equals(this.biD.getSdkVersion(), it.next())) {
                return true;
            }
        }
        return false;
    }

    private boolean d(e.b bVar) {
        String androidId = this.biD.getAndroidId();
        String deviceId = this.biD.getDeviceId();
        String imei = this.biD.getImei();
        String oaid = this.biD.getOaid();
        List<String> list = bVar.biu;
        if (j.R(list)) {
            return true;
        }
        for (String str : list) {
            if (TextUtils.equals(str, androidId) || TextUtils.equals(str, deviceId) || TextUtils.equals(str, imei) || TextUtils.equals(str, oaid)) {
                return true;
            }
        }
        return false;
    }

    private boolean a(e.a aVar, i iVar) {
        return a(aVar, iVar.biJ) && b(aVar, iVar.biK) && c(aVar, iVar.biL);
    }

    private static boolean a(e.a aVar, String str) {
        List<String> list = aVar.bip;
        if (j.R(list)) {
            return true;
        }
        Iterator<String> it = list.iterator();
        while (it.hasNext()) {
            if (TextUtils.equals(str, it.next())) {
                return true;
            }
        }
        return false;
    }

    private static boolean b(e.a aVar, String str) {
        List<String> list = aVar.biq;
        if (j.R(list)) {
            return true;
        }
        Iterator<String> it = list.iterator();
        while (it.hasNext()) {
            if (TextUtils.equals(str, it.next())) {
                return true;
            }
        }
        return false;
    }

    private static boolean c(e.a aVar, String str) {
        List<String> list = aVar.bir;
        if (j.R(list)) {
            return true;
        }
        Iterator<String> it = list.iterator();
        while (it.hasNext()) {
            if (str.contains(it.next())) {
                return true;
            }
        }
        return false;
    }
}
