package com.kwad.components.core.innerEc.a;

import android.app.Activity;
import android.view.View;
import android.view.ViewGroup;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.service.ServiceProvider;

/* JADX INFO: loaded from: classes3.dex */
public final class c extends com.kwad.components.core.proxy.g {
    private final d Te;
    private final e Tf;
    private boolean lh;
    private final com.kwad.components.core.widget.g ll;
    private final AdTemplate mAdTemplate;

    @Override // com.kwad.components.core.proxy.g
    public final float dz() {
        return 0.0f;
    }

    @Override // com.kwad.components.core.proxy.g
    public final int getLayoutId() {
        return 0;
    }

    @Override // com.kwad.components.core.proxy.g
    public final boolean rt() {
        return false;
    }

    public static boolean a(AdTemplate adTemplate, d dVar) {
        try {
            com.kwad.sdk.core.c.b.Mh();
            Activity currentActivity = com.kwad.sdk.core.c.b.getCurrentActivity();
            if (currentActivity != null && !currentActivity.isFinishing()) {
                new c(currentActivity, adTemplate, dVar).show();
                dVar.pr();
                return true;
            }
            com.kwad.sdk.core.d.c.d("AuthHintDialog", "showDialog fail activity:" + currentActivity);
            return false;
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.d("AuthHintDialog", "showDialog fail error:" + th);
            com.kwad.sdk.core.d.c.printStackTraceOnly(th);
            dVar.rs();
            return false;
        }
    }

    private c(Activity activity, AdTemplate adTemplate, d dVar) {
        super(activity);
        this.ll = new com.kwad.components.core.widget.g() { // from class: com.kwad.components.core.innerEc.a.c.2
            @Override // com.kwad.components.core.widget.g
            public final void k(boolean z) {
                if (c.this.lh) {
                    Activity activity2 = c.this.mActivity;
                    com.kwad.sdk.core.c.b.Mh();
                    if (activity2 == com.kwad.sdk.core.c.b.getCurrentActivity()) {
                        com.kwad.sdk.core.adlog.c.l(c.this.mAdTemplate, z ? 2 : 1);
                        c.this.dC();
                    }
                }
            }
        };
        this.mAdTemplate = adTemplate;
        this.Te = dVar;
        this.Tf = new e() { // from class: com.kwad.components.core.innerEc.a.c.1
            @Override // com.kwad.components.core.innerEc.a.e
            public final void ps() {
                c.this.dismiss();
            }

            @Override // com.kwad.components.core.innerEc.a.e
            public final void rr() {
                if (c.this.Te != null) {
                    d unused = c.this.Te;
                }
            }

            @Override // com.kwad.components.core.innerEc.a.e
            public final void rs() {
                if (c.this.Te != null) {
                    c.this.Te.rs();
                }
            }

            @Override // com.kwad.components.core.innerEc.a.e
            public final void oU() {
                if (c.this.Te != null) {
                    d unused = c.this.Te;
                }
            }

            @Override // com.kwad.components.core.innerEc.a.e
            public final void rn() {
                if (c.this.Te != null) {
                    c.this.Te.rn();
                }
            }

            @Override // com.kwad.components.core.innerEc.a.e
            public final void oV() {
                if (c.this.Te != null) {
                    c.this.Te.oV();
                }
            }
        };
    }

    @Override // com.kwad.components.core.proxy.g
    public final ViewGroup dA() {
        com.kwad.components.core.widget.f fVar = new com.kwad.components.core.widget.f(this.mContext);
        fVar.setOrientationChangeListener(this.ll);
        return fVar;
    }

    @Override // com.kwad.components.core.proxy.g
    public final void g(View view) {
        dC();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void dC() {
        b bVar = new b(this.mContext, this.mAdTemplate, this.Tf);
        this.DQ.removeAllViews();
        this.DQ.addView(bVar);
    }

    @Override // android.app.Dialog, android.view.Window.Callback
    public final void onWindowFocusChanged(boolean z) {
        super.onWindowFocusChanged(z);
        this.lh = z;
        com.kwad.sdk.core.d.c.d("AuthHintDialog", "onWindowFocusChanged: " + z);
    }

    @Override // com.kwad.components.core.proxy.g, android.app.Dialog, android.content.DialogInterface
    public final void dismiss() {
        try {
            super.dismiss();
            com.kwad.sdk.core.d.c.d("AuthHintDialog", "dismiss");
            this.Te.gi();
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }
}
