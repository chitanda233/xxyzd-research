package com.kwad.components.ad.splashscreen.presenter.endcard;

import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;
import com.kwad.components.ad.splashscreen.widget.CloseCountDownView;
import com.kwad.sdk.R;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class c extends com.kwad.components.ad.splashscreen.presenter.e implements View.OnClickListener, com.kwad.sdk.widget.d {
    private CloseCountDownView JD;
    private ViewGroup JE;
    private ViewGroup JF;
    private ImageView JG;
    private TextView JH;
    private TextView JI;
    private SplashEndLandView JJ;
    private CloseCountDownView.a JK = new CloseCountDownView.a() { // from class: com.kwad.components.ad.splashscreen.presenter.endcard.c.1
        @Override // com.kwad.components.ad.splashscreen.widget.CloseCountDownView.a
        public final void em() {
            com.kwad.sdk.core.adlog.a.C0502a c0502a = new com.kwad.sdk.core.adlog.a.C0502a();
            com.kwad.components.ad.splashscreen.monitor.a.mr().ak(c.this.Hu.mAdTemplate);
            if (c.this.Hu.mTimerHelper != null) {
                c0502a.duration = c.this.Hu.mTimerHelper.getTime();
            }
            com.kwad.sdk.core.adlog.c.b(c.this.Hu.mAdTemplate, new com.kwad.sdk.core.adlog.c.b().dT(1).b(c0502a).eb(6), (JSONObject) null);
            c.this.Hu.mm();
        }

        @Override // com.kwad.components.ad.splashscreen.widget.CloseCountDownView.a
        public final void mz() {
            com.kwad.sdk.core.adlog.a.C0502a c0502a = new com.kwad.sdk.core.adlog.a.C0502a();
            if (c.this.Hu.mTimerHelper != null) {
                c0502a.duration = c.this.Hu.mTimerHelper.getTime();
            }
            com.kwad.sdk.core.adlog.c.b(c.this.Hu.mAdTemplate, new com.kwad.sdk.core.adlog.c.b().dT(14).b(c0502a).eb(6), (JSONObject) null);
            c.this.Hu.mq();
        }
    };

    @Override // com.kwad.sdk.widget.d
    public final void a(View view, float f, float f2, float f3, float f4) {
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.e, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        if (this.JJ == null) {
            SplashEndLandView splashEndLandView = (SplashEndLandView) findViewById(R.id.ksad_splash_end_card_native_dialog_root);
            this.JJ = splashEndLandView;
            this.JD = splashEndLandView.getCloseView();
            this.JE = this.JJ.getGiftBoxView();
            this.JF = this.JJ.getActionBarView();
            this.JG = this.JJ.getAppIcon();
            this.JH = this.JJ.getAppName();
            this.JI = this.JJ.getAppDesc();
        }
        this.JD.setOnViewClickListener(this.JK);
        this.JF.setOnClickListener(this);
        new com.kwad.sdk.widget.h(this.JF.getContext(), this.JF, this);
        if (com.kwad.sdk.core.response.helper.b.dM(com.kwad.sdk.core.response.helper.e.eM(this.Hu.mAdTemplate))) {
            this.JE.setOnClickListener(this);
            this.JG.setOnClickListener(this);
            this.JH.setOnClickListener(this);
            this.JI.setOnClickListener(this);
            new com.kwad.sdk.widget.h(this.JF.getContext(), this.JE, this);
            new com.kwad.sdk.widget.h(this.JF.getContext(), this.JG, this);
            new com.kwad.sdk.widget.h(this.JF.getContext(), this.JH, this);
            new com.kwad.sdk.widget.h(this.JF.getContext(), this.JI, this);
        }
    }

    @Override // android.view.View.OnClickListener
    public final void onClick(View view) {
        v(view);
    }

    @Override // com.kwad.sdk.widget.d
    public final void a(View view) {
        v(view);
    }

    private void v(View view) {
        if (view == this.JE) {
            this.Hu.c(2, view.getContext(), 104, 3);
            return;
        }
        if (view == this.JF) {
            this.Hu.c(2, view.getContext(), 26, 1);
            return;
        }
        if (view == this.JG) {
            this.Hu.c(2, view.getContext(), 15, 3);
        } else if (view == this.JH) {
            this.Hu.c(2, view.getContext(), 16, 3);
        } else if (view == this.JI) {
            this.Hu.c(2, view.getContext(), 17, 3);
        }
    }
}
