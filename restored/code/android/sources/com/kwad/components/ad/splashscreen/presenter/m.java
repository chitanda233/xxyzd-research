package com.kwad.components.ad.splashscreen.presenter;

import android.content.Context;
import android.os.SystemClock;
import android.view.View;
import android.view.ViewStub;
import android.widget.TextView;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.kwad.components.ad.splashscreen.widget.KsRotateView;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdMatrixInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.utils.bi;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class m extends i implements View.OnClickListener, com.kwad.components.ad.splashscreen.g, com.kwad.sdk.core.g.a {
    private TextView HW;
    private com.kwad.components.ad.splashscreen.d Ib;
    private View Iq;
    private KsRotateView Ir;
    private TextView Is;
    private com.kwad.sdk.core.g.c hn;
    private long mStartTime;

    @Override // com.kwad.components.ad.splashscreen.g
    public final void am(int i) {
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.i
    protected final void initView() {
        this.mStartTime = SystemClock.elapsedRealtime();
        ViewStub viewStub = (ViewStub) findViewById(R.id.ksad_rotate_layout);
        if (viewStub != null) {
            this.Iq = viewStub.inflate();
        } else {
            this.Iq = findViewById(R.id.ksad_rotate_root);
        }
        this.Is = (TextView) findViewById(R.id.ksad_rotate_text);
        this.HW = (TextView) findViewById(R.id.ksad_rotate_action);
        KsRotateView ksRotateView = (KsRotateView) findViewById(R.id.ksad_rotate_view);
        this.Ir = ksRotateView;
        ksRotateView.setOnClickListener(this);
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.i
    protected final void mH() {
        AdTemplate adTemplate = this.Hu.mAdTemplate;
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
        this.Ib = com.kwad.components.ad.splashscreen.d.a(adTemplate, adInfoEM, this.Hu.mApkDownloadHelper, 1);
        TextView textView = this.Is;
        if (textView != null) {
            textView.setText(com.kwad.sdk.core.response.helper.b.dR(adInfoEM));
        }
        TextView textView2 = this.HW;
        if (textView2 != null) {
            textView2.setText("或点击" + this.Ib.lU());
        }
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.i
    protected final void mI() {
        if (this.Iq == null || this.Hu == null) {
            return;
        }
        this.Iq.setVisibility(0);
        com.kwad.sdk.core.adlog.c.b(this.Hu.mAdTemplate, MediaPlayer.MEDIA_PLAYER_OPTION_HW_CONTROL_BY_OPPO, (JSONObject) null);
        com.kwad.components.core.webview.tachikoma.e.a.zM().cb(MediaPlayer.MEDIA_PLAYER_OPTION_HW_CONTROL_BY_OPPO);
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.i
    protected final void mJ() {
        AdMatrixInfo.RotateInfo rotateInfoDG = com.kwad.sdk.core.response.helper.b.dG(this.Hu.mAdTemplate);
        com.kwad.sdk.core.g.c cVar = this.hn;
        if (cVar == null) {
            com.kwad.sdk.core.g.c cVar2 = new com.kwad.sdk.core.g.c(rotateInfoDG);
            this.hn = cVar2;
            cVar2.a(this);
            return;
        }
        cVar.b(rotateInfoDG);
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.i
    protected final void mK() {
        com.kwad.sdk.core.g.c cVar = this.hn;
        if (cVar != null) {
            cVar.ca(mP());
        }
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.i
    protected final void mL() {
        com.kwad.sdk.core.g.c cVar = this.hn;
        if (cVar != null) {
            cVar.cb(mP());
        }
    }

    private Context mP() {
        Context context;
        View view;
        try {
            context = getContext();
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTrace(th);
            context = null;
        }
        return (context != null || (view = this.Iq) == null) ? context : view.getContext();
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.i
    protected final void fW() {
        KsRotateView ksRotateView = this.Ir;
        if (ksRotateView == null) {
            return;
        }
        ksRotateView.post(new bi() { // from class: com.kwad.components.ad.splashscreen.presenter.m.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                m.this.Ir.fW();
            }
        });
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.i
    protected final void i(int i, String str) {
        TextView textView = this.HW;
        if (textView != null) {
            if (i == 2) {
                textView.setText(str);
            } else {
                textView.setText("或点击" + str);
            }
        }
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.i, com.kwad.components.ad.splashscreen.presenter.e, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        View rootView = getRootView();
        if (rootView == null) {
            return;
        }
        rootView.post(new bi() { // from class: com.kwad.components.ad.splashscreen.presenter.m.2
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                if (m.this.Hu != null) {
                    m.this.Hu.GW = SystemClock.elapsedRealtime() - m.this.mStartTime;
                }
            }
        });
        if (this.Hu != null) {
            this.Hu.a(this);
        }
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.i, com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        com.kwad.sdk.core.d.c.d("SplashRotatePresenter", "onUnbind");
        if (this.Hu != null) {
            this.Hu.b(this);
        }
    }

    @Override // com.kwad.sdk.core.g.a
    public final void r(final String str) {
        boolean zAq = this.Hu.GH.Aq();
        boolean zPF = com.kwad.components.core.e.c.b.pF();
        if (!zAq || zPF) {
            return;
        }
        this.Ir.nZ();
        if (this.Hu != null) {
            this.Hu.a(1, mP(), 161, 2, new com.kwad.components.ad.splashscreen.h.a() { // from class: com.kwad.components.ad.splashscreen.presenter.m.3
                @Override // com.kwad.components.ad.splashscreen.h.a
                public final void b(com.kwad.sdk.core.adlog.c.b bVar) {
                    bVar.ed(str);
                }
            });
        }
        mN();
        mL();
    }

    @Override // com.kwad.sdk.core.g.a
    public final void cg() {
        com.kwad.sdk.core.adlog.c.cs(this.Hu.mAdTemplate);
    }

    @Override // com.kwad.components.ad.splashscreen.g
    public final void ma() {
        com.kwad.sdk.core.g.c cVar = this.hn;
        if (cVar != null) {
            cVar.cb(mP());
        }
    }

    @Override // android.view.View.OnClickListener
    public final void onClick(View view) {
        this.Hu.c(1, mP(), 162, 1);
    }
}
