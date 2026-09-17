package com.kwad.components.ad.splashscreen.presenter;

import android.os.SystemClock;
import android.text.TextUtils;
import android.view.MotionEvent;
import android.view.ViewStub;
import android.widget.ImageView;
import android.widget.TextView;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.kwad.components.ad.splashscreen.widget.KsSplashSlidePathView;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.helper.SlideConvertHelper;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdMatrixInfo;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class r extends e {
    private com.kwad.components.ad.splashscreen.e.a HN;
    private KsSplashSlidePathView HY;
    private com.kwad.components.core.e.d.d IH;
    private com.kwad.components.ad.splashscreen.widget.d IM;
    private TextView IV;
    private ImageView IW;
    private double Ie;
    private AdMatrixInfo.SplashSlideInfo If;
    private TextView kG;
    private AdInfo mAdInfo;
    private long mStartTime;

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.mStartTime = SystemClock.elapsedRealtime();
        ViewStub viewStub = (ViewStub) findViewById(R.id.ksad_slide_layout);
        if (viewStub != null) {
            viewStub.inflate();
        }
        this.kG = (TextView) findViewById(R.id.ksad_splash_slide_title);
        this.IV = (TextView) findViewById(R.id.ksad_splash_slide_actiontext);
        this.IW = (ImageView) findViewById(R.id.ksad_splash_slideView);
        ViewStub viewStub2 = (ViewStub) findViewById(R.id.ksad_splash_slideTouchView);
        if (viewStub2 != null) {
            this.HY = (KsSplashSlidePathView) viewStub2.inflate();
        } else {
            this.HY = (KsSplashSlidePathView) findViewById(R.id.ksad_splash_slideview_root);
        }
        KsSplashSlidePathView ksSplashSlidePathView = this.HY;
        if (ksSplashSlidePathView != null) {
            ksSplashSlidePathView.setOnSlideTouchListener(new KsSplashSlidePathView.a() { // from class: com.kwad.components.ad.splashscreen.presenter.r.1
                @Override // com.kwad.components.ad.splashscreen.widget.KsSplashSlidePathView.a
                public final void a(float f, float f2, float f3, float f4) {
                    final float fPx2dip = com.kwad.sdk.c.a.a.px2dip(r.this.getContext(), (float) Math.sqrt(Math.pow(f3 - f, 2.0d) + Math.pow(f4 - f2, 2.0d)));
                    if (!SlideConvertHelper.a(r.this.Hu.mAdTemplate, f, f2, f3, f4) || r.this.Hu == null) {
                        return;
                    }
                    r.this.Hu.a(1, r.this.getContext(), MediaPlayer.MEDIA_PLAYER_OPTION_GET_DROP_COUNT, 3, new com.kwad.components.ad.splashscreen.h.a() { // from class: com.kwad.components.ad.splashscreen.presenter.r.1.1
                        @Override // com.kwad.components.ad.splashscreen.h.a
                        public final void b(com.kwad.sdk.core.adlog.c.b bVar) {
                            bVar.ec(r.this.If.style);
                            bVar.ed((int) fPx2dip);
                        }
                    });
                }

                @Override // com.kwad.components.ad.splashscreen.widget.KsSplashSlidePathView.a
                public final void c(MotionEvent motionEvent) {
                    if (!com.kwad.components.ad.splashscreen.h.o(r.this.mAdInfo) || r.this.Hu == null) {
                        return;
                    }
                    r.this.Hu.c(1, r.this.getContext(), 53, 3);
                }
            });
        }
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.e, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        if (this.Hu == null) {
            return;
        }
        by.postOnUiThread(new bi() { // from class: com.kwad.components.ad.splashscreen.presenter.r.2
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                r.this.Hu.GW = SystemClock.elapsedRealtime() - r.this.mStartTime;
            }
        });
        this.mAdInfo = com.kwad.sdk.core.response.helper.e.eM(this.Hu.mAdTemplate);
        this.IH = this.Hu.mApkDownloadHelper;
        initView();
        if (com.kwad.sdk.core.response.helper.a.aL(this.mAdInfo)) {
            mX();
        }
    }

    private void initView() {
        AdMatrixInfo.SplashSlideInfo splashSlideInfo = this.mAdInfo.adMatrixInfo.adDataV2.splashInfo.interactionInfo.slideInfo;
        this.If = splashSlideInfo;
        this.Ie = splashSlideInfo.convertDistance;
        int i = this.If.style;
        com.kwad.components.ad.splashscreen.widget.d dVar = new com.kwad.components.ad.splashscreen.widget.d(getContext(), i);
        this.IM = dVar;
        this.IW.setImageDrawable(dVar);
        this.IW.post(new bi() { // from class: com.kwad.components.ad.splashscreen.presenter.r.3
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                r.this.nb();
                if (r.this.IM != null) {
                    r.this.IM.start();
                }
            }
        });
        if (!TextUtils.isEmpty(this.If.title)) {
            this.kG.setText(this.If.title);
        } else if (i == 0) {
            this.kG.setText("向上滑动");
        } else if (i == 1) {
            this.kG.setText("向左滑动");
        } else if (i == 2) {
            this.kG.setText("向右滑动");
        }
        if (!TextUtils.isEmpty(this.If.subtitle)) {
            this.IV.setText(this.If.subtitle);
        } else if (com.kwad.sdk.core.response.helper.a.aL(this.mAdInfo)) {
            this.IV.setText(com.kwad.components.ad.splashscreen.d.a(this.Hu.mAdTemplate, this.mAdInfo, this.IH.qm(), 0));
        } else {
            this.IV.setText("跳转详情页或者第三方应用");
        }
    }

    private void mX() {
        com.kwad.components.ad.splashscreen.e.a aVar = this.HN;
        if (aVar == null) {
            com.kwad.components.ad.splashscreen.e.a aVar2 = new com.kwad.components.ad.splashscreen.e.a(getContext(), this.Hu.mAdTemplate) { // from class: com.kwad.components.ad.splashscreen.presenter.r.4
                {
                    super(adTemplate);
                }

                @Override // com.kwad.components.ad.splashscreen.e.a
                public final void j(int i, String str) {
                    r.this.IV.setText(str);
                }
            };
            this.HN = aVar2;
            this.IH.b(aVar2);
            return;
        }
        aVar.setAdTemplate(this.Hu.mAdTemplate);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void nb() {
        if (this.If != null) {
            com.kwad.sdk.core.adlog.c.d(this.Hu.mAdTemplate, (JSONObject) null, new com.kwad.sdk.core.adlog.c.b().ec(this.If.style).dU(MediaPlayer.MEDIA_PLAYER_OPTION_SLOW_PLAY_TIME));
            com.kwad.components.core.webview.tachikoma.e.a.zM().cb(MediaPlayer.MEDIA_PLAYER_OPTION_SLOW_PLAY_TIME);
        }
    }
}
