package com.kwad.components.core.e.e;

import android.app.DialogFragment;
import android.content.Context;
import android.view.View;
import com.kwad.sdk.R;
import com.kwad.sdk.mvp.Presenter;
import com.kwad.sdk.widget.KSFrameLayout;
import com.kwad.sdk.wrapper.m;

/* JADX INFO: loaded from: classes3.dex */
public final class a extends KSFrameLayout {
    private final DialogFragment RB;
    private final View RC;
    private com.kwad.components.core.e.d.a.C0428a RD;

    public a(Context context, DialogFragment dialogFragment, com.kwad.components.core.e.d.a.C0428a c0428a) {
        super(context);
        this.RB = dialogFragment;
        this.RD = c0428a;
        m.inflate(context, R.layout.ksad_seconed_confirm_dialog_layout, this);
        this.RC = findViewById(R.id.ksad_second_confirm_root_view);
    }

    @Override // com.kwad.sdk.widget.KSFrameLayout
    public final void ae() {
        super.ae();
        Presenter presenterBF = bF();
        presenterBF.N(this.RC);
        presenterBF.q(qI());
    }

    private static Presenter bF() {
        Presenter presenter = new Presenter();
        presenter.a(new d());
        return presenter;
    }

    private c qI() {
        c cVar = new c();
        cVar.RB = this.RB;
        cVar.RD = this.RD;
        return cVar;
    }
}
