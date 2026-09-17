package com.kwad.components.ad.splashscreen.presenter;

import android.content.Context;
import android.os.SystemClock;
import android.text.TextUtils;
import android.view.MotionEvent;
import android.view.View;
import android.view.ViewStub;
import android.widget.ImageView;
import android.widget.TextView;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
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
public final class p extends e {
    private com.kwad.components.ad.splashscreen.e.a HN;
    private KsSlideRoundView HX;
    private KsSplashSlidePathView HY;
    private com.kwad.components.core.e.d.d IH;
    private View II;
    private TextView IJ;
    private TextView IK;
    private ImageView IL;
    private com.kwad.components.ad.splashscreen.widget.d IM;
    private boolean IN = false;
    private boolean IO = false;
    private double Ie;
    private AdMatrixInfo.SplashSlideInfo If;
    private float Ig;
    private float Ih;
    private float Ii;
    private float Ij;
    private float Ik;
    private float mActionBarHeight;
    private AdInfo mAdInfo;
    private long mStartTime;

    static /* synthetic */ boolean a(p pVar, boolean z) {
        pVar.IO = true;
        return true;
    }

    static /* synthetic */ boolean b(p pVar, boolean z) {
        pVar.IN = true;
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
            com.kwad.sdk.core.d.c.w("SplashSlideBackupPresenter", "onBind: mCallerContext is null");
            return;
        }
        if (mQ()) {
            mR();
            mS();
            if (com.kwad.sdk.core.response.helper.a.aL(this.mAdInfo)) {
                mX();
            }
            mY();
            by.postOnUiThread(new bi() { // from class: com.kwad.components.ad.splashscreen.presenter.p.1
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    p.this.Hu.GW = SystemClock.elapsedRealtime() - p.this.mStartTime;
                }
            });
        }
    }

    private boolean mQ() {
        try {
            this.mAdInfo = com.kwad.sdk.core.response.helper.e.eM(this.Hu.mAdTemplate);
            this.IH = this.Hu.mApkDownloadHelper;
            AdMatrixInfo.SplashSlideInfo splashSlideInfo = this.mAdInfo.adMatrixInfo.adDataV2.splashInfo.interactionInfo.slideInfo;
            this.If = splashSlideInfo;
            this.Ie = splashSlideInfo.convertDistance;
            return true;
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(e);
            return false;
        }
    }

    private void mR() {
        ViewStub viewStub = (ViewStub) findViewById(R.id.ksad_splash_slideTouchView);
        if (viewStub != null) {
            this.HY = (KsSplashSlidePathView) viewStub.inflate();
        } else {
            this.HY = (KsSplashSlidePathView) findViewById(R.id.ksad_splash_slideview_root);
        }
        KsSplashSlidePathView ksSplashSlidePathView = this.HY;
        if (ksSplashSlidePathView != null) {
            ksSplashSlidePathView.setOnSlideTouchListener(new KsSplashSlidePathView.a() { // from class: com.kwad.components.ad.splashscreen.presenter.p.2
                @Override // com.kwad.components.ad.splashscreen.widget.KsSplashSlidePathView.a
                public final void a(float f, float f2, float f3, float f4) {
                    p.this.b(f, f2, f3, f4);
                }

                @Override // com.kwad.components.ad.splashscreen.widget.KsSplashSlidePathView.a
                public final void c(MotionEvent motionEvent) {
                    p.this.d(motionEvent);
                }
            });
            this.HY.post(new bi() { // from class: com.kwad.components.ad.splashscreen.presenter.p.3
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    int[] iArr = new int[2];
                    p.this.HY.getLocationOnScreen(iArr);
                    p.this.Ii = iArr[0];
                    p.this.Ij = iArr[1];
                    p.a(p.this, true);
                    com.kwad.sdk.core.d.c.d("SplashSlideBackupPresenter", "SlidePathView position: x=" + p.this.Ii + ", y=" + p.this.Ij);
                }
            });
        }
    }

    private void mS() {
        ViewStub viewStub = (ViewStub) findViewById(R.id.ksad_slide_backup_layout);
        if (viewStub != null) {
            this.II = viewStub.inflate();
        } else {
            this.II = findViewById(R.id.ksad_slide_backup_root);
        }
        this.IJ = (TextView) findViewById(R.id.ksad_slide_backup_title);
        this.IK = (TextView) findViewById(R.id.ksad_slide_backup_sub_title);
        this.IL = (ImageView) findViewById(R.id.ksad_slide_backup_hand);
        this.HX = (KsSlideRoundView) findViewById(R.id.ksad_slide_backup_round_bg);
        mT();
        mU();
        KsSlideRoundView ksSlideRoundView = this.HX;
        if (ksSlideRoundView != null) {
            ksSlideRoundView.post(new bi() { // from class: com.kwad.components.ad.splashscreen.presenter.p.4
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    int[] iArr = new int[2];
                    p.this.HX.getLocationOnScreen(iArr);
                    p.this.Ig = iArr[0];
                    p.this.Ih = iArr[1];
                    p pVar = p.this;
                    pVar.Ik = pVar.HX.getWidth();
                    p pVar2 = p.this;
                    pVar2.mActionBarHeight = pVar2.HX.getHeight();
                    p.b(p.this, true);
                    com.kwad.sdk.core.d.c.d("SplashSlideBackupPresenter", "ActionBar position: x=" + p.this.Ig + ", y=" + p.this.Ih + ", width=" + p.this.Ik + ", height=" + p.this.mActionBarHeight);
                }
            });
        }
    }

    private void mT() {
        if (this.IL != null) {
            com.kwad.components.ad.splashscreen.widget.d dVar = new com.kwad.components.ad.splashscreen.widget.d(mP(), 0);
            this.IM = dVar;
            this.IL.setImageDrawable(dVar);
        }
    }

    private void mU() {
        String strMV;
        if (this.IJ != null) {
            if (TextUtils.isEmpty(this.If.title)) {
                strMV = mV();
            } else {
                strMV = this.If.title;
            }
            this.IJ.setText(strMV);
        }
        TextView textView = this.IK;
        if (textView != null) {
            textView.setText(mW());
        }
    }

    private String mV() {
        int i = this.If.style;
        if (i != 1) {
            return i != 2 ? "向上滑动" : "向右滑动";
        }
        return "向左滑动";
    }

    private String mW() {
        com.kwad.components.core.e.d.d dVar;
        if (!TextUtils.isEmpty(this.If.subtitle)) {
            return this.If.subtitle;
        }
        if (com.kwad.sdk.core.response.helper.a.aL(this.mAdInfo) && (dVar = this.IH) != null) {
            int iQm = dVar.qm();
            AdMatrixInfo.DownloadTexts downloadTexts = this.If.downloadTexts;
            if (iQm == 8) {
                return downloadTexts.installAppLabel;
            }
            if (iQm == 12) {
                return downloadTexts.openAppLabel;
            }
            return downloadTexts.adActionDescription;
        }
        String strDV = com.kwad.sdk.core.response.helper.b.dV(this.mAdInfo);
        return TextUtils.isEmpty(strDV) ? "跳转详情页或第三方应用" : strDV;
    }

    private void mX() {
        com.kwad.components.ad.splashscreen.e.a aVar = this.HN;
        if (aVar == null) {
            com.kwad.components.ad.splashscreen.e.a aVar2 = new com.kwad.components.ad.splashscreen.e.a(mP(), this.Hu.mAdTemplate) { // from class: com.kwad.components.ad.splashscreen.presenter.p.5
                {
                    super(adTemplate);
                }

                @Override // com.kwad.components.ad.splashscreen.e.a
                public final void j(int i, String str) {
                    if (p.this.IK != null) {
                        p.this.IK.setText(str);
                    }
                }
            };
            this.HN = aVar2;
            this.IH.b(aVar2);
            return;
        }
        aVar.setAdTemplate(this.Hu.mAdTemplate);
    }

    private void mY() {
        if (this.II != null && this.Hu != null) {
            this.II.setVisibility(0);
            com.kwad.sdk.core.adlog.c.b(this.Hu.mAdTemplate, MediaPlayer.MEDIA_PLAYER_OPTION_VIDEO_RANGE_SIZE, (JSONObject) null);
            com.kwad.components.core.webview.tachikoma.e.a.zM().cb(MediaPlayer.MEDIA_PLAYER_OPTION_VIDEO_RANGE_SIZE);
        }
        jo();
    }

    private void jo() {
        com.kwad.components.ad.splashscreen.widget.d dVar = this.IM;
        if (dVar != null) {
            dVar.start();
        }
        KsSlideRoundView ksSlideRoundView = this.HX;
        if (ksSlideRoundView != null) {
            ksSlideRoundView.fW();
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void b(float f, float f2, float f3, float f4) {
        final float fPx2dip = com.kwad.sdk.c.a.a.px2dip(mP(), (float) Math.sqrt(Math.pow(f3 - f, 2.0d) + Math.pow(f4 - f2, 2.0d)));
        com.kwad.sdk.core.d.c.d("SplashSlideBackupPresenter", "handleSlideTouchUp: distance=" + fPx2dip + "dp, minDistance=" + this.Ie + com.kuaishou.weapon.p0.t.q);
        if (SlideConvertHelper.a(this.Hu.mAdTemplate, f, f2, f3, f4)) {
            com.kwad.sdk.core.d.c.d("SplashSlideBackupPresenter", "handleSlideTouchUp: slide convert allowed, executing conversion");
            this.Hu.a(1, mP(), MediaPlayer.MEDIA_PLAYER_OPTION_GET_DROP_COUNT, 2, new com.kwad.components.ad.splashscreen.h.a() { // from class: com.kwad.components.ad.splashscreen.presenter.p.6
                @Override // com.kwad.components.ad.splashscreen.h.a
                public final void b(com.kwad.sdk.core.adlog.c.b bVar) {
                    bVar.ec(p.this.If.style);
                    bVar.ed((int) fPx2dip);
                }
            });
        } else {
            com.kwad.sdk.core.d.c.d("SplashSlideBackupPresenter", "handleSlideTouchUp: slide convert not allowed");
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void d(MotionEvent motionEvent) {
        if (e(motionEvent)) {
            com.kwad.sdk.core.d.c.d("SplashSlideBackupPresenter", "handleSingleTouchUp: click on ActionBar area");
            mZ();
        } else if (com.kwad.components.ad.splashscreen.h.o(this.mAdInfo)) {
            com.kwad.sdk.core.d.c.d("SplashSlideBackupPresenter", "handleSingleTouchUp: full screen click enabled");
            na();
        } else {
            com.kwad.sdk.core.d.c.d("SplashSlideBackupPresenter", "handleSingleTouchUp: full screen click disabled, no action");
        }
    }

    private boolean e(MotionEvent motionEvent) {
        boolean z = false;
        if (!this.IN || !this.IO) {
            com.kwad.sdk.core.d.c.w("SplashSlideBackupPresenter", "isClickOnActionBar: position not ready");
            return false;
        }
        float x = motionEvent.getX() + this.Ii;
        float y = motionEvent.getY() + this.Ij;
        float f = this.Ig;
        if (x >= f && x <= f + this.Ik) {
            float f2 = this.Ih;
            if (y >= f2 && y <= f2 + this.mActionBarHeight) {
                z = true;
            }
        }
        com.kwad.sdk.core.d.c.d("SplashSlideBackupPresenter", "isClickOnActionBar: touchX=" + x + ", touchY=" + y + ", inRange=" + z);
        return z;
    }

    private void mZ() {
        if (this.Hu != null) {
            this.Hu.c(1, mP(), 53, 2);
        }
    }

    private void na() {
        if (this.Hu != null) {
            this.Hu.c(1, mP(), 53, 2);
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
        return (context != null || (view = this.II) == null) ? context : view.getContext();
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        com.kwad.components.core.e.d.d dVar;
        super.onUnbind();
        com.kwad.components.ad.splashscreen.e.a aVar = this.HN;
        if (aVar == null || (dVar = this.IH) == null) {
            return;
        }
        dVar.c(aVar);
    }
}
