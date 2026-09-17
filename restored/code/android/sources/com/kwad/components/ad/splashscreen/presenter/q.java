package com.kwad.components.ad.splashscreen.presenter;

import android.content.Context;
import android.os.SystemClock;
import android.text.TextUtils;
import android.view.MotionEvent;
import android.view.View;
import android.view.ViewStub;
import android.widget.TextView;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.kwad.components.ad.splashscreen.widget.KsSlideHandView;
import com.kwad.components.ad.splashscreen.widget.KsSlideRoundView;
import com.kwad.components.ad.splashscreen.widget.KsSplashSlidePathView;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.helper.SlideConvertHelper;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdMatrixInfo;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class q extends e {
    private com.kwad.components.ad.splashscreen.e.a HN;
    private KsSlideRoundView HX;
    private KsSplashSlidePathView HY;
    private com.kwad.components.core.e.d.d IH;
    private View IQ;
    private TextView IR;
    private KsSlideHandView IS;
    private double Ie;
    private AdMatrixInfo.SplashSlideInfo If;
    private float Ig;
    private float Ih;
    private float Ii;
    private float Ij;
    private float Ik;
    private boolean Il = false;
    private boolean Im = false;
    private float mActionBarHeight;
    private AdInfo mAdInfo;
    private long mStartTime;

    static /* synthetic */ boolean a(q qVar, boolean z) {
        qVar.Im = true;
        return true;
    }

    static /* synthetic */ boolean b(q qVar, boolean z) {
        qVar.Il = true;
        return true;
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.mStartTime = SystemClock.elapsedRealtime();
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.e, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        if (this.Hu == null) {
            return;
        }
        this.mAdInfo = com.kwad.sdk.core.response.helper.e.eM(this.Hu.mAdTemplate);
        this.IH = this.Hu.mApkDownloadHelper;
        AdMatrixInfo.SplashSlideInfo splashSlideInfo = this.mAdInfo.adMatrixInfo.adDataV2.splashInfo.interactionInfo.slideInfo;
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
            ksSplashSlidePathView.setOnSlideTouchListener(new KsSplashSlidePathView.a() { // from class: com.kwad.components.ad.splashscreen.presenter.q.1
                @Override // com.kwad.components.ad.splashscreen.widget.KsSplashSlidePathView.a
                public final void a(float f, float f2, float f3, float f4) {
                    final float fPx2dip = com.kwad.sdk.c.a.a.px2dip(q.this.mP(), (float) Math.sqrt(Math.pow(f3 - f, 2.0d) + Math.pow(f4 - f2, 2.0d)));
                    if (!SlideConvertHelper.a(q.this.Hu.mAdTemplate, f, f2, f3, f4) || q.this.Hu == null) {
                        return;
                    }
                    q.this.Hu.a(1, q.this.mP(), MediaPlayer.MEDIA_PLAYER_OPTION_GET_DROP_COUNT, 2, new com.kwad.components.ad.splashscreen.h.a() { // from class: com.kwad.components.ad.splashscreen.presenter.q.1.1
                        @Override // com.kwad.components.ad.splashscreen.h.a
                        public final void b(com.kwad.sdk.core.adlog.c.b bVar) {
                            bVar.ec(q.this.If.style);
                            bVar.ed((int) fPx2dip);
                        }
                    });
                }

                @Override // com.kwad.components.ad.splashscreen.widget.KsSplashSlidePathView.a
                public final void c(MotionEvent motionEvent) {
                    if (q.this.Il && q.this.Im) {
                        float x = motionEvent.getX() + q.this.Ii;
                        float y = motionEvent.getY() + q.this.Ij;
                        if (x >= q.this.Ig && x <= q.this.Ig + q.this.Ik && y >= q.this.Ih && y <= q.this.Ih + q.this.mActionBarHeight) {
                            q.this.mO();
                            return;
                        }
                    }
                    if (com.kwad.components.ad.splashscreen.h.o(q.this.mAdInfo)) {
                        q.this.mO();
                    }
                }
            });
            this.HY.post(new bi() { // from class: com.kwad.components.ad.splashscreen.presenter.q.2
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    int[] iArr = new int[2];
                    q.this.HY.getLocationOnScreen(iArr);
                    q.this.Ii = iArr[0];
                    q.this.Ij = iArr[1];
                    q.a(q.this, true);
                }
            });
        }
        by.postOnUiThread(new bi() { // from class: com.kwad.components.ad.splashscreen.presenter.q.3
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                q.this.Hu.GW = SystemClock.elapsedRealtime() - q.this.mStartTime;
            }
        });
        initView();
        if (com.kwad.sdk.core.response.helper.a.aL(this.mAdInfo)) {
            mX();
        }
        aq();
        jo();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void mO() {
        if (this.Hu != null) {
            this.Hu.c(1, mP(), 53, 2);
        }
    }

    private void initView() {
        ViewStub viewStub = (ViewStub) findViewById(R.id.ksad_slide_combo_layout);
        if (viewStub != null) {
            this.IQ = viewStub.inflate();
        } else {
            this.IQ = findViewById(R.id.ksad_slide_combo_root);
        }
        this.IS = (KsSlideHandView) findViewById(R.id.ksad_slide_combo_slide_hand);
        this.IR = (TextView) findViewById(R.id.ksad_slide_combo_action_sub_text);
        this.HX = (KsSlideRoundView) findViewById(R.id.ksad_slide_combo_round_bg);
        this.IR.setText(mW());
        this.HX.post(new bi() { // from class: com.kwad.components.ad.splashscreen.presenter.q.4
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                int[] iArr = new int[2];
                q.this.HX.getLocationOnScreen(iArr);
                q.this.Ig = iArr[0];
                q.this.Ih = iArr[1];
                q qVar = q.this;
                qVar.Ik = qVar.HX.getWidth();
                q qVar2 = q.this;
                qVar2.mActionBarHeight = qVar2.HX.getHeight();
                q.b(q.this, true);
            }
        });
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
        return (context != null || (view = this.IQ) == null) ? context : view.getContext();
    }

    private void aq() {
        if (this.IQ == null || this.Hu == null) {
            return;
        }
        this.IQ.setVisibility(0);
        com.kwad.sdk.core.adlog.c.b(this.Hu.mAdTemplate, MediaPlayer.MEDIA_PLAYER_OPTION_VIDEO_RANGE_SIZE, (JSONObject) null);
        com.kwad.components.core.webview.tachikoma.e.a.zM().cb(MediaPlayer.MEDIA_PLAYER_OPTION_VIDEO_RANGE_SIZE);
    }

    private void mX() {
        com.kwad.components.ad.splashscreen.e.a aVar = this.HN;
        if (aVar == null) {
            com.kwad.components.ad.splashscreen.e.a aVar2 = new com.kwad.components.ad.splashscreen.e.a(mP(), this.Hu.mAdTemplate) { // from class: com.kwad.components.ad.splashscreen.presenter.q.5
                {
                    super(adTemplate);
                }

                @Override // com.kwad.components.ad.splashscreen.e.a
                public final void j(int i, String str) {
                    if (q.this.IR != null) {
                        q.this.IR.setText(str);
                    }
                }
            };
            this.HN = aVar2;
            this.IH.b(aVar2);
            return;
        }
        aVar.setAdTemplate(this.Hu.mAdTemplate);
    }

    private String mW() {
        try {
            return TextUtils.isEmpty(com.kwad.sdk.core.response.helper.b.dV(this.mAdInfo)) ? com.kwad.sdk.core.response.helper.b.dV(this.mAdInfo) : "跳转详情页或第三方应用";
        } catch (Exception unused) {
            return "跳转详情页或第三方应用";
        }
    }

    private void jo() {
        KsSlideHandView ksSlideHandView = this.IS;
        if (ksSlideHandView != null) {
            ksSlideHandView.fW();
        }
        KsSlideRoundView ksSlideRoundView = this.HX;
        if (ksSlideRoundView != null) {
            ksSlideRoundView.fW();
        }
    }
}
