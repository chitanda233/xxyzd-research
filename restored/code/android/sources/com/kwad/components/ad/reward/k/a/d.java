package com.kwad.components.ad.reward.k.a;

import android.app.Activity;
import android.content.Context;
import android.content.DialogInterface;
import android.view.ViewGroup;
import com.kwad.components.ad.reward.g;
import com.kwad.components.ad.reward.k.l;
import com.kwad.components.ad.reward.k.m;
import com.kwad.components.ad.reward.k.n;
import com.kwad.components.ad.reward.k.o;
import com.kwad.components.ad.reward.k.p;
import com.kwad.components.ad.reward.k.q;
import com.kwad.components.ad.reward.k.r;
import com.kwad.components.ad.reward.k.s;
import com.kwad.components.ad.reward.page.BackPressHandleResult;
import com.kwad.components.core.webview.jshandler.am;
import com.kwad.components.core.webview.jshandler.y;
import com.kwad.components.core.webview.tachikoma.i;
import com.kwad.components.core.webview.tachikoma.j;
import com.kwad.sdk.components.t;
import com.kwad.sdk.core.response.model.AdResultData;
import com.kwad.sdk.core.response.model.AdTemplate;
import java.lang.ref.WeakReference;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public final class d extends i implements s, y.b {
    private com.kwad.components.ad.reward.c.e Cf;
    private m Cg;
    private l Ch;
    private n Ci;
    private List<AdTemplate> Cj;
    private DialogInterface.OnDismissListener Ck;
    private com.kwad.components.core.e.d.d mApkDownloadHelper;
    private WeakReference<g> tS;

    public d(g gVar, long j, Context context) {
        super(j, context);
        this.Cj = null;
        this.tS = new WeakReference<>(gVar);
    }

    public d(g gVar, long j, Context context, DialogInterface.OnDismissListener onDismissListener) {
        super(-1L, context);
        this.Cj = null;
        this.Ck = onDismissListener;
        this.tS = new WeakReference<>(gVar);
    }

    public final com.kwad.components.ad.reward.c.e kR() {
        return this.Cf;
    }

    public final l kS() {
        return this.Ch;
    }

    public final BackPressHandleResult hH() {
        m mVar = this.Cg;
        if (mVar == null) {
            return BackPressHandleResult.NOT_HANDLED;
        }
        mVar.kK();
        return BackPressHandleResult.HANDLED;
    }

    @Override // com.kwad.components.core.webview.tachikoma.i
    public final void a(Activity activity, AdResultData adResultData, j jVar) {
        super.a(activity, adResultData, jVar);
        WeakReference<g> weakReference = this.tS;
        g gVar = weakReference != null ? weakReference.get() : null;
        if (gVar != null) {
            gVar.a(this);
        }
    }

    @Override // com.kwad.components.core.webview.tachikoma.i
    public final void kT() {
        super.kT();
        WeakReference<g> weakReference = this.tS;
        g gVar = weakReference != null ? weakReference.get() : null;
        if (gVar != null) {
            gVar.b(this);
        }
    }

    @Override // com.kwad.components.core.webview.tachikoma.i
    public final void a(com.kwad.sdk.core.webview.b bVar, com.kwad.components.core.e.d.d dVar, t tVar, ViewGroup viewGroup) {
        super.a(bVar, dVar, tVar, viewGroup);
        this.mApkDownloadHelper = dVar;
        WeakReference<g> weakReference = this.tS;
        com.kwad.sdk.core.webview.c.a qVar = new q(bVar, dVar, weakReference != null ? weakReference.get() : null, this.Cb, this, this.Ck);
        com.kwad.components.core.e.e.g.qJ().a(this);
        tVar.c(qVar);
        com.kwad.components.ad.reward.c.e eVar = new com.kwad.components.ad.reward.c.e();
        this.Cf = eVar;
        tVar.c(eVar);
        Context context = this.mContext;
        WeakReference<g> weakReference2 = this.tS;
        tVar.c(new com.kwad.components.ad.reward.k.t(context, weakReference2 != null ? weakReference2.get() : null));
        WeakReference<g> weakReference3 = this.tS;
        tVar.c(new o(weakReference3 != null ? weakReference3.get() : null));
        m mVar = new m();
        this.Cg = mVar;
        tVar.c(mVar);
        l lVar = new l();
        this.Ch = lVar;
        tVar.c(lVar);
        List<AdTemplate> list = this.Cj;
        if (list != null) {
            this.Ch.g(list);
            this.Cj = null;
        }
        y yVar = new y(bVar);
        yVar.a(this);
        tVar.c(yVar);
        n nVar = new n();
        this.Ci = nVar;
        tVar.c(nVar);
        tVar.c(new r(this.tS));
    }

    @Override // com.kwad.components.core.webview.tachikoma.i
    public final am c(com.kwad.sdk.core.webview.b bVar) {
        WeakReference<g> weakReference = this.tS;
        return new p(weakReference != null ? weakReference.get() : null, getTkTemplateId(), this.Cb, bVar);
    }

    public final void h(List<AdTemplate> list) {
        this.Cj = list;
    }

    @Override // com.kwad.components.core.webview.tachikoma.i, com.kwad.components.core.e.e.f
    public final void show() {
        super.show();
        WeakReference<g> weakReference = this.tS;
        if (weakReference != null) {
            weakReference.get().E(true);
        }
    }

    @Override // com.kwad.components.core.webview.tachikoma.i, com.kwad.components.core.e.e.f
    public final void dismiss() {
        WeakReference<g> weakReference = this.tS;
        if (weakReference != null) {
            weakReference.get().E(false);
        }
        super.dismiss();
    }

    @Override // com.kwad.components.core.webview.tachikoma.i, com.kwad.components.core.innerEc.a.g
    public final void dl() {
        super.dl();
        WeakReference<g> weakReference = this.tS;
        if (weakReference != null) {
            weakReference.get().E(true);
        }
    }

    @Override // com.kwad.components.core.webview.tachikoma.i, com.kwad.components.core.innerEc.a.g
    public final void dm() {
        WeakReference<g> weakReference = this.tS;
        if (weakReference != null) {
            weakReference.get().E(false);
        }
        super.dm();
    }

    @Override // com.kwad.components.core.webview.jshandler.y.b
    public final void W(AdTemplate adTemplate) {
        com.kwad.components.core.j.c cVar = new com.kwad.components.core.j.c(adTemplate, com.kwad.components.core.j.e.AGGREGATION);
        WeakReference<g> weakReference = this.tS;
        g gVar = weakReference != null ? weakReference.get() : null;
        if (gVar != null) {
            gVar.b(cVar);
        }
    }

    @Override // com.kwad.components.ad.reward.k.s
    public final void ac(boolean z) {
        n nVar = this.Ci;
        if (nVar != null) {
            nVar.ab(z);
        }
    }
}
