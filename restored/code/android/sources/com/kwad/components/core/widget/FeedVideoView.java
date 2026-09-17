package com.kwad.components.core.widget;

import android.app.Activity;
import android.content.Context;
import android.os.SystemClock;
import android.text.TextUtils;
import android.util.AttributeSet;
import android.view.View;
import android.view.ViewGroup;
import android.widget.FrameLayout;
import android.widget.ImageView;
import android.widget.TextView;
import androidx.core.view.NestedScrollingChild;
import androidx.core.view.NestedScrollingChildHelper;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.kwad.components.core.t.y;
import com.kwad.sdk.R;
import com.kwad.sdk.api.KsAdVideoPlayConfig;
import com.kwad.sdk.api.KsAppDownloadListener;
import com.kwad.sdk.core.imageloader.KSImageLoader;
import com.kwad.sdk.core.response.model.AdResultData;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.video.videoview.AdVideoPlayerViewCache;
import com.kwad.sdk.core.view.ScaleAnimSeekBar;
import com.kwad.sdk.utils.al;
import com.kwad.sdk.utils.as;
import com.kwad.sdk.utils.bw;
import com.kwad.sdk.widget.RatioFrameLayout;
import com.kwad.sdk.wrapper.m;
import java.util.Iterator;
import java.util.List;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class FeedVideoView extends b<AdResultData, AdTemplate> implements NestedScrollingChild {
    private com.kwad.components.core.video.e afJ;
    private NestedScrollingChildHelper afs;
    private ViewGroup ahN;
    private RatioFrameLayout avJ;
    private TextView avK;
    private TextView avL;
    private TextView avM;
    private View avN;
    private KSCornerImageView avO;
    private TextView avP;
    private ScaleAnimSeekBar avQ;
    private ImageView avR;
    private ImageView avS;
    private ImageView avT;
    private ViewGroup avU;
    private ViewGroup avV;
    private TextView avW;
    private ViewGroup avX;
    private int avY;
    private boolean avZ;
    private boolean awa;
    private long awb;
    private boolean awc;
    private KsAdVideoPlayConfig awd;
    private a awe;
    private View awf;
    private boolean awg;
    private Runnable awh;
    private y awi;
    private com.kwad.sdk.core.video.videoview.a cB;
    private com.kwad.sdk.core.video.videoview.a.InterfaceC0519a cK;
    private List<Integer> cv;
    private KsAppDownloadListener ei;
    private View.OnClickListener fZ;
    private TextView hO;
    private ImageView ia;
    private com.kwad.components.core.e.d.d mApkDownloadHelper;

    public interface a {
        void ut();

        void uu();
    }

    static /* synthetic */ boolean a(FeedVideoView feedVideoView, boolean z) {
        feedVideoView.awg = true;
        return true;
    }

    public FeedVideoView(Context context) {
        super(context);
        this.avY = 100;
        this.awh = new Runnable() { // from class: com.kwad.components.core.widget.FeedVideoView.7
            @Override // java.lang.Runnable
            public final void run() {
                FeedVideoView.this.avU.setVisibility(8);
                FeedVideoView.this.avT.setVisibility(8);
                if (FeedVideoView.this.afJ != null) {
                    FeedVideoView.this.afJ.be(true);
                }
            }
        };
        this.awi = new y(this.awh);
    }

    public FeedVideoView(Context context, AttributeSet attributeSet) {
        super(context, attributeSet);
        this.avY = 100;
        this.awh = new Runnable() { // from class: com.kwad.components.core.widget.FeedVideoView.7
            @Override // java.lang.Runnable
            public final void run() {
                FeedVideoView.this.avU.setVisibility(8);
                FeedVideoView.this.avT.setVisibility(8);
                if (FeedVideoView.this.afJ != null) {
                    FeedVideoView.this.afJ.be(true);
                }
            }
        };
        this.awi = new y(this.awh);
    }

    public FeedVideoView(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, i);
        this.avY = 100;
        this.awh = new Runnable() { // from class: com.kwad.components.core.widget.FeedVideoView.7
            @Override // java.lang.Runnable
            public final void run() {
                FeedVideoView.this.avU.setVisibility(8);
                FeedVideoView.this.avT.setVisibility(8);
                if (FeedVideoView.this.afJ != null) {
                    FeedVideoView.this.afJ.be(true);
                }
            }
        };
        this.awi = new y(this.awh);
    }

    public void setWindowFullScreenListener(a aVar) {
        this.awe = aVar;
    }

    @Override // com.kwad.components.core.widget.b
    protected final void by() {
        this.afs = new NestedScrollingChildHelper(this);
        RatioFrameLayout ratioFrameLayout = (RatioFrameLayout) findViewById(R.id.ksad_video_container);
        this.avJ = ratioFrameLayout;
        ratioFrameLayout.setRatio(0.5600000023841858d);
        this.ia = (ImageView) findViewById(R.id.ksad_video_first_frame_container);
        this.hO = (TextView) findViewById(R.id.ksad_video_text_below);
        ScaleAnimSeekBar scaleAnimSeekBar = (ScaleAnimSeekBar) findViewById(R.id.ksad_web_video_seek_bar);
        this.avQ = scaleAnimSeekBar;
        scaleAnimSeekBar.setMaxProgress(100);
        this.avQ.setMinProgress(0);
        this.avM = (TextView) findViewById(R.id.ksad_video_text_below_action_bar);
        this.avN = findViewById(R.id.ksad_video_text_below_action_icon_layout);
        this.avP = (TextView) findViewById(R.id.ksad_video_text_below_action_title);
        this.avO = (KSCornerImageView) findViewById(R.id.ksad_video_text_below_action_icon);
        this.avK = (TextView) findViewById(R.id.ksad_video_control_play_total);
        this.avL = (TextView) findViewById(R.id.ksad_video_control_play_duration);
        this.avR = (ImageView) findViewById(R.id.ksad_video_control_play_button);
        this.avT = (ImageView) findViewById(R.id.ksad_video_control_play_status);
        this.avS = (ImageView) findViewById(R.id.ksad_video_control_fullscreen);
        this.avU = (ViewGroup) findViewById(R.id.ksad_video_control_container);
        this.avX = (ViewGroup) findViewById(R.id.ksad_feed_video_container);
        this.avV = (ViewGroup) findViewById(R.id.ksad_video_control_fullscreen_container);
        this.avW = (TextView) findViewById(R.id.ksad_video_control_fullscreen_title);
    }

    @Override // com.kwad.components.core.widget.b
    protected int getLayoutId() {
        return R.layout.ksad_feed_video;
    }

    @Override // com.kwad.components.core.widget.b
    public final void d(AdResultData adResultData) {
        super.d(adResultData);
    }

    private KsAppDownloadListener getAppDownloadListener() {
        if (this.ei == null) {
            this.ei = new com.kwad.sdk.core.download.a.a() { // from class: com.kwad.components.core.widget.FeedVideoView.1
                @Override // com.kwad.sdk.api.KsAppDownloadListener
                public final void onIdle() {
                    FeedVideoView.this.avM.setText(com.kwad.sdk.core.response.helper.a.aK(FeedVideoView.this.mAdInfo));
                }

                @Override // com.kwad.sdk.api.KsAppDownloadListener
                public final void onProgressUpdate(int i) {
                    FeedVideoView.this.avM.setText(com.kwad.sdk.core.response.helper.a.ev(i));
                }

                @Override // com.kwad.sdk.core.download.a.a
                public final void onPaused(int i) {
                    FeedVideoView.this.avM.setText(com.kwad.sdk.core.response.helper.a.ew(i));
                }

                @Override // com.kwad.sdk.api.KsAppDownloadListener
                public final void onDownloadFinished() {
                    FeedVideoView.this.avM.setText(com.kwad.sdk.core.response.helper.a.cF(FeedVideoView.this.mAdTemplate));
                }

                @Override // com.kwad.sdk.api.KsAppDownloadListener
                public final void onDownloadFailed() {
                    FeedVideoView.this.avM.setText(com.kwad.sdk.core.response.helper.a.aK(FeedVideoView.this.mAdInfo));
                }

                @Override // com.kwad.sdk.api.KsAppDownloadListener
                public final void onInstalled() {
                    FeedVideoView.this.avM.setText(com.kwad.sdk.core.response.helper.a.af(FeedVideoView.this.mAdInfo));
                }
            };
        }
        return this.ei;
    }

    public final void a(KsAdVideoPlayConfig ksAdVideoPlayConfig, com.kwad.components.core.e.d.d dVar) {
        this.mApkDownloadHelper = dVar;
        this.awg = false;
        com.kwad.sdk.core.response.model.b bVarBA = com.kwad.sdk.core.response.helper.a.bA(this.mAdInfo);
        this.awd = ksAdVideoPlayConfig;
        String url = bVarBA.getUrl();
        if (!TextUtils.isEmpty(url)) {
            this.ia.setImageDrawable(null);
            KSImageLoader.loadImage(this.ia, url, this.mAdTemplate);
            this.ia.setVisibility(0);
        } else {
            this.ia.setVisibility(8);
        }
        this.cv = com.kwad.sdk.core.response.helper.a.bv(this.mAdInfo);
        String strM = com.kwad.sdk.core.response.helper.a.M(this.mAdInfo);
        if (TextUtils.isEmpty(strM)) {
            return;
        }
        this.cB = AdVideoPlayerViewCache.getInstance().fr(strM);
        if (com.kwad.sdk.core.response.helper.a.aw(this.mAdInfo)) {
            this.hO.setVisibility(8);
            View view = this.avN;
            if (view != null) {
                view.setVisibility(0);
                this.avM.setText(com.kwad.sdk.core.response.helper.a.aK(this.mAdInfo));
                this.avP.setText(com.kwad.sdk.core.response.helper.a.cs(this.mAdInfo));
                KSImageLoader.loadAppIcon(this.avO, com.kwad.sdk.core.response.helper.a.cv(this.mAdInfo), this.mAdTemplate, 4);
                com.kwad.components.core.e.d.d dVar2 = this.mApkDownloadHelper;
                if (dVar2 != null) {
                    dVar2.b(getAppDownloadListener());
                }
                this.avM.setOnClickListener(new View.OnClickListener() { // from class: com.kwad.components.core.widget.FeedVideoView.5
                    @Override // android.view.View.OnClickListener
                    public final void onClick(View view2) {
                        if (FeedVideoView.this.fZ != null) {
                            FeedVideoView.this.fZ.onClick(view2);
                        }
                    }
                });
            }
        } else {
            View view2 = this.avN;
            if (view2 != null) {
                view2.setVisibility(8);
            }
            this.hO.setVisibility(0);
        }
        com.kwad.sdk.core.video.videoview.a aVar = this.cB;
        if (aVar == null) {
            this.cB = new com.kwad.sdk.core.video.videoview.a(getContext());
            com.kwad.sdk.core.response.helper.a.ae(this.mAdInfo);
            this.cB.a(new com.kwad.sdk.contentalliance.a.a.b.a(this.mAdTemplate).a(this.mAdTemplate.mVideoPlayerStatus).dO(com.kwad.sdk.core.response.helper.e.eO(this.mAdTemplate)).dP(com.kwad.sdk.core.response.helper.h.b(com.kwad.sdk.core.response.helper.e.eN(this.mAdTemplate))).b(new com.kwad.sdk.contentalliance.a.a.a(this.mAdTemplate, System.currentTimeMillis())).IS(), null);
            com.kwad.sdk.core.video.videoview.a.InterfaceC0519a interfaceC0519a = new com.kwad.sdk.core.video.videoview.a.InterfaceC0519a() { // from class: com.kwad.components.core.widget.FeedVideoView.6
                @Override // com.kwad.sdk.core.video.videoview.a.InterfaceC0519a
                public final com.kwad.sdk.core.video.a.c a(com.kwad.sdk.contentalliance.a.a.b bVar) {
                    if (!((Boolean) com.kwad.sdk.core.config.e.b(com.kwad.sdk.core.config.c.aQq)).booleanValue() || !((Boolean) com.kwad.sdk.core.config.e.b(com.kwad.sdk.core.config.c.aQr)).booleanValue()) {
                        return null;
                    }
                    com.kwad.components.core.video.g gVar = new com.kwad.components.core.video.g(bVar, FeedVideoView.this.mAdTemplate);
                    if (com.kwad.components.core.video.g.isWaynePlayerReady()) {
                        return gVar;
                    }
                    return null;
                }
            };
            this.cK = interfaceC0519a;
            this.cB.setExternalPlayerListener(interfaceC0519a);
            com.kwad.components.core.video.e eVar = new com.kwad.components.core.video.e(this.mContext, this.mAdTemplate, this.cB, ksAdVideoPlayConfig);
            this.afJ = eVar;
            eVar.setDataFlowAutoStart(ksAdVideoPlayConfig.isDataFlowAutoStart());
            this.cB.setController(this.afJ);
            this.afJ.setAutoRelease(false);
            if (com.kwad.sdk.core.config.e.Jw() == 2) {
                AdVideoPlayerViewCache.getInstance().a(strM, this.cB);
            }
        } else {
            if (aVar.getTag() != null) {
                try {
                    this.cv = (List) this.cB.getTag();
                } catch (Exception e) {
                    e.printStackTrace();
                }
            }
            com.kwad.components.core.video.e eVar2 = (com.kwad.components.core.video.e) this.cB.getController();
            this.afJ = eVar2;
            eVar2.setAutoRelease(false);
            this.afJ.getAdTemplate().mAdWebVideoPageShowing = true;
        }
        this.cB.setVideoSoundEnable(ksAdVideoPlayConfig.isVideoSoundEnable());
        if (this.cB.getParent() != null) {
            ((ViewGroup) this.cB.getParent()).removeView(this.cB);
            this.afJ.xP();
        }
        if (this.avJ.getTag() != null) {
            RatioFrameLayout ratioFrameLayout = this.avJ;
            ratioFrameLayout.removeView((View) ratioFrameLayout.getTag());
            this.avJ.setTag(null);
        }
        this.avJ.addView(this.cB);
        this.avJ.setTag(this.cB);
        this.avU.setVisibility(8);
        this.avT.setVisibility(8);
        if (this.mAdInfo.adConversionInfo.h5Type == 1) {
            this.hO.setVisibility(8);
        } else {
            this.hO.setVisibility(0);
            this.hO.setText(this.mAdInfo.adBaseInfo.adDescription);
        }
        a(this.afJ, this.cB);
    }

    private void a(com.kwad.components.core.video.a aVar, final com.kwad.sdk.core.video.videoview.a aVar2) {
        this.avX.setOnClickListener(new View.OnClickListener() { // from class: com.kwad.components.core.widget.FeedVideoView.8
            @Override // android.view.View.OnClickListener
            public final void onClick(View view) {
                if (FeedVideoView.this.avU.getVisibility() == 8) {
                    if (!FeedVideoView.this.cB.isCompleted()) {
                        FeedVideoView.this.avU.setVisibility(0);
                        FeedVideoView.this.avT.setVisibility(0);
                        if (FeedVideoView.this.afJ != null) {
                            FeedVideoView.this.afJ.be(false);
                        }
                        if (FeedVideoView.this.getHandler() != null) {
                            FeedVideoView.this.getHandler().removeCallbacks(FeedVideoView.this.awh);
                            FeedVideoView.this.getHandler().postDelayed(FeedVideoView.this.awi, 5000L);
                            return;
                        }
                        return;
                    }
                    if (FeedVideoView.this.avY == 101) {
                        FeedVideoView.this.avU.setVisibility(0);
                        FeedVideoView.this.avT.setVisibility(8);
                        if (FeedVideoView.this.afJ != null) {
                            FeedVideoView.this.afJ.be(false);
                        }
                        if (FeedVideoView.this.getHandler() != null) {
                            FeedVideoView.this.getHandler().removeCallbacks(FeedVideoView.this.awh);
                            FeedVideoView.this.getHandler().postDelayed(FeedVideoView.this.awi, 5000L);
                            return;
                        }
                        return;
                    }
                    if (FeedVideoView.this.fZ != null) {
                        FeedVideoView.this.fZ.onClick(view);
                        return;
                    }
                    return;
                }
                if (FeedVideoView.this.getHandler() != null) {
                    FeedVideoView.this.getHandler().removeCallbacks(FeedVideoView.this.awh);
                    if (FeedVideoView.this.awc) {
                        return;
                    }
                    FeedVideoView.this.getHandler().postDelayed(FeedVideoView.this.awi, 1000L);
                }
            }
        });
        aVar.setVideoPlayCallback(new com.kwad.components.core.video.a.c() { // from class: com.kwad.components.core.widget.FeedVideoView.9
            private boolean eQ = false;

            @Override // com.kwad.components.core.video.a.c
            public final void d(long j) {
                FeedVideoView.this.c(j);
                float duration = (j * 100.0f) / aVar2.getDuration();
                if (!FeedVideoView.this.awc) {
                    FeedVideoView.this.avQ.setProgress((int) duration);
                    FeedVideoView.this.avL.setText(bw.at(j));
                }
                FeedVideoView.this.avK.setText(bw.at(aVar2.getDuration()));
            }

            @Override // com.kwad.components.core.video.a.c
            public final void onVideoPlayStart() {
                if (!FeedVideoView.this.awg) {
                    FeedVideoView.a(FeedVideoView.this, true);
                    if (com.kwad.sdk.core.response.helper.a.at(FeedVideoView.this.mAdInfo) != 0) {
                        FeedVideoView.this.cB.setVideoSoundEnable(true ^ com.kwad.sdk.core.response.helper.a.av(FeedVideoView.this.mAdInfo));
                    }
                    if (com.kwad.sdk.core.response.helper.a.at(FeedVideoView.this.mAdInfo) != 0) {
                        FeedVideoView.this.cB.setLooping(com.kwad.sdk.core.response.helper.a.au(FeedVideoView.this.mAdInfo));
                    }
                }
                com.kwad.sdk.core.adlog.c.cp(FeedVideoView.this.mAdTemplate);
                FeedVideoView.this.avK.setText(bw.at(aVar2.getDuration()));
            }

            @Override // com.kwad.components.core.video.a.c
            public final void as() {
                if (!FeedVideoView.this.awg) {
                    FeedVideoView.a(FeedVideoView.this, true);
                    if (com.kwad.sdk.core.response.helper.a.at(FeedVideoView.this.mAdInfo) != 0) {
                        FeedVideoView.this.cB.setVideoSoundEnable(!com.kwad.sdk.core.response.helper.a.av(FeedVideoView.this.mAdInfo));
                    }
                    if (com.kwad.sdk.core.response.helper.a.at(FeedVideoView.this.mAdInfo) != 0) {
                        FeedVideoView.this.cB.setLooping(com.kwad.sdk.core.response.helper.a.au(FeedVideoView.this.mAdInfo));
                    }
                }
                if (this.eQ) {
                    return;
                }
                this.eQ = true;
                com.kwad.components.core.p.a.vX().a(FeedVideoView.this.mAdTemplate, System.currentTimeMillis(), 1);
            }

            @Override // com.kwad.components.core.video.a.c
            public final void at() {
                com.kwad.sdk.core.adlog.c.cq(FeedVideoView.this.mAdTemplate);
                FeedVideoView.this.avU.setVisibility(8);
                FeedVideoView.this.avT.setVisibility(8);
                FeedVideoView.this.avQ.setProgress(100);
                FeedVideoView.this.avL.setText(bw.at(aVar2.getDuration()));
            }
        });
        this.afJ.setAdClickListener(new com.kwad.components.core.video.a.InterfaceC0460a() { // from class: com.kwad.components.core.widget.FeedVideoView.10
            @Override // com.kwad.components.core.video.a.InterfaceC0460a
            public final void a(int i, al.a aVar3) {
                int i2 = MediaPlayer.MEDIA_PLAYER_OPTION_BIT_RATE;
                int i3 = 2;
                boolean z = false;
                if (i != 1) {
                    if (i != 2) {
                        if (i == 3) {
                            i2 = com.kwad.sdk.core.response.helper.a.at(FeedVideoView.this.mAdInfo) != 0 ? 50 : 83;
                            i3 = 1;
                            z = true;
                        } else if (com.kwad.sdk.core.response.helper.a.at(FeedVideoView.this.mAdInfo) == 0) {
                            i2 = 108;
                        }
                    } else if (com.kwad.sdk.core.response.helper.a.at(FeedVideoView.this.mAdInfo) == 0) {
                        i2 = 82;
                    }
                } else if (com.kwad.sdk.core.response.helper.a.at(FeedVideoView.this.mAdInfo) == 0) {
                    i2 = 13;
                }
                com.kwad.components.core.e.d.a.a(new com.kwad.components.core.e.d.a.C0428a(FeedVideoView.this.getContext()).aF(FeedVideoView.this.mAdTemplate).ax(true).b(FeedVideoView.this.mApkDownloadHelper).aD(i3).as(z).au(true).aC(i2).d(aVar3).a(new com.kwad.components.core.e.d.a.b() { // from class: com.kwad.components.core.widget.FeedVideoView.10.1
                    @Override // com.kwad.components.core.e.d.a.b
                    public final void onAdClicked() {
                        FeedVideoView.this.zZ();
                    }
                }));
            }
        });
        this.avQ.setOnSeekBarChangeListener(new ScaleAnimSeekBar.a() { // from class: com.kwad.components.core.widget.FeedVideoView.11
            @Override // com.kwad.sdk.core.view.ScaleAnimSeekBar.a
            public final void a(ScaleAnimSeekBar scaleAnimSeekBar, boolean z) {
                if (z) {
                    FeedVideoView.this.avQ.bL(true);
                    FeedVideoView.this.getHandler().removeCallbacks(FeedVideoView.this.awi);
                    FeedVideoView.this.awc = true;
                    FeedVideoView.this.avL.setText(bw.at((int) ((aVar2.getDuration() * ((long) scaleAnimSeekBar.getProgress())) / ((long) scaleAnimSeekBar.getMaxProgress()))));
                }
            }

            @Override // com.kwad.sdk.core.view.ScaleAnimSeekBar.a
            public final void Ah() {
                FeedVideoView.this.avQ.bL(true);
                FeedVideoView.this.getHandler().removeCallbacks(FeedVideoView.this.awi);
                FeedVideoView.this.awc = true;
            }

            @Override // com.kwad.sdk.core.view.ScaleAnimSeekBar.a
            public final void a(ScaleAnimSeekBar scaleAnimSeekBar) {
                FeedVideoView.this.avQ.bL(false);
                aVar2.seekTo((int) ((aVar2.getDuration() * ((long) scaleAnimSeekBar.getProgress())) / ((long) scaleAnimSeekBar.getMaxProgress())));
                if (FeedVideoView.this.getHandler() != null) {
                    FeedVideoView.this.getHandler().removeCallbacks(FeedVideoView.this.awi);
                    FeedVideoView.this.getHandler().postDelayed(FeedVideoView.this.awi, 5000L);
                }
                FeedVideoView.this.awc = false;
            }
        });
        this.avR.setOnClickListener(new View.OnClickListener() { // from class: com.kwad.components.core.widget.FeedVideoView.12
            @Override // android.view.View.OnClickListener
            public final void onClick(View view) {
                if (aVar2.isPaused() || aVar2.isIdle()) {
                    FeedVideoView.this.afJ.xS();
                    FeedVideoView.this.avR.setImageDrawable(FeedVideoView.this.getResources().getDrawable(R.drawable.ksad_video_player_pause_btn));
                    FeedVideoView.this.avT.setImageDrawable(FeedVideoView.this.getResources().getDrawable(R.drawable.ksad_video_player_pause_center));
                } else if (aVar2.isPlaying()) {
                    FeedVideoView.this.afJ.xR();
                    FeedVideoView.this.avT.setVisibility(0);
                    FeedVideoView.this.avT.setImageDrawable(FeedVideoView.this.getContext().getResources().getDrawable(R.drawable.ksad_video_play_176));
                    FeedVideoView.this.avR.setImageDrawable(FeedVideoView.this.getContext().getResources().getDrawable(R.drawable.ksad_video_player_play_btn));
                }
                if (FeedVideoView.this.getHandler() != null) {
                    FeedVideoView.this.getHandler().removeCallbacks(FeedVideoView.this.awi);
                    FeedVideoView.this.getHandler().postDelayed(FeedVideoView.this.awi, 5000L);
                }
            }
        });
        this.avT.setOnClickListener(new View.OnClickListener() { // from class: com.kwad.components.core.widget.FeedVideoView.2
            @Override // android.view.View.OnClickListener
            public final void onClick(View view) {
                if (!FeedVideoView.this.cB.isPaused() && !FeedVideoView.this.cB.isIdle()) {
                    if (FeedVideoView.this.cB.isPlaying()) {
                        FeedVideoView.this.xv();
                    }
                } else {
                    FeedVideoView.this.vf();
                }
                if (FeedVideoView.this.getHandler() != null) {
                    FeedVideoView.this.getHandler().removeCallbacks(FeedVideoView.this.awi);
                    FeedVideoView.this.getHandler().postDelayed(FeedVideoView.this.awi, 5000L);
                }
            }
        });
        this.avV.setOnClickListener(new View.OnClickListener() { // from class: com.kwad.components.core.widget.FeedVideoView.3
            @Override // android.view.View.OnClickListener
            public final void onClick(View view) {
                FeedVideoView.this.Af();
            }
        });
        this.avS.setOnClickListener(new View.OnClickListener() { // from class: com.kwad.components.core.widget.FeedVideoView.4
            @Override // android.view.View.OnClickListener
            public final void onClick(View view) {
                if (FeedVideoView.this.avY == 100) {
                    FeedVideoView.this.Ae();
                } else if (FeedVideoView.this.avY == 101) {
                    FeedVideoView.this.Af();
                }
            }
        });
    }

    public final void vf() {
        this.afJ.xS();
        this.afJ.setVisibility(0);
        this.afJ.setAlpha(1.0f);
        this.avR.setImageDrawable(getContext().getResources().getDrawable(R.drawable.ksad_video_player_pause_btn));
        this.avT.setImageDrawable(getContext().getResources().getDrawable(R.drawable.ksad_video_player_pause_center));
    }

    public final void xv() {
        this.afJ.xR();
        this.avT.setVisibility(0);
        this.avT.setImageDrawable(getContext().getResources().getDrawable(R.drawable.ksad_video_play_176));
        this.avR.setImageDrawable(getContext().getResources().getDrawable(R.drawable.ksad_video_player_play_btn));
    }

    public final void vb() {
        this.afJ.xP();
    }

    public final boolean isComplete() {
        com.kwad.sdk.core.video.videoview.a aVar = this.cB;
        if (aVar != null) {
            return aVar.isCompleted();
        }
        return true;
    }

    private boolean Ad() {
        long jElapsedRealtime = SystemClock.elapsedRealtime();
        long j = jElapsedRealtime - this.awb;
        if (j > 888) {
            this.awb = jElapsedRealtime;
        }
        return j > 888;
    }

    protected void setUIWithStateAndMode(int i) {
        if (i == 101) {
            this.avS.setImageDrawable(getContext().getResources().getDrawable(R.drawable.ksad_video_player_exit_fullscreen_btn));
        } else {
            this.avS.setImageDrawable(getContext().getResources().getDrawable(R.drawable.ksad_video_player_fullscreen_btn));
        }
        this.avY = i;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void Ae() {
        a aVar = this.awe;
        if (aVar != null) {
            aVar.ut();
        }
        if ((this.avY == 100) && Ad()) {
            this.avV.setVisibility(0);
            this.avW.setText(this.mAdInfo.adBaseInfo.adDescription);
            boolean z = com.kwad.sdk.core.response.helper.a.T(this.mAdInfo) > com.kwad.sdk.core.response.helper.a.S(this.mAdInfo);
            this.avZ = as.dB(getContext());
            getContext();
            this.awa = as.VV();
            if (!z) {
                as.dD(getContext());
            } else {
                as.dE(getContext());
            }
            ViewGroup viewGroup = (ViewGroup) this.avX.getParent();
            this.ahN = viewGroup;
            if (viewGroup != null) {
                viewGroup.removeView(this.avX);
                View view = new View(this.avX.getContext());
                this.awf = view;
                view.setLayoutParams(new ViewGroup.LayoutParams(this.avX.getWidth(), this.avX.getHeight()));
                viewGroup.addView(this.awf);
            }
            as.i(getContext(), false);
            Activity activityFromContext = m.getActivityFromContext(getContext());
            if (activityFromContext != null) {
                ViewGroup viewGroup2 = (ViewGroup) activityFromContext.getWindow().getDecorView();
                this.avX.setLayoutParams(new ViewGroup.LayoutParams(viewGroup2.getWidth(), viewGroup2.getHeight()));
                if (z && viewGroup2.getWidth() != 0) {
                    this.avJ.setRatio(viewGroup2.getHeight() / viewGroup2.getWidth());
                }
                viewGroup2.addView(this.avX, new FrameLayout.LayoutParams(-1, -1));
                setUIWithStateAndMode(101);
            }
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void Af() {
        if ((this.avY == 101) & Ad()) {
            this.avV.setVisibility(8);
            if (this.avZ) {
                as.dB(getContext());
            } else {
                as.dC(getContext());
            }
            if (this.awa) {
                as.dE(getContext());
            } else {
                as.dD(getContext());
            }
            as.i(getContext(), true);
            ViewGroup viewGroup = (ViewGroup) this.avX.getParent();
            if (viewGroup != null) {
                viewGroup.removeView(this.avX);
            }
            this.avX.setLayoutParams(new ViewGroup.LayoutParams(this.ahN.getWidth(), this.ahN.getHeight()));
            this.avJ.setRatio(0.5600000023841858d);
            View view = this.awf;
            if (view != null) {
                this.ahN.removeView(view);
                this.awf = null;
            }
            this.ahN.addView(this.avX, new FrameLayout.LayoutParams(-1, -2));
            this.avX.requestLayout();
            setUIWithStateAndMode(100);
        }
        a aVar = this.awe;
        if (aVar != null) {
            aVar.uu();
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void c(long j) {
        int iCeil = (int) Math.ceil(j / 1000.0f);
        List<Integer> list = this.cv;
        if (list == null || list.isEmpty()) {
            return;
        }
        Iterator<Integer> it = this.cv.iterator();
        while (it.hasNext()) {
            if (iCeil >= it.next().intValue()) {
                com.kwad.sdk.core.adlog.c.a((AdTemplate) this.mAdTemplate, iCeil, (JSONObject) null);
                it.remove();
                return;
            }
        }
    }

    public final void release() {
        com.kwad.components.core.video.e eVar = this.afJ;
        if (eVar != null) {
            eVar.release();
        }
    }

    @Override // android.view.View, androidx.core.view.NestedScrollingChild
    public void setNestedScrollingEnabled(boolean z) {
        this.afs.setNestedScrollingEnabled(z);
    }

    @Override // android.view.View, androidx.core.view.NestedScrollingChild
    public boolean isNestedScrollingEnabled() {
        return this.afs.isNestedScrollingEnabled();
    }

    @Override // android.view.View, androidx.core.view.NestedScrollingChild
    public boolean startNestedScroll(int i) {
        return this.afs.startNestedScroll(i);
    }

    @Override // android.view.View, androidx.core.view.NestedScrollingChild
    public void stopNestedScroll() {
        this.afs.stopNestedScroll();
    }

    @Override // android.view.View, androidx.core.view.NestedScrollingChild
    public boolean hasNestedScrollingParent() {
        return this.afs.hasNestedScrollingParent();
    }

    @Override // android.view.View, androidx.core.view.NestedScrollingChild
    public boolean dispatchNestedScroll(int i, int i2, int i3, int i4, int[] iArr) {
        return this.afs.dispatchNestedScroll(i, i2, i3, i4, iArr);
    }

    @Override // android.view.View, androidx.core.view.NestedScrollingChild
    public boolean dispatchNestedPreScroll(int i, int i2, int[] iArr, int[] iArr2) {
        return this.afs.dispatchNestedPreScroll(i, i2, iArr, iArr2);
    }

    @Override // android.view.View, androidx.core.view.NestedScrollingChild
    public boolean dispatchNestedFling(float f, float f2, boolean z) {
        return this.afs.dispatchNestedFling(f, f2, z);
    }

    @Override // android.view.View, androidx.core.view.NestedScrollingChild
    public boolean dispatchNestedPreFling(float f, float f2) {
        return this.afs.dispatchNestedPreFling(f, f2);
    }

    public final boolean Ag() {
        if (this.avY != 101) {
            return false;
        }
        Af();
        return true;
    }

    public void setOnEndBtnClickListener(View.OnClickListener onClickListener) {
        this.fZ = onClickListener;
    }

    @Override // com.kwad.sdk.widget.KSFrameLayout, com.kwad.sdk.widget.k
    public final void H(View view) {
        super.H(view);
    }

    @Override // com.kwad.components.core.widget.b, com.kwad.sdk.core.j.c
    public final void bw() {
        super.bw();
        if (this.cB != null) {
            xv();
            if (getHandler() != null) {
                getHandler().removeCallbacks(this.awi);
                getHandler().postDelayed(this.awi, 5000L);
            }
        }
    }

    @Override // com.kwad.components.core.widget.b, com.kwad.sdk.core.j.c
    public final void bv() {
        super.bv();
        com.kwad.sdk.core.video.videoview.a aVar = this.cB;
        if (aVar == null || aVar.isPlaying()) {
            return;
        }
        vf();
        if (getHandler() != null) {
            getHandler().removeCallbacks(this.awi);
            getHandler().postDelayed(this.awi, 5000L);
        }
    }
}
