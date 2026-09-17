package com.kwad.components.ad.splashscreen.presenter;

import android.animation.Animator;
import android.animation.AnimatorListenerAdapter;
import android.content.Context;
import android.os.SystemClock;
import android.os.Vibrator;
import android.view.MotionEvent;
import android.view.View;
import android.view.ViewStub;
import android.widget.ImageView;
import android.widget.TextView;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.kwad.components.ad.splashscreen.widget.KsButtonBorderSpreadView;
import com.kwad.components.ad.splashscreen.widget.KsShakeView;
import com.kwad.components.ad.splashscreen.widget.KsSlideArrowView;
import com.kwad.components.ad.splashscreen.widget.KsSlidePopUpView;
import com.kwad.components.ad.splashscreen.widget.KsSplashSlidePathView;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.helper.SlideConvertHelper;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdMatrixInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class n extends i implements View.OnClickListener, com.kwad.components.ad.splashscreen.g, com.kwad.sdk.core.g.b {
    private KsSplashSlidePathView HY;
    private ImageView IA;
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
    private TextView Iu;
    private TextView Iv;
    private KsSlidePopUpView Iw;
    private KsButtonBorderSpreadView Ix;
    private KsShakeView Iy;
    private View Iz;
    private com.kwad.sdk.core.g.d hm;
    private Vibrator ho;
    private float mActionBarHeight;
    private AdInfo mAdInfo;
    private long mStartTime;

    @Override // com.kwad.components.ad.splashscreen.g
    public final void am(int i) {
    }

    static /* synthetic */ boolean a(n nVar, boolean z) {
        nVar.Im = true;
        return true;
    }

    static /* synthetic */ boolean b(n nVar, boolean z) {
        nVar.Il = true;
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
        rootView.post(new bi() { // from class: com.kwad.components.ad.splashscreen.presenter.n.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                if (n.this.Hu != null) {
                    n.this.Hu.GW = SystemClock.elapsedRealtime() - n.this.mStartTime;
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
                ksSplashSlidePathView.setOnSlideTouchListener(new KsSplashSlidePathView.a() { // from class: com.kwad.components.ad.splashscreen.presenter.n.3
                    @Override // com.kwad.components.ad.splashscreen.widget.KsSplashSlidePathView.a
                    public final void a(float f, float f2, float f3, float f4) {
                        final float fPx2dip = com.kwad.sdk.c.a.a.px2dip(n.this.mP(), (float) Math.sqrt(Math.pow(f3 - f, 2.0d) + Math.pow(f4 - f2, 2.0d)));
                        if (!SlideConvertHelper.a(n.this.Hu.mAdTemplate, f, f2, f3, f4) || n.this.Hu == null) {
                            return;
                        }
                        n.this.Hu.a(1, n.this.mP(), MediaPlayer.MEDIA_PLAYER_OPTION_GET_DROP_COUNT, 2, new com.kwad.components.ad.splashscreen.h.a() { // from class: com.kwad.components.ad.splashscreen.presenter.n.3.1
                            @Override // com.kwad.components.ad.splashscreen.h.a
                            public final void b(com.kwad.sdk.core.adlog.c.b bVar) {
                                bVar.ec(n.this.If.style);
                                bVar.ed((int) fPx2dip);
                            }
                        });
                    }

                    @Override // com.kwad.components.ad.splashscreen.widget.KsSplashSlidePathView.a
                    public final void c(MotionEvent motionEvent) {
                        if (n.this.Il && n.this.Im) {
                            float x = motionEvent.getX() + n.this.Ii;
                            float y = motionEvent.getY() + n.this.Ij;
                            if (x >= n.this.Ig && x <= n.this.Ig + n.this.Ik && y >= n.this.Ih && y <= n.this.Ih + n.this.mActionBarHeight) {
                                n.this.mO();
                                return;
                            }
                        }
                        if (com.kwad.components.ad.splashscreen.h.o(n.this.mAdInfo)) {
                            n.this.mO();
                        }
                    }
                });
                this.HY.post(new bi() { // from class: com.kwad.components.ad.splashscreen.presenter.n.4
                    @Override // com.kwad.sdk.utils.bi
                    public final void doTask() {
                        int[] iArr = new int[2];
                        n.this.HY.getLocationOnScreen(iArr);
                        n.this.Ii = iArr[0];
                        n.this.Ij = iArr[1];
                        n.a(n.this, true);
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
        com.kwad.sdk.core.d.c.d("SplashShakeComboPresenter", "onUnbind");
        if (this.Hu != null) {
            this.Hu.b(this);
        }
        KsShakeView ksShakeView = this.Iy;
        if (ksShakeView != null) {
            ksShakeView.ob();
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
        return (context != null || (view = this.Iz) == null) ? context : view.getContext();
    }

    @Override // android.view.View.OnClickListener
    public final void onClick(View view) {
        if (this.Hu != null) {
            this.Hu.c(1, mP(), 158, 1);
        }
    }

    @Override // com.kwad.components.ad.splashscreen.g
    public final void ma() {
        com.kwad.sdk.core.g.d dVar = this.hm;
        if (dVar != null) {
            dVar.cb(mP());
        }
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.i
    protected final void initView() {
        Context contextMP = mP();
        if (contextMP != null) {
            this.ho = (Vibrator) contextMP.getSystemService("vibrator");
        }
        ViewStub viewStub = (ViewStub) findViewById(R.id.ksad_shake_combo_layout);
        if (viewStub != null) {
            this.Iz = viewStub.inflate();
        } else {
            this.Iz = findViewById(R.id.ksad_shake_combo_root);
        }
        this.Iw = (KsSlidePopUpView) findViewById(R.id.ksad_shake_combo_slide_popup_view);
        this.Iu = (TextView) findViewById(R.id.ksad_shake_combo_shake_main_text);
        this.Iv = (TextView) findViewById(R.id.ksad_shake_combo_sub_text);
        this.Iy = (KsShakeView) findViewById(R.id.ksad_shake_combo_shake_icon);
        this.Ic = (KsSlideArrowView) findViewById(R.id.ksad_shake_combo_slide_arrow_top);
        this.Id = (KsSlideArrowView) findViewById(R.id.ksad_shake_combo_slide_arrow_bottom);
        this.Ix = (KsButtonBorderSpreadView) findViewById(R.id.ksad_shake_combo_button_spread);
        ImageView imageView = (ImageView) findViewById(R.id.ksad_shake_combo_button_background);
        this.IA = imageView;
        imageView.post(new bi() { // from class: com.kwad.components.ad.splashscreen.presenter.n.5
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                int[] iArr = new int[2];
                n.this.IA.getLocationOnScreen(iArr);
                n.this.Ig = iArr[0];
                n.this.Ih = iArr[1];
                n nVar = n.this;
                nVar.Ik = nVar.IA.getWidth();
                n nVar2 = n.this;
                nVar2.mActionBarHeight = nVar2.IA.getHeight();
                n.b(n.this, true);
            }
        });
        this.Ic.setAnimationDelayTime(500);
        this.Id.setAnimationDelayTime(500);
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.i
    protected final void mH() {
        AdTemplate adTemplate = this.Hu.mAdTemplate;
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
        this.Ib = com.kwad.components.ad.splashscreen.d.a(adTemplate, adInfoEM, this.Hu.mApkDownloadHelper, 9);
        TextView textView = this.Iu;
        if (textView != null) {
            textView.setText(com.kwad.sdk.core.response.helper.b.dS(adInfoEM));
        }
        TextView textView2 = this.Iv;
        if (textView2 != null) {
            textView2.setText(this.Ib.lU());
        }
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.i
    protected final void mI() {
        if (this.Iz == null || this.Hu == null) {
            return;
        }
        this.Iz.setVisibility(0);
        com.kwad.sdk.core.adlog.c.b(this.Hu.mAdTemplate, MediaPlayer.MEDIA_PLAYER_OPTION_SKIP_AUDIO_GRAPH, (JSONObject) null);
        com.kwad.components.core.webview.tachikoma.e.a.zM().cb(MediaPlayer.MEDIA_PLAYER_OPTION_SKIP_AUDIO_GRAPH);
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
        } else {
            dVar.m(fDF);
        }
        KsShakeView ksShakeView = this.Iy;
        if (ksShakeView != null) {
            ksShakeView.setOnClickListener(this);
        }
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.i
    protected final void mK() {
        com.kwad.sdk.core.g.d dVar = this.hm;
        if (dVar != null) {
            dVar.ca(mP());
        }
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.i
    protected final void mL() {
        com.kwad.sdk.core.g.d dVar = this.hm;
        if (dVar != null) {
            dVar.cb(mP());
        }
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.i
    protected final void fW() {
        KsShakeView ksShakeView = this.Iy;
        if (ksShakeView != null) {
            ksShakeView.post(new bi() { // from class: com.kwad.components.ad.splashscreen.presenter.n.6
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    n.this.Iy.oa();
                }
            });
        }
        KsSlidePopUpView ksSlidePopUpView = this.Iw;
        if (ksSlidePopUpView != null) {
            ksSlidePopUpView.post(new bi() { // from class: com.kwad.components.ad.splashscreen.presenter.n.7
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    n.this.Iw.oc();
                }
            });
        }
        KsButtonBorderSpreadView ksButtonBorderSpreadView = this.Ix;
        if (ksButtonBorderSpreadView != null) {
            ksButtonBorderSpreadView.postDelayed(new bi() { // from class: com.kwad.components.ad.splashscreen.presenter.n.8
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    n.this.Ix.fW();
                }
            }, 300L);
        }
        KsSlideArrowView ksSlideArrowView = this.Ic;
        if (ksSlideArrowView != null) {
            ksSlideArrowView.postDelayed(new bi() { // from class: com.kwad.components.ad.splashscreen.presenter.n.9
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    n.this.Ic.fW();
                }
            }, 1000L);
        }
        KsSlideArrowView ksSlideArrowView2 = this.Id;
        if (ksSlideArrowView2 != null) {
            ksSlideArrowView2.postDelayed(new bi() { // from class: com.kwad.components.ad.splashscreen.presenter.n.10
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    n.this.Id.fW();
                }
            }, 800L);
        }
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.i
    protected final void i(int i, String str) {
        if (this.Iv != null) {
            if (i != 2) {
                str = "或点击" + str;
            }
            this.Iv.setText(str);
        }
    }

    @Override // com.kwad.sdk.core.g.b
    public final void a(final double d) {
        boolean zPF = com.kwad.components.core.e.c.b.pF();
        if (!this.Hu.GH.Aq() || zPF) {
            return;
        }
        this.Iy.b(new AnimatorListenerAdapter() { // from class: com.kwad.components.ad.splashscreen.presenter.n.2
            @Override // android.animation.AnimatorListenerAdapter, android.animation.Animator.AnimatorListener
            public final void onAnimationEnd(Animator animator) {
                super.onAnimationEnd(animator);
                if (n.this.Hu != null) {
                    n.this.Hu.a(1, n.this.mP(), 157, 2, new com.kwad.components.ad.splashscreen.h.a() { // from class: com.kwad.components.ad.splashscreen.presenter.n.2.1
                        @Override // com.kwad.components.ad.splashscreen.h.a
                        public final void b(com.kwad.sdk.core.adlog.c.b bVar) {
                            bVar.j(d);
                        }
                    });
                }
                n.this.Iy.oa();
            }
        });
        by.a(mP(), this.ho);
        mL();
    }

    @Override // com.kwad.sdk.core.g.b
    public final void cf() {
        com.kwad.sdk.core.adlog.c.cs(this.Hu.mAdTemplate);
    }
}
