package com.kwad.components.ad.feed.widget;

import android.content.Context;
import android.graphics.BitmapFactory;
import android.os.SystemClock;
import android.text.TextUtils;
import android.view.View;
import android.view.ViewGroup;
import android.widget.FrameLayout;
import android.widget.ImageView;
import android.widget.RelativeLayout;
import android.widget.TextView;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.kwad.components.ad.widget.DownloadProgressView;
import com.kwad.components.core.internal.api.KSAdVideoPlayConfigImpl;
import com.kwad.components.core.widget.KsLogoView;
import com.kwad.components.model.FeedType;
import com.kwad.components.offline.api.core.adlive.IAdLiveOfflineView;
import com.kwad.components.offline.api.core.adlive.IAdLivePlayModule;
import com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListener;
import com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListenerAdapter;
import com.kwad.components.offline.api.core.api.OfflineOnAudioConflictListener;
import com.kwad.sdk.R;
import com.kwad.sdk.api.KsAdVideoPlayConfig;
import com.kwad.sdk.core.imageloader.KSImageLoader;
import com.kwad.sdk.core.imageloader.core.DisplayImageOptionsCompat;
import com.kwad.sdk.core.imageloader.core.decode.DecodedResult;
import com.kwad.sdk.core.imageloader.core.listener.SimpleImageLoadingListener;
import com.kwad.sdk.core.imageloader.utils.BlurUtils;
import com.kwad.sdk.core.response.model.AdResultData;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.video.videoview.AdVideoPlayerViewCache;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.al;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;
import com.kwad.sdk.widget.KSRelativeLayout;
import java.io.File;
import java.io.InputStream;
import java.util.Iterator;
import java.util.List;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public abstract class c extends a implements View.OnClickListener, com.kwad.sdk.widget.d {
    private boolean cA;
    private com.kwad.sdk.core.video.videoview.a cB;
    private com.kwad.sdk.core.video.videoview.a.InterfaceC0519a cK;
    private com.kwad.components.core.video.a.b cL;
    private OfflineOnAudioConflictListener cM;
    private KsAdVideoPlayConfig ce;
    private List<Integer> cv;
    private volatile boolean eQ;
    private com.kwad.sdk.widget.l eR;
    private TextView eq;
    private final AdLivePlayStateListener et;
    private IAdLiveOfflineView fC;
    private com.kwad.components.core.offline.a.c.a fD;
    private com.kwad.components.core.l.a.b fP;
    private View fR;
    private ImageView gI;
    private TextView gP;
    private TextView hO;
    private ImageView hQ;
    private TextView hS;
    private TextView hT;
    private View hU;
    private DownloadProgressView hV;
    private boolean hW;
    private int hX;
    protected KSRelativeLayout hZ;
    private ImageView ia;
    private com.kwad.components.core.video.e ib;
    private d ic;
    private TextView ie;

    /* JADX INFO: renamed from: if, reason: not valid java name */
    private final com.kwad.components.core.video.a.InterfaceC0460a f3if;
    private IAdLivePlayModule ig;
    private boolean ih;
    protected com.kwad.components.core.e.d.d mApkDownloadHelper;
    private boolean mIsAudioEnable;
    private KsLogoView mLogoView;

    protected int getDefaultClickArea() {
        return 2;
    }

    static /* synthetic */ boolean b(c cVar, boolean z) {
        cVar.cA = false;
        return false;
    }

    public void setVideoPlayConfig(KsAdVideoPlayConfig ksAdVideoPlayConfig) {
        com.kwad.components.core.video.e eVar;
        IAdLivePlayModule iAdLivePlayModule;
        this.ce = ksAdVideoPlayConfig;
        if (ksAdVideoPlayConfig instanceof KSAdVideoPlayConfigImpl) {
            KSAdVideoPlayConfigImpl kSAdVideoPlayConfigImpl = (KSAdVideoPlayConfigImpl) ksAdVideoPlayConfig;
            if (kSAdVideoPlayConfigImpl.getVideoSoundValue() != 0) {
                this.mIsAudioEnable = kSAdVideoPlayConfigImpl.isVideoSoundEnable();
            } else {
                this.mIsAudioEnable = com.kwad.sdk.core.response.helper.a.ch(this.mAdInfo);
            }
            this.mAdTemplate.mIsAudioEnable = this.mIsAudioEnable;
            IAdLiveOfflineView iAdLiveOfflineView = this.fC;
            if (iAdLiveOfflineView != null && iAdLiveOfflineView.getView() != null && (iAdLivePlayModule = this.ig) != null) {
                iAdLivePlayModule.setAudioEnabled(h(this.mIsAudioEnable), false);
            } else {
                com.kwad.sdk.core.video.videoview.a aVar = this.cB;
                if (aVar != null) {
                    aVar.setVideoSoundEnable(h(this.mIsAudioEnable));
                }
            }
            if (this.mIsAudioEnable) {
                com.kwad.components.core.t.a.aN(this.mContext).a(this.cM);
            }
            if (kSAdVideoPlayConfigImpl.getDataFlowAutoStartValue() == 0 || (eVar = this.ib) == null) {
                return;
            }
            eVar.setDataAutoStart(kSAdVideoPlayConfigImpl.isDataFlowAutoStart());
        }
    }

    public c(Context context) {
        super(context);
        this.mIsAudioEnable = false;
        this.eQ = false;
        this.hW = true;
        this.hX = 8;
        this.eR = new com.kwad.sdk.widget.l() { // from class: com.kwad.components.ad.feed.widget.c.1
            @Override // com.kwad.sdk.widget.l
            public final void aV() {
                com.kwad.sdk.utils.o.fp(c.this.mAdTemplate);
            }
        };
        this.f3if = new com.kwad.components.core.video.a.InterfaceC0460a() { // from class: com.kwad.components.ad.feed.widget.c.4
            @Override // com.kwad.components.core.video.a.InterfaceC0460a
            public final void a(int i, al.a aVar) {
                int i2;
                int i3 = 2;
                boolean z = false;
                if (i == 1) {
                    i2 = 15;
                } else if (i == 2) {
                    i2 = 16;
                } else if (i != 3) {
                    i2 = 35;
                } else {
                    i2 = 39;
                    i3 = 1;
                    z = true;
                }
                c.this.cl();
                com.kwad.components.core.e.d.a.a(new com.kwad.components.core.e.d.a.C0428a(c.this.getContext()).aF(c.this.mAdTemplate).b(c.this.mApkDownloadHelper).aD(i3).as(z).au(true).aB(5).aC(i2).d(aVar).aw(true).a(new com.kwad.components.core.e.d.a.b() { // from class: com.kwad.components.ad.feed.widget.c.4.1
                    @Override // com.kwad.components.core.e.d.a.b
                    public final void onAdClicked() {
                        c.this.zZ();
                    }
                }));
            }
        };
        this.et = new AdLivePlayStateListenerAdapter() { // from class: com.kwad.components.ad.feed.widget.c.8
            @Override // com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListenerAdapter, com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListener
            public final void onLivePlayProgress(long j) {
                super.onLivePlayProgress(j);
                c.this.c(j);
            }

            @Override // com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListenerAdapter, com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListener
            public final void onLivePlayEnd() {
                super.onLivePlayEnd();
                c.this.ie.setVisibility(0);
            }

            @Override // com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListenerAdapter, com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListener
            public final void onLivePlayStart() {
                super.onLivePlayStart();
                if (c.this.ig != null) {
                    com.kwad.components.core.l.a.ty().a(c.this.getCurrentVoiceItem());
                    IAdLivePlayModule iAdLivePlayModule = c.this.ig;
                    c cVar = c.this;
                    iAdLivePlayModule.setAudioEnabled(cVar.h(cVar.mIsAudioEnable), false);
                }
            }

            @Override // com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListenerAdapter, com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListener
            public final void onLivePlayResume() {
                super.onLivePlayResume();
                if (c.this.ig != null) {
                    com.kwad.components.core.l.a.ty().a(c.this.getCurrentVoiceItem());
                    IAdLivePlayModule iAdLivePlayModule = c.this.ig;
                    c cVar = c.this;
                    iAdLivePlayModule.setAudioEnabled(cVar.h(cVar.mIsAudioEnable), false);
                }
            }
        };
        this.cM = new OfflineOnAudioConflictListener() { // from class: com.kwad.components.ad.feed.widget.c.10
            @Override // com.kwad.components.offline.api.core.api.OfflineOnAudioConflictListener
            public final void onAudioBeReleased() {
            }

            @Override // com.kwad.components.offline.api.core.api.OfflineOnAudioConflictListener
            public final void onAudioBeOccupied() {
                c.b(c.this, false);
                if (c.this.cB != null) {
                    c.this.cB.setVideoSoundEnable(false);
                }
                if (c.this.ig != null) {
                    c.this.ig.setAudioEnabled(false, false);
                }
            }
        };
        this.cL = new com.kwad.components.core.video.a.b() { // from class: com.kwad.components.ad.feed.widget.c.2
            @Override // com.kwad.components.core.video.a.c
            public final void d(long j) {
                c.this.c(j);
            }

            @Override // com.kwad.components.core.video.a.c
            public final void onVideoPlayStart() {
                com.kwad.components.core.l.a.ty().a(c.this.getCurrentVoiceItem());
                if (c.this.ic != null && (c.this.ic.getParent() instanceof ViewGroup)) {
                    ((ViewGroup) c.this.ic.getParent()).removeView(c.this.ic);
                    c.this.ic.cB();
                    c.this.ic = null;
                }
                com.kwad.components.ad.feed.monitor.b.a(c.this.mAdTemplate, 1, 1, com.kwad.sdk.core.response.helper.a.M(c.this.mAdInfo), null, SystemClock.elapsedRealtime() - c.this.hH);
                com.kwad.sdk.core.adlog.c.cp(c.this.mAdTemplate);
            }

            @Override // com.kwad.components.core.video.a.c
            public final void as() {
                com.kwad.sdk.core.video.videoview.a aVar = c.this.cB;
                c cVar = c.this;
                aVar.setVideoSoundEnable(cVar.h(cVar.mIsAudioEnable));
            }

            @Override // com.kwad.components.core.video.a.c
            public final void at() {
                if (com.kwad.components.ad.feed.a.b.ch() && c.this.ic == null) {
                    c.this.ic = new d(c.this.getContext());
                    FrameLayout.LayoutParams layoutParams = new FrameLayout.LayoutParams(-1, -1);
                    c cVar = c.this;
                    cVar.addView(cVar.ic, layoutParams);
                    c.this.ic.cA();
                }
                if (c.this.ib.amq != null && c.this.cy()) {
                    ((ViewGroup) c.this.ib.amq.getParent()).removeView(c.this.ib.amq);
                    c.this.hZ.addView(c.this.ib.amq);
                }
                com.kwad.sdk.core.adlog.c.cq(c.this.mAdTemplate);
            }

            @Override // com.kwad.components.core.video.a.b
            public final void onVideoPlayError(int i, int i2) {
                com.kwad.components.ad.feed.monitor.b.a(c.this.mAdTemplate, 2, 1, com.kwad.sdk.core.response.helper.a.M(c.this.mAdInfo), i + " " + i2, SystemClock.elapsedRealtime() - c.this.hH);
            }
        };
    }

    @Override // com.kwad.components.core.widget.b
    public void by() {
        this.hO = (TextView) findViewById(R.id.ksad_ad_desc);
        this.hZ = (KSRelativeLayout) findViewById(R.id.ksad_feed_ad_video_container);
        ct();
        this.hQ = (ImageView) findViewById(R.id.ksad_ad_dislike);
        this.ia = (ImageView) findViewById(R.id.ksad_video_first_frame_container);
        this.mLogoView = (KsLogoView) findViewById(R.id.ksad_ad_dislike_logo);
        this.hV = (DownloadProgressView) findViewById(R.id.ksad_app_download_btn);
        this.ie = (TextView) findViewById(R.id.ksad_live_end_text);
        this.fR = findViewById(R.id.ksad_live_end_bg_mantle);
    }

    protected void ct() {
        this.hZ.setRatio(0.56f);
    }

    @Override // com.kwad.components.core.widget.b, com.kwad.sdk.core.j.c
    public final void bv() {
        super.bv();
        com.kwad.components.core.video.e eVar = this.ib;
        if (eVar != null) {
            eVar.setVideoPlayCallback(this.cL);
        }
        com.kwad.components.core.l.a.ty().a(getCurrentVoiceItem());
        if (this.ih) {
            IAdLivePlayModule iAdLivePlayModule = this.ig;
            if (iAdLivePlayModule == null) {
                this.ig = cw();
            } else {
                iAdLivePlayModule.onResume();
            }
        }
    }

    @Override // com.kwad.components.core.widget.b, com.kwad.sdk.core.j.c
    public final void bw() {
        super.bw();
        IAdLivePlayModule iAdLivePlayModule = this.ig;
        if (iAdLivePlayModule != null) {
            iAdLivePlayModule.onPause();
        }
        com.kwad.components.core.l.a.ty().c(this.fP);
    }

    @Override // com.kwad.components.core.widget.b
    public final void cs() {
        super.cs();
        com.kwad.components.core.e.d.d dVar = this.mApkDownloadHelper;
        if (dVar != null) {
            dVar.c(this.hV.getAppDownloadListener());
        }
        if (this.mIsAudioEnable) {
            com.kwad.components.core.t.a.aN(this.mContext).b(this.cM);
        }
    }

    @Override // com.kwad.components.core.widget.b
    public final void d(AdResultData adResultData) {
        super.d(adResultData);
        this.hO.setText(com.kwad.components.ad.feed.f.l(this.mAdTemplate));
        this.mLogoView.bh(this.mAdTemplate);
        cu();
        if (com.kwad.sdk.core.response.helper.a.aL(this.mAdInfo)) {
            findViewById(R.id.ksad_ad_download_container).setVisibility(0);
            findViewById(R.id.ksad_ad_h5_container).setVisibility(8);
            cp();
            cz();
        } else {
            findViewById(R.id.ksad_ad_h5_container).setVisibility(0);
            findViewById(R.id.ksad_ad_download_container).setVisibility(8);
            if (cy()) {
                cp();
            }
            co();
        }
        this.hO.setOnClickListener(this);
        this.hZ.setOnClickListener(this);
        this.hQ.setOnClickListener(this);
        new com.kwad.sdk.widget.h(getContext(), this.hO, this);
        new com.kwad.sdk.widget.h(getContext(), this.hZ, this);
        new com.kwad.sdk.widget.h(getContext(), this.hQ, this);
        setOnClickListener(this);
    }

    private void cu() {
        com.kwad.components.core.offline.a.c.a aVar = (com.kwad.components.core.offline.a.c.a) com.kwad.sdk.components.d.f(com.kwad.components.core.offline.a.c.a.class);
        this.fD = aVar;
        if (aVar != null && aVar.tG() && com.kwad.sdk.core.response.helper.a.cY(this.mAdInfo)) {
            this.ih = true;
            cx();
        }
    }

    @Override // com.kwad.sdk.widget.KSFrameLayout, android.view.View
    public void onWindowFocusChanged(boolean z) {
        IAdLivePlayModule iAdLivePlayModule;
        try {
            if (this.mAdInfo == null) {
                return;
            }
            super.onWindowFocusChanged(z);
            if (z) {
                if (cv()) {
                    return;
                }
                com.kwad.sdk.core.video.videoview.a aVar = this.cB;
                if (aVar != null && this.ib != null) {
                    ViewGroup viewGroup = (ViewGroup) aVar.getParent();
                    if (this.cB.getParent() != this.hZ) {
                        viewGroup.removeView(this.cB);
                        if (this.hZ.getTag() != null) {
                            KSRelativeLayout kSRelativeLayout = this.hZ;
                            kSRelativeLayout.removeView((View) kSRelativeLayout.getTag());
                            this.hZ.setTag(null);
                        }
                        this.hZ.addView(this.cB);
                        this.hZ.setTag(this.cB);
                        this.cB.setVideoSoundEnable(this.mIsAudioEnable);
                        this.mAdTemplate.mIsAudioEnable = this.mIsAudioEnable;
                        this.ib.setAdClickListener(getVideoAdClickListener());
                        this.ib.getAdTemplate().mAdWebVideoPageShowing = false;
                        this.ib.xT();
                        this.ib.setAutoRelease(true);
                    }
                }
                if (this.mAdInfo != null) {
                    AdVideoPlayerViewCache.getInstance().remove(com.kwad.sdk.core.response.helper.a.M(this.mAdInfo));
                    return;
                }
                return;
            }
            IAdLiveOfflineView iAdLiveOfflineView = this.fC;
            if (iAdLiveOfflineView == null || iAdLiveOfflineView.getView() == null || (iAdLivePlayModule = this.ig) == null) {
                return;
            }
            iAdLivePlayModule.onPause();
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    protected com.kwad.components.core.video.a.InterfaceC0460a getVideoAdClickListener() {
        return this.f3if;
    }

    private boolean cv() {
        IAdLiveOfflineView iAdLiveOfflineView = this.fC;
        if (iAdLiveOfflineView == null || iAdLiveOfflineView.getView() == null || !this.ih) {
            return false;
        }
        ViewGroup viewGroup = (ViewGroup) this.fC.getView().getParent();
        if (viewGroup != this.hZ) {
            viewGroup.removeView(this.fC.getView());
            if (this.hZ.getTag() != null) {
                KSRelativeLayout kSRelativeLayout = this.hZ;
                kSRelativeLayout.removeView((View) kSRelativeLayout.getTag());
                this.hZ.setTag(null);
            }
            this.hZ.addView(this.fC.getView());
            this.hZ.setTag(this.fC.getView());
            IAdLivePlayModule adLivePlayModule = this.fD.getAdLivePlayModule(this.fC, ServiceProvider.getAppId(), String.valueOf(com.kwad.sdk.core.response.helper.a.cw(this.mAdInfo)), com.kwad.sdk.core.response.helper.a.cx(this.mAdInfo), com.kwad.sdk.core.response.helper.a.cy(this.mAdInfo), com.kwad.sdk.core.response.helper.e.eG(this.mAdTemplate));
            this.ig = adLivePlayModule;
            adLivePlayModule.setAudioEnabled(this.mIsAudioEnable, false);
            this.ig.registerAdLivePlayStateListener(this.et);
        }
        IAdLivePlayModule iAdLivePlayModule = this.ig;
        if (iAdLivePlayModule == null) {
            return true;
        }
        iAdLivePlayModule.onResume();
        return true;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public IAdLivePlayModule cw() {
        IAdLiveOfflineView iAdLiveOfflineViewA = com.kwad.components.ad.j.c.a(this.fD, this.mContext, 3);
        this.fC = iAdLiveOfflineViewA;
        if (iAdLiveOfflineViewA == null) {
            return null;
        }
        IAdLivePlayModule adLivePlayModule = this.fD.getAdLivePlayModule(iAdLiveOfflineViewA, ServiceProvider.getSDKConfig().appId, String.valueOf(com.kwad.sdk.core.response.helper.a.cw(this.mAdInfo)), com.kwad.sdk.core.response.helper.a.cx(this.mAdInfo), com.kwad.sdk.core.response.helper.a.cy(this.mAdInfo), com.kwad.sdk.core.response.helper.e.eG(this.mAdTemplate));
        adLivePlayModule.setAudioEnabled(h(this.mIsAudioEnable), false);
        adLivePlayModule.registerAdLivePlayStateListener(this.et);
        final View view = this.fC.getView();
        if (this.hZ.getTag() != null) {
            KSRelativeLayout kSRelativeLayout = this.hZ;
            kSRelativeLayout.removeView((View) kSRelativeLayout.getTag());
            this.hZ.setTag(null);
        }
        this.hZ.addView(view);
        this.hZ.setTag(view);
        by.postOnUiThread(new bi() { // from class: com.kwad.components.ad.feed.widget.c.5
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                c.this.c(view);
            }
        });
        if (this.mIsAudioEnable) {
            com.kwad.components.core.t.a.aN(this.mContext).a(this.cM);
        }
        return adLivePlayModule;
    }

    private void cx() {
        String url = com.kwad.sdk.core.response.helper.a.bA(this.mAdInfo).getUrl();
        this.ia.setVisibility(0);
        this.fR.setVisibility(0);
        if (!TextUtils.isEmpty(url)) {
            this.ia.setImageDrawable(null);
            KSImageLoader.loadImage(this.ia, url, this.mAdTemplate, new DisplayImageOptionsCompat.Builder().setBlurRadius(50).build(), new SimpleImageLoadingListener() { // from class: com.kwad.components.ad.feed.widget.c.6
                @Override // com.kwad.sdk.core.imageloader.core.listener.SimpleImageLoadingListener, com.kwad.sdk.core.imageloader.core.listener.ImageLoadingListener
                public final boolean onDecode(String str, InputStream inputStream, DecodedResult decodedResult) {
                    decodedResult.mBitmap = BlurUtils.stackBlur(BitmapFactory.decodeStream(inputStream), 50, false);
                    return true;
                }
            });
        } else {
            this.ia.setImageResource(R.drawable.ksad_ad_live_end);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void c(final View view) {
        view.post(new bi() { // from class: com.kwad.components.ad.feed.widget.c.7
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                int width = c.this.hZ.getWidth();
                int height = c.this.hZ.getHeight();
                if (width == 0 || height == 0) {
                    return;
                }
                RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams((int) (height * 0.5625f), height);
                layoutParams.addRule(13, -1);
                view.setLayoutParams(layoutParams);
            }
        });
    }

    public final void b(KsAdVideoPlayConfig ksAdVideoPlayConfig) {
        String strFv;
        this.ce = ksAdVideoPlayConfig;
        if ((ksAdVideoPlayConfig instanceof KSAdVideoPlayConfigImpl) && ((KSAdVideoPlayConfigImpl) ksAdVideoPlayConfig).getVideoSoundValue() != 0) {
            this.mIsAudioEnable = ksAdVideoPlayConfig.isVideoSoundEnable();
        } else {
            this.mIsAudioEnable = com.kwad.sdk.core.response.helper.a.ch(this.mAdInfo);
        }
        this.mAdTemplate.mIsAudioEnable = this.mIsAudioEnable;
        this.cv = com.kwad.sdk.core.response.helper.a.bv(this.mAdInfo);
        if (this.ih) {
            return;
        }
        String url = com.kwad.sdk.core.response.helper.a.bA(this.mAdInfo).getUrl();
        if (!TextUtils.isEmpty(url)) {
            this.ia.setScaleType(ImageView.ScaleType.FIT_CENTER);
            this.ia.setImageDrawable(null);
            KSImageLoader.loadImage(this.ia, url, this.mAdTemplate);
            this.ia.setVisibility(0);
        } else {
            this.ia.setVisibility(8);
        }
        com.kwad.sdk.core.video.videoview.a aVar = new com.kwad.sdk.core.video.videoview.a(this.mContext);
        this.cB = aVar;
        aVar.setVisibleListener(this.eR);
        this.cB.setOnClickListener(this);
        new com.kwad.sdk.widget.h(getContext(), this.cB, this);
        this.cB.setTag(this.cv);
        int iGm = com.kwad.sdk.core.config.e.Gm();
        String strM = com.kwad.sdk.core.response.helper.a.M(this.mAdInfo);
        if (TextUtils.isEmpty(strM)) {
            return;
        }
        if (iGm < 0) {
            File fileCM = com.kwad.sdk.core.diskcache.b.a.LI().cM(strM);
            if (fileCM == null || !fileCM.exists()) {
                strM = null;
            } else {
                strFv = fileCM.getAbsolutePath();
                strM = strFv;
            }
        } else if (iGm != 0) {
            com.kwad.sdk.core.videocache.f fVarCl = com.kwad.sdk.core.videocache.c.a.cl(this.mContext);
            if (com.kwad.sdk.core.config.e.Jz()) {
                int iGm2 = com.kwad.sdk.core.config.e.Gm();
                if (!fVarCl.fx(strM)) {
                    if (fVarCl.a(strM, iGm2 * 1024, new com.kwad.sdk.core.network.a.a.C0515a(), null)) {
                        strFv = fVarCl.fv(strM);
                    }
                } else {
                    strFv = fVarCl.fv(strM);
                }
                strM = strFv;
            } else {
                strM = fVarCl.fv(strM);
            }
        }
        if (TextUtils.isEmpty(strM)) {
            return;
        }
        this.cB.a(new com.kwad.sdk.contentalliance.a.a.b.a(this.mAdTemplate).dO(strM).dP(com.kwad.sdk.core.response.helper.h.b(com.kwad.sdk.core.response.helper.e.eN(this.mAdTemplate))).a(this.mAdTemplate.mVideoPlayerStatus).b(com.kwad.sdk.contentalliance.a.a.a.ci(this.mAdTemplate)).IS(), null);
        com.kwad.sdk.core.video.videoview.a.InterfaceC0519a interfaceC0519a = new com.kwad.sdk.core.video.videoview.a.InterfaceC0519a() { // from class: com.kwad.components.ad.feed.widget.c.9
            @Override // com.kwad.sdk.core.video.videoview.a.InterfaceC0519a
            public final com.kwad.sdk.core.video.a.c a(com.kwad.sdk.contentalliance.a.a.b bVar) {
                if (!((Boolean) com.kwad.sdk.core.config.e.b(com.kwad.sdk.core.config.c.aQq)).booleanValue() || !((Boolean) com.kwad.sdk.core.config.e.b(com.kwad.sdk.core.config.c.aQr)).booleanValue()) {
                    return null;
                }
                com.kwad.components.core.video.g gVar = new com.kwad.components.core.video.g(bVar, c.this.mAdTemplate);
                if (com.kwad.components.core.video.g.isWaynePlayerReady()) {
                    return gVar;
                }
                return null;
            }
        };
        this.cK = interfaceC0519a;
        this.cB.setExternalPlayerListener(interfaceC0519a);
        this.cB.setVideoSoundEnable(h(this.mIsAudioEnable));
        com.kwad.components.core.video.e eVar = new com.kwad.components.core.video.e(this.mContext, this.mAdTemplate, this.cB, ksAdVideoPlayConfig);
        this.ib = eVar;
        eVar.setAdClickListener(getVideoAdClickListener());
        this.hH = SystemClock.elapsedRealtime();
        this.ib.setVideoPlayCallback(this.cL);
        this.cB.setController(this.ib);
        if (this.hZ.getTag() != null) {
            KSRelativeLayout kSRelativeLayout = this.hZ;
            kSRelativeLayout.removeView((View) kSRelativeLayout.getTag());
            this.hZ.setTag(null);
        }
        this.hZ.addView(this.cB);
        this.hZ.setTag(this.cB);
        if (cy()) {
            ViewGroup viewGroup = (ViewGroup) findViewById(R.id.ksad_feed_bottombar_container);
            ((ViewGroup) viewGroup.getParent()).removeView(viewGroup);
            this.hZ.addView(viewGroup);
        }
        this.hZ.setClickable(true);
        this.hZ.setOnClickListener(this);
        new com.kwad.sdk.widget.h(getContext(), this.hZ, this);
        if (this.mIsAudioEnable) {
            com.kwad.components.core.t.a.aN(this.mContext).a(this.cM);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public boolean h(boolean z) {
        if (!z) {
            return false;
        }
        if (!com.kwad.sdk.core.config.e.hM()) {
            if (com.kwad.components.core.t.a.aN(this.mContext).wQ()) {
                return !com.kwad.components.core.t.a.aN(this.mContext).wP();
            }
            return com.kwad.components.core.t.a.aN(this.mContext).bd(false);
        }
        if (!this.cA) {
            this.cA = com.kwad.components.core.t.a.aN(this.mContext).bd(true);
        }
        return this.cA;
    }

    protected final boolean cy() {
        if (FeedType.isNewVerticalType(com.kwad.sdk.core.response.helper.e.fh(this.mAdTemplate))) {
            return com.kwad.sdk.core.response.helper.e.fi(this.mAdTemplate) == FeedType.FeedDefaultType.FEED_VERTICAL_NOVEL_DEFAULT.getDefaultType() || com.kwad.sdk.core.response.helper.e.fi(this.mAdTemplate) == FeedType.FeedDefaultType.FEED_VERTICAL_BISERIAL_DEFAULT.getDefaultType();
        }
        return false;
    }

    private void co() {
        this.hT = (TextView) findViewById(R.id.ksad_h5_desc);
        this.gP = (TextView) findViewById(R.id.ksad_h5_open_btn);
        this.hU = findViewById(R.id.ksad_h5_open_cover);
        this.hT.setText(com.kwad.components.ad.feed.f.l(this.mAdTemplate));
        this.gP.setText(com.kwad.sdk.core.response.helper.a.aK(this.mAdInfo));
        this.hU.setOnClickListener(this);
        this.hT.setOnClickListener(this);
        this.gP.setOnClickListener(this);
        new com.kwad.sdk.widget.h(getContext(), this.hU, this);
        new com.kwad.sdk.widget.h(getContext(), this.hT, this);
        new com.kwad.sdk.widget.h(getContext(), this.gP, this);
    }

    private void cp() {
        this.gI = (ImageView) findViewById(R.id.ksad_app_icon);
        this.eq = (TextView) findViewById(R.id.ksad_app_title);
        TextView textView = (TextView) findViewById(R.id.ksad_app_desc);
        this.hS = textView;
        com.kwad.sdk.c.a.a.a(this, this.gI, this.eq, textView);
        new com.kwad.sdk.widget.h(getContext(), this.gI, this);
        new com.kwad.sdk.widget.h(getContext(), this.eq, this);
        new com.kwad.sdk.widget.h(getContext(), this.hS, this);
        if (cy()) {
            this.eq.setText(com.kwad.sdk.core.response.helper.a.cs(this.mAdInfo));
        } else {
            this.eq.setText(com.kwad.sdk.core.response.helper.a.aB(this.mAdInfo));
        }
        this.gI.setImageResource(R.drawable.ksad_default_app_icon);
        KSImageLoader.loadAppIcon(this.gI, com.kwad.sdk.core.response.helper.a.cv(this.mAdInfo), this.mAdTemplate, this.hX);
        this.hS.setText(com.kwad.components.ad.feed.f.l(this.mAdTemplate));
        if (this.hW) {
            cm();
        }
    }

    private void cz() {
        this.hV.aw(this.mAdTemplate);
        this.hV.setOnClickListener(this);
        new com.kwad.sdk.widget.h(getContext(), this.hV, this);
        com.kwad.components.core.e.d.d dVar = new com.kwad.components.core.e.d.d(this.mAdTemplate, null, this.hV.getAppDownloadListener());
        this.mApkDownloadHelper = dVar;
        dVar.d(this.hV.getAppDownloadListener());
        this.mApkDownloadHelper.setOnShowListener(this);
        this.mApkDownloadHelper.setOnDismissListener(this);
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

    @Override // com.kwad.sdk.widget.d
    public final void a(View view) {
        onClick(view);
    }

    @Override // com.kwad.sdk.widget.d
    public final void a(View view, float f, float f2, float f3, float f4) {
        if (com.kwad.sdk.core.response.helper.d.eB(this.mAdTemplate)) {
            a(this.cB, view == this.hV, view, MediaPlayer.MEDIA_PLAYER_OPTION_GET_DROP_COUNT);
        }
    }

    /* JADX WARN: Code duplicated, block: B:19:0x003a  */
    @Override // android.view.View.OnClickListener
    public void onClick(View view) {
        int i;
        com.kwad.sdk.core.video.videoview.a aVar;
        if (view == this.hQ) {
            Aa();
            return;
        }
        if (view == this.hZ && (aVar = this.cB) != null && aVar.isIdle()) {
            com.kwad.sdk.utils.o.fo(this.mAdTemplate);
            this.cB.setKsPlayLogParam(com.kwad.sdk.contentalliance.a.a.a.ci(this.mAdTemplate));
            this.cB.start();
            return;
        }
        if (view == this.hO) {
            i = 25;
        } else if (view == this.hZ) {
            i = 100;
        } else if (view == this.hV || view == this.gP || view == this.hU) {
            i = 1;
        } else if (view == this.gI) {
            i = 13;
        } else if (view == this.eq) {
            i = 14;
        } else if (view == this.hS || view == this.hT) {
            i = 101;
        } else if (view == this.cB) {
            i = 100;
        } else {
            i = 35;
        }
        a(this.cB, view == this.hV, view, i);
    }

    private void a(com.kwad.sdk.core.video.videoview.a aVar, boolean z, View view, final int i) {
        com.kwad.components.core.video.e eVar;
        if (aVar != null || this.ih) {
            String strM = com.kwad.sdk.core.response.helper.a.M(this.mAdInfo);
            if (!this.ih && (eVar = this.ib) != null) {
                eVar.setAutoRelease(false);
            }
            int defaultClickArea = getDefaultClickArea();
            if (z || view == this.hV || view == this.gP || view == this.hU) {
                defaultClickArea = 1;
            }
            if (!this.ih) {
                AdVideoPlayerViewCache.getInstance().a(strM, this.cB);
            }
            cl();
            com.kwad.components.core.e.d.a.C0428a c0428aAs = new com.kwad.components.core.e.d.a.C0428a(getContext()).aF(this.mAdTemplate).b(this.mApkDownloadHelper).as(z);
            IAdLivePlayModule iAdLivePlayModule = this.ig;
            com.kwad.components.core.e.d.a.a(c0428aAs.A(iAdLivePlayModule == null ? 0L : iAdLivePlayModule.getPlayDuration()).aD(defaultClickArea).aw(true).a(new com.kwad.components.core.e.d.a.b() { // from class: com.kwad.components.ad.feed.widget.c.11
                @Override // com.kwad.components.core.e.d.a.b
                public final void onAdClicked() {
                    c.this.bO(i);
                }
            }));
        }
    }

    @Override // com.kwad.components.core.widget.b, com.kwad.sdk.widget.KSFrameLayout
    public final void ae() {
        DownloadProgressView downloadProgressView;
        super.ae();
        com.kwad.components.core.e.d.d dVar = this.mApkDownloadHelper;
        if (dVar == null || (downloadProgressView = this.hV) == null) {
            return;
        }
        dVar.b(downloadProgressView.getAppDownloadListener());
    }

    @Override // com.kwad.components.core.widget.b, com.kwad.sdk.widget.KSFrameLayout
    public final void af() {
        super.af();
        com.kwad.sdk.utils.o.fn(this.mAdTemplate);
        IAdLivePlayModule iAdLivePlayModule = this.ig;
        if (iAdLivePlayModule != null) {
            iAdLivePlayModule.onDestroy();
            this.ig = null;
        }
        IAdLiveOfflineView iAdLiveOfflineView = this.fC;
        if (iAdLiveOfflineView != null) {
            iAdLiveOfflineView.onDestroy();
            this.fC = null;
        }
        com.kwad.components.core.l.a.ty().c(this.fP);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public com.kwad.components.core.l.a.b getCurrentVoiceItem() {
        if (this.fP == null) {
            this.fP = new com.kwad.components.core.l.a.b(new com.kwad.components.core.l.a.c() { // from class: com.kwad.components.ad.feed.widget.c.3
                @Override // com.kwad.components.core.l.a.c
                public final void bH() {
                    if (c.this.ih) {
                        if (c.this.ig == null) {
                            c cVar = c.this;
                            cVar.ig = cVar.cw();
                        }
                        if (c.this.ig != null) {
                            IAdLivePlayModule iAdLivePlayModule = c.this.ig;
                            c cVar2 = c.this;
                            iAdLivePlayModule.setAudioEnabled(cVar2.h(cVar2.mIsAudioEnable), false);
                            return;
                        }
                        return;
                    }
                    if (c.this.cB != null) {
                        com.kwad.sdk.core.video.videoview.a aVar = c.this.cB;
                        c cVar3 = c.this;
                        aVar.setVideoSoundEnable(cVar3.h(cVar3.mIsAudioEnable));
                    }
                }
            });
        }
        return this.fP;
    }

    public void setmIsShowComplianceView(boolean z) {
        this.hW = z;
    }

    public void setRadiusDp(int i) {
        this.hX = i;
    }
}
