package com.kwad.components.core.s.b;

import android.view.View;
import android.widget.FrameLayout;
import com.kwad.components.core.proxy.f;
import com.kwad.sdk.R;
import com.kwad.sdk.components.o;
import com.kwad.sdk.mvp.Presenter;

/* JADX INFO: loaded from: classes3.dex */
public final class b extends Presenter {
    private FrameLayout akZ;
    private com.kwad.components.core.s.a.b alc;
    private o alf;

    @Override // com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.alc = (com.kwad.components.core.s.a.b) SK();
        this.akZ = (FrameLayout) findViewById(R.id.ksad_js_container);
        this.alf = this.alc.akT.a(null);
        this.alc.abs.add(new com.kwad.components.core.n.a.a() { // from class: com.kwad.components.core.s.b.b.1
            @Override // com.kwad.components.core.n.a.a
            public final void c(f fVar) {
            }

            @Override // com.kwad.components.core.n.a.a
            public final void d(f fVar) {
            }

            @Override // com.kwad.components.core.n.a.a
            public final void hi() {
            }

            @Override // com.kwad.components.core.n.a.a
            public final void hj() {
                if (b.this.alc.akS != null) {
                    b.this.alc.akS.callbackDismiss();
                }
            }
        });
        if (this.alf == null) {
            if (getActivity() != null) {
                getActivity().finish();
            }
        } else {
            FrameLayout.LayoutParams layoutParams = new FrameLayout.LayoutParams(-1, -1);
            View view = this.alf.getView();
            view.setLayoutParams(layoutParams);
            this.akZ.addView(view);
            this.alf.bindActivity(getActivity());
            this.alf.render();
        }
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
