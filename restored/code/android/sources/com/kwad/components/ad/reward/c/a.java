package com.kwad.components.ad.reward.c;

import android.content.Context;
import com.kwad.components.ad.reward.g;
import com.kwad.components.core.webview.jshandler.j;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.utils.ae;
import java.lang.ref.WeakReference;
import java.util.List;
import java.util.concurrent.CopyOnWriteArrayList;

/* JADX INFO: loaded from: classes3.dex */
public class a {
    private static volatile a uT;
    private b uU;
    private volatile boolean uV = false;
    private volatile boolean uW = false;
    private List<WeakReference<j>> uX = new CopyOnWriteArrayList();
    private g ub;

    /* JADX INFO: renamed from: if, reason: not valid java name */
    public static a m175if() {
        if (uT == null) {
            synchronized (a.class) {
                if (uT == null) {
                    uT = new a();
                }
            }
        }
        return uT;
    }

    private a() {
    }

    public final synchronized void reset() {
        this.uU = null;
        this.uW = false;
        this.uV = false;
        this.ub = null;
    }

    public final void setCallerContext(g gVar) {
        this.ub = gVar;
    }

    public final synchronized void c(AdTemplate adTemplate, int i) {
        com.kwad.sdk.core.d.c.d("CurrentExtraRewardHolder", "updateExtraReward: " + i);
        g gVar = this.ub;
        if (gVar != null && gVar.hg() && i == b.STATUS_NONE) {
            com.kwad.sdk.core.d.c.d("CurrentExtraRewardHolder", "updateExtraReward: cant update to status 2");
            return;
        }
        b bVarIg = m175if().ig();
        bVarIg.aa(i);
        m175if().a(adTemplate, bVarIg);
    }

    public final synchronized void a(AdTemplate adTemplate, b bVar) {
        if (adTemplate == null) {
            return;
        }
        com.kwad.sdk.core.d.c.d("CurrentExtraRewardHolder", "updateExtraReward: " + bVar.toJson().toString());
        this.uU = bVar;
        if (bVar.vb == b.uY && !this.uV) {
            this.uV = true;
            c.a(this.uU, com.kwad.components.ad.reward.e.f.M(adTemplate.getUniqueId()));
            com.kwad.sdk.core.adlog.c.k(adTemplate, isNeoScan());
        }
        for (WeakReference<j> weakReference : this.uX) {
            if (weakReference.get() == null) {
                this.uX.remove(weakReference);
            } else {
                b bVarIg = ig();
                com.kwad.sdk.core.d.c.d("CurrentExtraRewardHolder", "GetNativeDataHandler callback: " + bVarIg.toJson().toString());
                weakReference.get().a(bVarIg);
            }
        }
    }

    private boolean isNeoScan() {
        return this.ub.mAdResultData.adGlobalConfigInfo != null && this.ub.mAdResultData.adGlobalConfigInfo.neoPageType == 1;
    }

    public final synchronized b ig() {
        if (this.uU == null) {
            b bVarIj = c.ij();
            this.uU = bVarIj;
            bVarIj.vb = 0;
        }
        com.kwad.sdk.core.d.c.d("CurrentExtraRewardHolder", "getCurrentExtraReward: " + this.uU.vb);
        return this.uU;
    }

    private synchronized boolean ih() {
        b bVar = this.uU;
        return bVar != null && bVar.vb == b.uY;
    }

    public final void a(j jVar) {
        com.kwad.sdk.core.d.c.d("CurrentExtraRewardHolder", "addGetNativeHandler: " + jVar);
        if (jVar != null) {
            this.uX.add(new WeakReference<>(jVar));
        }
    }

    public final void R(Context context) {
        boolean zIh = ih();
        com.kwad.sdk.core.d.c.d("CurrentExtraRewardHolder", "checkStatusAndToast isCurrentHadExtra: " + zIh + ", hadToast: " + this.uW);
        if (this.uW || !zIh) {
            return;
        }
        this.uW = true;
        ae.V(context, "恭喜获得第2份奖励");
    }
}
