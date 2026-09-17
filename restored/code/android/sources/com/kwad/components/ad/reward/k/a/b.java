package com.kwad.components.ad.reward.k.a;

import android.app.Activity;
import android.content.DialogInterface;
import android.os.Bundle;
import com.kwad.components.ad.reward.g;
import java.lang.ref.WeakReference;

/* JADX INFO: loaded from: classes3.dex */
public final class b extends com.kwad.components.core.webview.tachikoma.d.e {
    private static WeakReference<b> Cc;
    private g BZ;
    private long Cb;

    private static boolean kN() {
        WeakReference<b> weakReference = Cc;
        return (weakReference == null || weakReference.get() == null) ? false : true;
    }

    public static b a(g gVar, com.kwad.components.core.webview.tachikoma.d.e.b bVar) {
        b bVar2 = new b();
        bVar2.BZ = gVar;
        bVar2.mAdResultData = bVar.iF();
        bVar2.BV = bVar.getTemplateId();
        bVar2.auI = bVar.lH();
        bVar2.auR = bVar.zL();
        Bundle bundle = new Bundle();
        bundle.putString("templateId", bVar.getTemplateId());
        bVar2.setArguments(bundle);
        return bVar2;
    }

    public static b a(b bVar, Activity activity, long j, com.kwad.components.core.webview.tachikoma.f.c cVar, com.kwad.components.core.webview.tachikoma.d.e.a aVar) {
        if (activity == null || activity.isFinishing() || kN()) {
            return null;
        }
        bVar.akN = cVar;
        bVar.auJ = aVar;
        bVar.show(activity.getFragmentManager(), "tkCloseDialog");
        if (j > 0) {
            bVar.q(j);
        }
        Cc = new WeakReference<>(bVar);
        return bVar;
    }

    public static b a(g gVar, Activity activity, long j, DialogInterface.OnDismissListener onDismissListener, com.kwad.components.core.webview.tachikoma.f.c cVar) {
        if (activity == null || activity.isFinishing() || kN()) {
            return null;
        }
        com.kwad.components.core.webview.tachikoma.d.e.b bVar = new com.kwad.components.core.webview.tachikoma.d.e.b();
        bVar.a(gVar.mAdResultData);
        bVar.bN(com.kwad.sdk.core.response.helper.b.em(gVar.mAdTemplate));
        b bVarA = a(gVar, bVar);
        bVarA.akN = cVar;
        bVarA.d(onDismissListener);
        bVarA.q(j);
        bVarA.show(activity.getFragmentManager(), "tkExtraReward");
        Cc = new WeakReference<>(bVarA);
        return bVarA;
    }

    @Override // com.kwad.components.core.webview.tachikoma.d.e
    public final com.kwad.components.core.webview.tachikoma.d.b kO() {
        return new a(this.BZ);
    }

    @Override // com.kwad.components.core.webview.tachikoma.d.e
    public final com.kwad.components.core.webview.tachikoma.d.c kP() {
        return new c();
    }

    @Override // com.kwad.components.core.webview.tachikoma.d.e
    public final void kQ() {
        super.kQ();
        this.auE.Cb = this.Cb;
    }

    @Override // com.kwad.components.core.webview.tachikoma.d.e, android.app.Fragment
    public final void onDestroy() {
        super.onDestroy();
        this.BZ = null;
        Cc = null;
    }

    private void q(long j) {
        this.Cb = j;
        if (this.auE != null) {
            this.auE.Cb = j;
        }
    }
}
