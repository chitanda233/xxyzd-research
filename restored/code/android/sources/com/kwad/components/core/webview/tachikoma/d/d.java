package com.kwad.components.core.webview.tachikoma.d;

import android.view.View;
import android.widget.FrameLayout;
import com.kwad.sdk.R;
import com.kwad.sdk.components.o;
import com.kwad.sdk.mvp.Presenter;

/* JADX INFO: loaded from: classes3.dex */
public final class d extends Presenter {
    private FrameLayout akZ;
    private o alf;
    private e asz;
    protected b auE;

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.akZ = (FrameLayout) findViewById(R.id.ksad_tk_dialog_container);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        b bVar = (b) SK();
        this.auE = bVar;
        e eVar = bVar.asz;
        this.asz = eVar;
        if (eVar != null) {
            eVar.a(new com.kwad.components.core.webview.tachikoma.f.e() { // from class: com.kwad.components.core.webview.tachikoma.d.d.1
                @Override // com.kwad.components.core.webview.tachikoma.f.e
                public final void hk() {
                }

                @Override // com.kwad.components.core.webview.tachikoma.f.e
                public final void hs() {
                }
            });
        }
        o oVarA = this.auE.auH.a(null);
        this.alf = oVarA;
        if (oVarA == null) {
            this.auE.auG.callbackPageStatus(false, null);
            this.asz.getDialog().dismiss();
            return;
        }
        FrameLayout.LayoutParams layoutParams = new FrameLayout.LayoutParams(-1, -1);
        View view = this.alf.getView();
        view.setLayoutParams(layoutParams);
        this.akZ.addView(view);
        this.alf.render();
        this.auE.auG.callbackPageStatus(true, null);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
    }

    public final boolean onBackPressed() {
        o oVar = this.alf;
        return oVar != null && oVar.onBackPressed();
    }
}
