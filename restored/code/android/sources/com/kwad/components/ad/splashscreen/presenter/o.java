package com.kwad.components.ad.splashscreen.presenter;

import android.animation.Animator;
import android.animation.AnimatorListenerAdapter;
import android.content.Context;
import android.os.SystemClock;
import android.os.Vibrator;
import android.view.View;
import android.view.ViewGroup;
import android.view.ViewStub;
import android.widget.TextView;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.kwad.components.ad.splashscreen.widget.KsShakeView;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.helper.SlideConvertHelper;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class o extends i implements View.OnClickListener, com.kwad.components.ad.splashscreen.g, com.kwad.sdk.core.g.b, com.kwad.sdk.widget.d {
    private boolean Hk;
    private ViewGroup IE;
    private com.kwad.components.ad.splashscreen.d Ib;
    private TextView Iv;
    private KsShakeView Iy;
    private com.kwad.sdk.core.g.d hm;
    private Vibrator ho;
    private long mStartTime;

    @Override // com.kwad.components.ad.splashscreen.g
    public final void am(int i) {
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.i
    protected final void initView() {
        this.mStartTime = SystemClock.elapsedRealtime();
        getRootView().post(new bi() { // from class: com.kwad.components.ad.splashscreen.presenter.o.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                o.this.Hu.GW = SystemClock.elapsedRealtime() - o.this.mStartTime;
            }
        });
        Context context = getContext();
        if (context != null) {
            this.ho = (Vibrator) context.getSystemService("vibrator");
        }
        ViewStub viewStub = (ViewStub) findViewById(R.id.ksad_shake_layout);
        if (viewStub != null) {
            this.IE = (ViewGroup) viewStub.inflate();
        } else {
            this.IE = (ViewGroup) findViewById(R.id.ksad_shake_root);
        }
        this.Iv = (TextView) this.IE.findViewById(R.id.ksad_shake_action);
        KsShakeView ksShakeView = (KsShakeView) this.IE.findViewById(R.id.ksad_shake_view);
        this.Iy = ksShakeView;
        ksShakeView.setOnClickListener(this);
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.i
    protected final void mH() {
        this.Ib = com.kwad.components.ad.splashscreen.d.a(this.Hu.mAdTemplate, com.kwad.sdk.core.response.helper.e.eM(this.Hu.mAdTemplate), this.Hu.mApkDownloadHelper, 2);
        this.Hk = com.kwad.sdk.core.response.helper.d.eB(this.Hu.mAdTemplate);
        new com.kwad.sdk.widget.h(this.Iy.getContext(), this.Iy, this);
        this.Hu.a(this);
        TextView textView = this.Iv;
        if (textView != null) {
            textView.setText(this.Ib.lU());
        }
        KsShakeView ksShakeView = this.Iy;
        if (ksShakeView != null) {
            ksShakeView.as(this.Ib.lV());
        }
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.i
    protected final void mI() {
        if (this.IE == null || this.Hu == null) {
            return;
        }
        this.IE.setVisibility(0);
        com.kwad.sdk.core.adlog.c.b(this.Hu.mAdTemplate, MediaPlayer.MEDIA_PLAYER_OPTION_ENABLE_SOLOPLAY, (JSONObject) null);
        com.kwad.components.core.webview.tachikoma.e.a.zM().cb(MediaPlayer.MEDIA_PLAYER_OPTION_ENABLE_SOLOPLAY);
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.i
    protected final void mJ() {
        float fDF = com.kwad.sdk.core.response.helper.b.dF(this.Hu.mAdTemplate);
        boolean zDZ = com.kwad.sdk.core.response.helper.b.dZ(com.kwad.sdk.core.response.helper.e.eM(this.Hu.mAdTemplate));
        boolean zEa = com.kwad.sdk.core.response.helper.b.ea(com.kwad.sdk.core.response.helper.e.eM(this.Hu.mAdTemplate));
        com.kwad.sdk.core.g.d dVar = this.hm;
        if (dVar == null) {
            com.kwad.sdk.core.g.d dVar2 = new com.kwad.sdk.core.g.d(zDZ, fDF);
            this.hm = dVar2;
            dVar2.bG(zEa);
            this.hm.a(this);
            return;
        }
        dVar.m(fDF);
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.i
    protected final void mK() {
        com.kwad.sdk.core.g.d dVar = this.hm;
        if (dVar != null) {
            dVar.ca(getContext());
        }
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.i
    protected final void mL() {
        com.kwad.sdk.core.g.d dVar = this.hm;
        if (dVar != null) {
            dVar.cb(getContext());
        }
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.i
    protected final void fW() {
        this.Iy.post(new bi() { // from class: com.kwad.components.ad.splashscreen.presenter.o.2
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                o.this.Iy.oa();
            }
        });
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.i
    protected final void i(int i, String str) {
        TextView textView = this.Iv;
        if (textView != null) {
            if (i == 2) {
                textView.setText(str);
            } else {
                textView.setText("或点击" + str);
            }
        }
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.i, com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        com.kwad.sdk.core.d.c.d("SplashShakePresenter", "onUnbind");
        if (this.Hu != null) {
            this.Hu.b(this);
        }
        KsShakeView ksShakeView = this.Iy;
        if (ksShakeView != null) {
            ksShakeView.ob();
        }
    }

    @Override // com.kwad.sdk.core.g.b
    public final void a(final double d) {
        boolean zPF = com.kwad.components.core.e.c.b.pF();
        if (!this.Hu.GH.Aq() || zPF) {
            return;
        }
        this.Iy.b(new AnimatorListenerAdapter() { // from class: com.kwad.components.ad.splashscreen.presenter.o.3
            @Override // android.animation.AnimatorListenerAdapter, android.animation.Animator.AnimatorListener
            public final void onAnimationEnd(Animator animator) {
                super.onAnimationEnd(animator);
                if (o.this.Hu != null) {
                    o.this.Hu.a(1, o.this.getContext(), 157, 2, new com.kwad.components.ad.splashscreen.h.a() { // from class: com.kwad.components.ad.splashscreen.presenter.o.3.1
                        @Override // com.kwad.components.ad.splashscreen.h.a
                        public final void b(com.kwad.sdk.core.adlog.c.b bVar) {
                            bVar.j(d);
                        }
                    });
                }
                o.this.Iy.oa();
            }
        });
        by.a(getContext(), this.ho);
        mL();
    }

    @Override // com.kwad.sdk.core.g.b
    public final void cf() {
        com.kwad.sdk.core.adlog.c.cs(this.Hu.mAdTemplate);
    }

    @Override // android.view.View.OnClickListener
    public final void onClick(View view) {
        com.kwad.sdk.core.d.c.d("SplashShakePresenter", "onClick: " + view);
        if (!view.equals(this.Iy) || this.Hu == null || this.Hu.mAdTemplate == null || !com.kwad.sdk.core.response.helper.b.es(com.kwad.sdk.core.response.helper.e.eM(this.Hu.mAdTemplate))) {
            return;
        }
        this.Hu.c(1, getContext(), 158, 1);
    }

    @Override // com.kwad.sdk.widget.d
    public final void a(View view) {
        com.kwad.sdk.core.d.c.d("SplashShakePresenter", "onSingleTap: " + view);
        if (com.kwad.sdk.core.response.helper.b.es(com.kwad.sdk.core.response.helper.e.eM(this.Hu.mAdTemplate)) && this.Hu != null) {
            this.Hu.c(1, getContext(), 158, 1);
        }
    }

    @Override // com.kwad.sdk.widget.d
    public final void a(View view, float f, float f2, float f3, float f4) {
        com.kwad.sdk.core.d.c.d("SplashShakePresenter", "onSlide: enableSlickClick: " + this.Hk);
        if (SlideConvertHelper.a(this.Hu.mAdTemplate, f, f2, f3, f4) && this.Hu != null) {
            this.Hu.c(1, view.getContext(), MediaPlayer.MEDIA_PLAYER_OPTION_GET_DROP_COUNT, 1);
        }
    }

    @Override // com.kwad.components.ad.splashscreen.g
    public final void ma() {
        com.kwad.sdk.core.g.d dVar = this.hm;
        if (dVar != null) {
            dVar.cb(getContext());
        }
    }
}
