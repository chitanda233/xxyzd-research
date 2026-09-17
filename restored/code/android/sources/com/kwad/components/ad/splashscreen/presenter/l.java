package com.kwad.components.ad.splashscreen.presenter;

import android.content.Context;
import android.os.SystemClock;
import android.view.MotionEvent;
import android.view.View;
import android.view.ViewStub;
import android.widget.TextView;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.kwad.components.ad.splashscreen.widget.KsRotateTypeTwoView;
import com.kwad.components.ad.splashscreen.widget.KsSlideArrowView;
import com.kwad.components.ad.splashscreen.widget.KsSlideRoundView;
import com.kwad.components.ad.splashscreen.widget.KsSplashSlidePathView;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.helper.SlideConvertHelper;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdMatrixInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.utils.bi;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class l extends i implements View.OnClickListener, com.kwad.components.ad.splashscreen.g, com.kwad.sdk.core.g.a {
    private TextView HW;
    private KsSlideRoundView HX;
    private KsSplashSlidePathView HY;
    private KsRotateTypeTwoView HZ;
    private View Ia;
    private com.kwad.components.ad.splashscreen.d Ib;
    private KsSlideArrowView Ic;
    private KsSlideArrowView Id;
    private double Ie;
    private AdMatrixInfo.SplashSlideInfo If;
    private float Ig;
    private float Ih;
    private float Ii;
    private float Ij;
    private float Ik;
    private boolean Il = false;
    private boolean Im = false;
    private com.kwad.sdk.core.g.c hn;
    private float mActionBarHeight;
    private AdInfo mAdInfo;
    private long mStartTime;

    @Override // com.kwad.components.ad.splashscreen.g
    public final void am(int i) {
    }

    static /* synthetic */ boolean a(l lVar, boolean z) {
        lVar.Im = true;
        return true;
    }

    static /* synthetic */ boolean b(l lVar, boolean z) {
        lVar.Il = true;
        return true;
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.i, com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.i, com.kwad.components.ad.splashscreen.presenter.e, com.kwad.sdk.mvp.Presenter
    public final void av() {
        View rootView;
        this.mStartTime = SystemClock.elapsedRealtime();
        super.av();
        if (this.Hu == null || (rootView = getRootView()) == null) {
            return;
        }
        rootView.post(new bi() { // from class: com.kwad.components.ad.splashscreen.presenter.l.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                if (l.this.Hu != null) {
                    l.this.Hu.GW = SystemClock.elapsedRealtime() - l.this.mStartTime;
                }
            }
        });
        this.Hu.a(this);
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(this.Hu.mAdTemplate);
        this.mAdInfo = adInfoEM;
        try {
            AdMatrixInfo.SplashSlideInfo splashSlideInfo = adInfoEM.adMatrixInfo.adDataV2.splashInfo.interactionInfo.slideInfo;
            this.If = splashSlideInfo;
            this.Ie = splashSlideInfo.convertDistance;
            ViewStub viewStub = (ViewStub) findViewById(R.id.ksad_splash_slideTouchView);
            if (viewStub != null) {
                this.HY = (KsSplashSlidePathView) viewStub.inflate();
            } else {
                this.HY = (KsSplashSlidePathView) findViewById(R.id.ksad_splash_slideview_root);
            }
            KsSplashSlidePathView ksSplashSlidePathView = this.HY;
            if (ksSplashSlidePathView != null) {
                ksSplashSlidePathView.setOnSlideTouchListener(new KsSplashSlidePathView.a() { // from class: com.kwad.components.ad.splashscreen.presenter.l.2
                    @Override // com.kwad.components.ad.splashscreen.widget.KsSplashSlidePathView.a
                    public final void a(float f, float f2, float f3, float f4) {
                        final float fPx2dip = com.kwad.sdk.c.a.a.px2dip(l.this.mP(), (float) Math.sqrt(Math.pow(f3 - f, 2.0d) + Math.pow(f4 - f2, 2.0d)));
                        if (!SlideConvertHelper.a(l.this.Hu.mAdTemplate, f, f2, f3, f4) || l.this.Hu == null) {
                            return;
                        }
                        l.this.Hu.a(1, l.this.mP(), MediaPlayer.MEDIA_PLAYER_OPTION_GET_DROP_COUNT, 2, new com.kwad.components.ad.splashscreen.h.a() { // from class: com.kwad.components.ad.splashscreen.presenter.l.2.1
                            @Override // com.kwad.components.ad.splashscreen.h.a
                            public final void b(com.kwad.sdk.core.adlog.c.b bVar) {
                                bVar.ec(l.this.If.style);
                                bVar.ed((int) fPx2dip);
                            }
                        });
                    }

                    @Override // com.kwad.components.ad.splashscreen.widget.KsSplashSlidePathView.a
                    public final void c(MotionEvent motionEvent) {
                        if (l.this.Il && l.this.Im) {
                            float x = motionEvent.getX() + l.this.Ii;
                            float y = motionEvent.getY() + l.this.Ij;
                            if (x >= l.this.Ig && x <= l.this.Ig + l.this.Ik && y >= l.this.Ih && y <= l.this.Ih + l.this.mActionBarHeight) {
                                l.this.mO();
                                return;
                            }
                        }
                        if (com.kwad.components.ad.splashscreen.h.o(l.this.mAdInfo)) {
                            l.this.mO();
                        }
                    }
                });
                this.HY.post(new bi() { // from class: com.kwad.components.ad.splashscreen.presenter.l.3
                    @Override // com.kwad.sdk.utils.bi
                    public final void doTask() {
                        int[] iArr = new int[2];
                        l.this.HY.getLocationOnScreen(iArr);
                        l.this.Ii = iArr[0];
                        l.this.Ij = iArr[1];
                        l.a(l.this, true);
                    }
                });
            }
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTrace(e);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void mO() {
        if (this.Hu != null) {
            this.Hu.c(1, mP(), 53, 2);
        }
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.i, com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        com.kwad.sdk.core.d.c.d("SplashRotateComboPresenter", "onUnbind");
        if (this.Hu != null) {
            this.Hu.b(this);
        }
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.i
    protected final void initView() {
        ViewStub viewStub = (ViewStub) findViewById(R.id.ksad_rotate_combo_layout);
        if (viewStub != null) {
            this.Ia = viewStub.inflate();
        } else {
            this.Ia = findViewById(R.id.ksad_rotate_combo_root);
        }
        this.HX = (KsSlideRoundView) findViewById(R.id.ksad_rotate_combo_slide_round_img);
        this.HW = (TextView) findViewById(R.id.ksad_rotate_combo_action_text);
        this.HZ = (KsRotateTypeTwoView) findViewById(R.id.ksad_rotate_combo_rotate_view);
        this.Ic = (KsSlideArrowView) findViewById(R.id.ksad_rotate_combo_slide_arrow_top);
        this.Id = (KsSlideArrowView) findViewById(R.id.ksad_rotate_combo_slide_arrow_bottom);
        this.Ic.setAnimationDelayTime(200);
        this.Id.setAnimationDelayTime(200);
        this.HX.post(new bi() { // from class: com.kwad.components.ad.splashscreen.presenter.l.4
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                int[] iArr = new int[2];
                l.this.HX.getLocationOnScreen(iArr);
                l.this.Ig = iArr[0];
                l.this.Ih = iArr[1];
                l lVar = l.this;
                lVar.Ik = lVar.HX.getWidth();
                l lVar2 = l.this;
                lVar2.mActionBarHeight = lVar2.HX.getHeight();
                l.b(l.this, true);
            }
        });
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.i
    protected final void mH() {
        AdTemplate adTemplate = this.Hu.mAdTemplate;
        com.kwad.components.ad.splashscreen.d dVarA = com.kwad.components.ad.splashscreen.d.a(adTemplate, com.kwad.sdk.core.response.helper.e.eM(adTemplate), this.Hu.mApkDownloadHelper, 10);
        this.Ib = dVarA;
        TextView textView = this.HW;
        if (textView != null) {
            textView.setText(dVarA.lU());
        }
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.i
    protected final void mI() {
        if (this.Ia == null || this.Hu == null) {
            return;
        }
        this.Ia.setVisibility(0);
        com.kwad.sdk.core.adlog.c.b(this.Hu.mAdTemplate, 200, (JSONObject) null);
        com.kwad.components.core.webview.tachikoma.e.a.zM().cb(200);
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.i
    protected final void mJ() {
        AdMatrixInfo.RotateInfo rotateInfoDG = com.kwad.sdk.core.response.helper.b.dG(this.Hu.mAdTemplate);
        com.kwad.sdk.core.g.c cVar = this.hn;
        if (cVar == null) {
            com.kwad.sdk.core.g.c cVar2 = new com.kwad.sdk.core.g.c(rotateInfoDG);
            this.hn = cVar2;
            cVar2.a(this);
        } else {
            cVar.b(rotateInfoDG);
        }
        KsRotateTypeTwoView ksRotateTypeTwoView = this.HZ;
        if (ksRotateTypeTwoView != null) {
            ksRotateTypeTwoView.setOnClickListener(this);
        }
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

    protected final Context mP() {
        Context context;
        View view;
        try {
            context = getContext();
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTrace(th);
            context = null;
        }
        return (context != null || (view = this.Ia) == null) ? context : view.getContext();
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.i
    protected final void fW() {
        KsSlideArrowView ksSlideArrowView = this.Ic;
        if (ksSlideArrowView != null && this.Id != null) {
            ksSlideArrowView.postDelayed(new bi() { // from class: com.kwad.components.ad.splashscreen.presenter.l.5
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    l.this.Ic.fW();
                }
            }, 200L);
            this.Id.post(new bi() { // from class: com.kwad.components.ad.splashscreen.presenter.l.6
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    l.this.Id.fW();
                }
            });
        }
        KsRotateTypeTwoView ksRotateTypeTwoView = this.HZ;
        if (ksRotateTypeTwoView != null) {
            ksRotateTypeTwoView.post(new bi() { // from class: com.kwad.components.ad.splashscreen.presenter.l.7
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    l.this.HZ.fW();
                }
            });
        }
        KsSlideRoundView ksSlideRoundView = this.HX;
        if (ksSlideRoundView != null) {
            ksSlideRoundView.post(new bi() { // from class: com.kwad.components.ad.splashscreen.presenter.l.8
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    l.this.HX.fW();
                }
            });
        }
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.i
    protected final void i(int i, String str) {
        if (this.HW != null) {
            if (i != 2) {
                str = "扭动或点击" + str;
            }
            this.HW.setText(str);
        }
    }

    @Override // android.view.View.OnClickListener
    public final void onClick(View view) {
        if (this.Hu != null) {
            this.Hu.c(1, mP(), 162, 1);
        }
    }

    @Override // com.kwad.components.ad.splashscreen.g
    public final void ma() {
        com.kwad.sdk.core.g.c cVar = this.hn;
        if (cVar != null) {
            cVar.cb(mP());
        }
    }

    @Override // com.kwad.sdk.core.g.a
    public final void r(final String str) {
        boolean zAq = this.Hu.GH.Aq();
        boolean zPF = com.kwad.components.core.e.c.b.pF();
        if (!zAq || zPF) {
            return;
        }
        this.Ic.nZ();
        this.Id.nZ();
        this.HX.nZ();
        this.HZ.nZ();
        if (this.Hu != null) {
            this.Hu.a(1, mP(), 161, 2, new com.kwad.components.ad.splashscreen.h.a() { // from class: com.kwad.components.ad.splashscreen.presenter.l.9
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
}
