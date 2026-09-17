package com.kwad.components.ad.feed.widget;

import android.animation.Animator;
import android.animation.AnimatorListenerAdapter;
import android.content.Context;
import android.graphics.BitmapFactory;
import android.os.Handler;
import android.os.Looper;
import android.os.SystemClock;
import android.text.TextUtils;
import android.view.MotionEvent;
import android.view.View;
import android.view.ViewGroup;
import android.widget.FrameLayout;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.RelativeLayout;
import android.widget.TextView;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.kwad.components.core.internal.api.KSAdVideoPlayConfigImpl;
import com.kwad.components.core.liveEnd.AdLiveEndCommonResultData;
import com.kwad.components.core.page.AdWebViewActivityProxy;
import com.kwad.components.core.webview.jshandler.WebCardRegisterLiveMessageListener;
import com.kwad.components.core.webview.jshandler.WebCardRegisterLiveShopListener;
import com.kwad.components.core.webview.jshandler.WebCardVideoPositionHandler;
import com.kwad.components.core.webview.jshandler.ad;
import com.kwad.components.core.webview.jshandler.ae;
import com.kwad.components.core.webview.jshandler.aq;
import com.kwad.components.core.webview.jshandler.as;
import com.kwad.components.core.webview.jshandler.at;
import com.kwad.components.core.webview.jshandler.az;
import com.kwad.components.core.webview.jshandler.ba;
import com.kwad.components.core.webview.jshandler.bb;
import com.kwad.components.core.webview.jshandler.be;
import com.kwad.components.model.FeedType;
import com.kwad.components.offline.api.core.adlive.IAdLiveEndRequest;
import com.kwad.components.offline.api.core.adlive.IAdLiveOfflineView;
import com.kwad.components.offline.api.core.adlive.IAdLivePlayModule;
import com.kwad.components.offline.api.core.adlive.listener.AdLiveMessageListener;
import com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListener;
import com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListenerAdapter;
import com.kwad.components.offline.api.core.adlive.listener.AdLiveShopListener;
import com.kwad.components.offline.api.core.adlive.model.AdLiveMessageInfo;
import com.kwad.components.offline.api.core.adlive.model.AdLiveShopInfo;
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
import com.kwad.sdk.core.response.model.BaseResultData;
import com.kwad.sdk.core.response.model.FeedSlideConf;
import com.kwad.sdk.core.video.videoview.AdVideoPlayerViewCache;
import com.kwad.sdk.core.webview.KsAdWebView;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.al;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;
import com.kwad.sdk.utils.cb;
import com.kwad.sdk.widget.KSRelativeLayout;
import com.kwad.sdk.widget.RatioFrameLayout;
import java.io.File;
import java.io.InputStream;
import java.util.HashMap;
import java.util.Iterator;
import java.util.List;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class q extends com.kwad.components.core.widget.b<AdResultData, AdTemplate> implements View.OnClickListener, com.kwad.sdk.widget.d {
    private static final HashMap<Long, Double> iT = new HashMap<>(8);
    private boolean cA;
    private com.kwad.sdk.core.video.videoview.a cB;
    private com.kwad.sdk.core.video.videoview.a.InterfaceC0519a cK;
    private OfflineOnAudioConflictListener cM;
    private KsAdVideoPlayConfig ce;
    private List<Integer> cv;
    private final AdLivePlayStateListener et;
    private IAdLiveOfflineView fC;
    private com.kwad.components.core.offline.a.c.a fD;
    private com.kwad.components.core.l.a.b fP;
    private View fR;
    private int fe;
    private long hH;
    private float hI;
    private float hJ;
    private KSRelativeLayout hZ;
    private com.kwad.components.ad.feed.d.InterfaceC0364d hv;
    private RatioFrameLayout iL;
    private double iM;
    private LinearLayout iN;
    private TextView iO;
    private be iP;
    private az iQ;
    private WebCardRegisterLiveMessageListener iR;
    private WebCardRegisterLiveShopListener iS;
    private boolean iU;
    private String iV;
    private ba.b iW;
    private ba.a iX;
    private com.kwad.components.core.widget.b iY;
    private boolean iZ;
    private ImageView ia;
    private com.kwad.components.core.video.e ib;
    private d ic;

    /* JADX INFO: renamed from: if, reason: not valid java name */
    private final com.kwad.components.core.video.a.InterfaceC0460a f6if;
    private IAdLivePlayModule ig;
    private boolean ih;
    private boolean isNative;
    private a ja;
    private ViewGroup.MarginLayoutParams jb;
    private Handler jc;
    private e jd;
    private at je;
    private boolean jf;
    private boolean jg;
    private com.kwad.components.core.webview.b jh;
    private com.kwad.components.core.webview.c ji;
    private com.kwad.components.core.widget.b.a jj;
    private IAdLiveEndRequest jk;
    private KsAdWebView mAdWebView;
    private com.kwad.components.core.e.d.d mApkDownloadHelper;
    private boolean mIsAudioEnable;
    private final com.kwad.sdk.core.network.l<com.kwad.components.core.liveEnd.a, AdLiveEndCommonResultData> mNetworking;
    private int mWidth;

    public interface a {
        void d(int i, String str);
    }

    @Override // android.view.View.OnClickListener
    public final void onClick(View view) {
    }

    @Override // com.kwad.components.core.widget.b
    public final void setMargin(int i) {
    }

    static /* synthetic */ boolean a(q qVar, com.kwad.sdk.core.webview.d.b.a aVar) {
        return b(aVar);
    }

    static /* synthetic */ boolean a(q qVar, boolean z) {
        qVar.cA = false;
        return false;
    }

    static /* synthetic */ boolean d(q qVar, boolean z) {
        qVar.jf = true;
        return true;
    }

    public q(Context context) {
        super(context);
        this.fe = -1;
        this.mIsAudioEnable = false;
        this.isNative = false;
        this.jc = new Handler(Looper.getMainLooper());
        this.jf = false;
        this.jg = false;
        this.cM = new OfflineOnAudioConflictListener() { // from class: com.kwad.components.ad.feed.widget.q.1
            @Override // com.kwad.components.offline.api.core.api.OfflineOnAudioConflictListener
            public final void onAudioBeReleased() {
            }

            @Override // com.kwad.components.offline.api.core.api.OfflineOnAudioConflictListener
            public final void onAudioBeOccupied() {
                q.a(q.this, false);
                if (q.this.cB != null) {
                    q.this.cB.setVideoSoundEnable(false);
                }
                if (q.this.ig != null) {
                    q.this.ig.setAudioEnabled(false, false);
                }
            }
        };
        this.ji = new AnonymousClass12();
        this.jj = new com.kwad.components.core.widget.b.a() { // from class: com.kwad.components.ad.feed.widget.q.14
            @Override // com.kwad.components.core.widget.b.a
            public final void onAdClicked() {
                if (q.this.avu != null) {
                    q.this.avu.onAdClicked();
                }
            }

            @Override // com.kwad.components.core.widget.b.a
            public final void onAdShow() {
                if (q.this.avu != null && q.this.isNative) {
                    q.this.avu.onAdShow();
                }
                if (q.this.isNative) {
                    com.kwad.sdk.core.adlog.c.b bVar = new com.kwad.sdk.core.adlog.c.b();
                    com.kwad.sdk.core.adlog.a.C0502a c0502a = new com.kwad.sdk.core.adlog.a.C0502a();
                    FeedType feedTypeFromInt = FeedType.fromInt(q.this.mAdTemplate.type, q.this.mAdTemplate.defaultType);
                    if (feedTypeFromInt == FeedType.FEED_TYPE_TEXT_NEW) {
                        feedTypeFromInt = FeedType.FEED_TYPE_TEXT_BELOW;
                    }
                    c0502a.templateId = String.valueOf(feedTypeFromInt.getType());
                    bVar.b(c0502a);
                    bVar.z((int) Math.ceil(q.this.iM), q.this.mWidth);
                    com.kwad.components.core.t.b.wR().a(q.this.mAdTemplate, null, bVar);
                    com.kwad.components.ad.feed.monitor.b.c(q.this.mAdTemplate, 1, 2);
                }
            }

            @Override // com.kwad.components.core.widget.b.a
            public final void onDislikeClicked() {
                if (q.this.avu != null) {
                    q.this.avu.onDislikeClicked();
                }
            }

            @Override // com.kwad.components.core.widget.b.a
            public final void onDownloadTipsDialogShow() {
                if (q.this.avu != null) {
                    q.this.avu.onDownloadTipsDialogShow();
                }
            }

            @Override // com.kwad.components.core.widget.b.a
            public final void onDownloadTipsDialogDismiss() {
                if (q.this.avu != null) {
                    q.this.avu.onDownloadTipsDialogDismiss();
                }
            }
        };
        this.mNetworking = new com.kwad.sdk.core.network.l<com.kwad.components.core.liveEnd.a, AdLiveEndCommonResultData>() { // from class: com.kwad.components.ad.feed.widget.q.16
            @Override // com.kwad.sdk.core.network.l
            public final boolean isPostByJson() {
                return false;
            }

            @Override // com.kwad.sdk.core.network.l
            public final /* synthetic */ BaseResultData parseData(String str) {
                return u(str);
            }

            private static AdLiveEndCommonResultData u(String str) {
                AdLiveEndCommonResultData adLiveEndCommonResultData = new AdLiveEndCommonResultData();
                adLiveEndCommonResultData.parseJson(new JSONObject(str));
                return adLiveEndCommonResultData;
            }

            /* JADX INFO: Access modifiers changed from: private */
            @Override // com.kwad.sdk.core.network.a
            /* JADX INFO: renamed from: cO, reason: merged with bridge method [inline-methods] */
            public com.kwad.components.core.liveEnd.a createRequest() {
                return new com.kwad.components.core.liveEnd.a(q.this.jk);
            }
        };
        this.et = new AdLivePlayStateListenerAdapter() { // from class: com.kwad.components.ad.feed.widget.q.17
            @Override // com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListenerAdapter, com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListener
            public final void onLivePrepared() {
                super.onLivePrepared();
                q.this.ig.setAudioEnabled(false, false);
            }

            @Override // com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListenerAdapter, com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListener
            public final void onLivePlayProgress(long j) {
                super.onLivePlayProgress(j);
                q.this.c(j);
            }

            @Override // com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListenerAdapter, com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListener
            public final void onLivePlayEnd() {
                super.onLivePlayEnd();
                String strBn = com.kwad.sdk.core.response.helper.a.bn(q.this.mAdInfo);
                if (TextUtils.isEmpty(strBn)) {
                    return;
                }
                com.kwad.components.core.offline.a.c.a aVar = (com.kwad.components.core.offline.a.c.a) com.kwad.sdk.components.d.f(com.kwad.components.core.offline.a.c.a.class);
                if (aVar != null) {
                    q.this.jk = aVar.getAdLiveEndRequest(strBn);
                }
                q.this.mNetworking.request(new com.kwad.sdk.core.network.o<com.kwad.components.core.liveEnd.a, AdLiveEndCommonResultData>() { // from class: com.kwad.components.ad.feed.widget.q.17.1
                    /* JADX INFO: Access modifiers changed from: private */
                    @Override // com.kwad.sdk.core.network.o, com.kwad.sdk.core.network.g
                    /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
                    public void onStartRequest(com.kwad.components.core.liveEnd.a aVar2) {
                        super.onStartRequest(aVar2);
                    }

                    /* JADX INFO: Access modifiers changed from: private */
                    @Override // com.kwad.sdk.core.network.o, com.kwad.sdk.core.network.g
                    /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
                    public void onSuccess(com.kwad.components.core.liveEnd.a aVar2, AdLiveEndCommonResultData adLiveEndCommonResultData) {
                        super.onSuccess(aVar2, adLiveEndCommonResultData);
                        ba.a aVar3 = new ba.a();
                        aVar3.status = 9;
                        aVar3.totalWatchingDuration = adLiveEndCommonResultData.totalWatchingDuration;
                        aVar3.watchingUserCount = adLiveEndCommonResultData.watchingUserCount;
                        aVar3.displayWatchingUserCount = adLiveEndCommonResultData.displayWatchingUserCount;
                        aVar3.likeUserCount = adLiveEndCommonResultData.likeUserCount;
                        aVar3.displayLikeUserCount = adLiveEndCommonResultData.displayLikeUserCount;
                        aVar3.liveDuration = adLiveEndCommonResultData.liveDuration;
                        if (q.this.iW != null) {
                            q.this.iW.a(aVar3);
                        } else {
                            q.this.iX = aVar3;
                        }
                    }

                    /* JADX INFO: Access modifiers changed from: private */
                    @Override // com.kwad.sdk.core.network.o, com.kwad.sdk.core.network.g
                    /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
                    public void onError(com.kwad.components.core.liveEnd.a aVar2, int i, String str) {
                        super.onError(aVar2, i, str);
                    }
                });
            }

            @Override // com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListenerAdapter, com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListener
            public final void onLivePlayStart() {
                com.kwad.components.core.l.a.ty().a(q.this.getCurrentVoiceItem());
                super.onLivePlayStart();
                IAdLivePlayModule iAdLivePlayModule = q.this.ig;
                q qVar = q.this;
                iAdLivePlayModule.setAudioEnabled(qVar.h(qVar.mIsAudioEnable), false);
            }

            @Override // com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListenerAdapter, com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListener
            public final void onLivePlayResume() {
                com.kwad.components.core.l.a.ty().a(q.this.getCurrentVoiceItem());
                super.onLivePlayResume();
                IAdLivePlayModule iAdLivePlayModule = q.this.ig;
                q qVar = q.this;
                iAdLivePlayModule.setAudioEnabled(qVar.h(qVar.mIsAudioEnable), false);
            }
        };
        this.f6if = new com.kwad.components.core.video.a.InterfaceC0460a() { // from class: com.kwad.components.ad.feed.widget.q.11
            @Override // com.kwad.components.core.video.a.InterfaceC0460a
            public final void a(int i, al.a aVar) {
                int i2;
                int i3 = 2;
                boolean z = false;
                if (i == 1) {
                    i2 = 13;
                } else if (i == 2) {
                    i2 = 82;
                } else if (i != 3) {
                    i2 = 108;
                } else {
                    i2 = 83;
                    i3 = 1;
                    z = true;
                }
                q.this.cI();
                com.kwad.components.core.e.d.a.a(new com.kwad.components.core.e.d.a.C0428a(q.this.getContext()).aF(q.this.mAdTemplate).b(q.this.mApkDownloadHelper).aD(i3).as(z).au(true).aC(i2).d(aVar).aw(true).a(new com.kwad.components.core.e.d.a.b() { // from class: com.kwad.components.ad.feed.widget.q.11.1
                    @Override // com.kwad.components.core.e.d.a.b
                    public final void onAdClicked() {
                        q.this.zZ();
                    }
                }));
            }
        };
    }

    public final void setWidth(int i) {
        if (i <= 0) {
            i = getContext().getResources().getDisplayMetrics().widthPixels;
        }
        this.mWidth = i;
    }

    public final void setVideoPlayConfig(KsAdVideoPlayConfig ksAdVideoPlayConfig) {
        com.kwad.components.core.video.e eVar;
        IAdLivePlayModule iAdLivePlayModule;
        this.ce = ksAdVideoPlayConfig;
        if (ksAdVideoPlayConfig instanceof KSAdVideoPlayConfigImpl) {
            KSAdVideoPlayConfigImpl kSAdVideoPlayConfigImpl = (KSAdVideoPlayConfigImpl) ksAdVideoPlayConfig;
            if (kSAdVideoPlayConfigImpl.getVideoSoundValue() != 0) {
                this.mIsAudioEnable = kSAdVideoPlayConfigImpl.isVideoSoundEnable();
                if (this.mAdTemplate != 0) {
                    this.mAdTemplate.mIsAudioEnable = this.mIsAudioEnable;
                }
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
            }
            if (kSAdVideoPlayConfigImpl.getDataFlowAutoStartValue() == 0 || (eVar = this.ib) == null) {
                return;
            }
            eVar.setDataAutoStart(kSAdVideoPlayConfigImpl.isDataFlowAutoStart());
        }
    }

    @Override // android.view.ViewGroup
    public final boolean onInterceptTouchEvent(MotionEvent motionEvent) {
        int action = motionEvent.getAction() & 255;
        if (!com.kwad.sdk.core.config.e.Kt() || !com.kwad.sdk.core.response.helper.d.eB(this.mAdTemplate)) {
            return super.onInterceptTouchEvent(motionEvent);
        }
        FeedSlideConf feedSlideConfCM = com.kwad.sdk.core.response.helper.b.cM(this.mAdTemplate);
        if (feedSlideConfCM == null) {
            return super.onInterceptTouchEvent(motionEvent);
        }
        b(motionEvent);
        if ((action == 2 || action == 3) && this.mAdWebView != null && !this.isNative && Math.abs(motionEvent.getX() - this.hI) > 0.0f) {
            this.mAdWebView.requestDisallowInterceptTouchEvent(true);
            double dAbs = Math.abs(motionEvent.getX() - this.hI);
            double dAbs2 = Math.abs(motionEvent.getY() - this.hJ);
            if (Math.tan(feedSlideConfCM.maxRange) * dAbs < dAbs2 || Math.tan(feedSlideConfCM.minRange) * dAbs < dAbs2) {
                this.mAdWebView.requestDisallowInterceptTouchEvent(false);
            }
        }
        return super.onInterceptTouchEvent(motionEvent);
    }

    private void b(MotionEvent motionEvent) {
        if (motionEvent.getActionMasked() != 0) {
            return;
        }
        this.hI = motionEvent.getX();
        this.hJ = motionEvent.getY();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public boolean h(boolean z) {
        if (!z) {
            return false;
        }
        if (this.fP != null) {
            com.kwad.components.core.l.a.ty();
            if (!com.kwad.components.core.l.a.b(this.fP)) {
                return false;
            }
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

    @Override // com.kwad.components.core.widget.b
    public final int getLayoutId() {
        return R.layout.ksad_feed_webview;
    }

    @Override // com.kwad.components.core.widget.b
    public final void by() {
        com.kwad.components.ad.feed.monitor.b.ck();
        this.iL = (RatioFrameLayout) findViewById(R.id.ksad_container);
        this.hZ = (KSRelativeLayout) findViewById(R.id.ksad_feed_ad_video_container);
        this.iN = (LinearLayout) findViewById(R.id.ksad_video_immerse_text_container);
        this.iO = (TextView) findViewById(R.id.ksad_video_immerse_text);
        this.ia = (ImageView) findViewById(R.id.ksad_video_first_frame_container);
        this.fR = findViewById(R.id.ksad_live_end_bg_mantle);
    }

    private void p(AdTemplate adTemplate) {
        if (this.jg) {
            return;
        }
        if (com.kwad.sdk.core.response.helper.a.cY(com.kwad.sdk.core.response.helper.e.eM(adTemplate))) {
            this.mAdWebView = (KsAdWebView) findViewById(R.id.ksad_web_bottom_card_webView);
        } else {
            this.mAdWebView = (KsAdWebView) findViewById(R.id.ksad_web_default_bottom_card_webView);
        }
        this.jg = true;
    }

    @Override // com.kwad.components.core.widget.b
    public final void d(AdResultData adResultData) {
        AdTemplate adTemplateR = com.kwad.sdk.core.response.helper.c.r(adResultData);
        p(adTemplateR);
        adTemplateR.realShowType = 2;
        super.d(adResultData);
        if (this.iU) {
            com.kwad.components.core.widget.b bVar = this.iY;
            if (bVar != null) {
                bVar.d(adResultData);
                com.kwad.components.core.widget.b bVar2 = this.iY;
                if (bVar2 instanceof c) {
                    ((c) bVar2).b(this.ce);
                    return;
                }
                return;
            }
            return;
        }
        if (!com.kwad.sdk.core.response.helper.b.dx(this.mAdTemplate)) {
            a("0", 0, 1);
            return;
        }
        if (!cJ()) {
            r(this.mAdTemplate);
        }
        try {
            String str = this.iV;
            if (str == null || !str.equals(adTemplateR.mOriginJString)) {
                if (cJ()) {
                    this.mAdWebView.reload();
                } else {
                    this.fe = -2;
                    bf();
                }
            }
        } catch (Throwable unused) {
            a("0", 0, 2);
        }
        this.iV = adTemplateR.mOriginJString;
    }

    @Override // com.kwad.components.core.widget.b
    public final void cs() {
        super.cs();
        if (this.fe == 1 || this.iU) {
            return;
        }
        this.mAdWebView.stopLoading();
        this.mAdWebView.setVisibility(8);
        a("0", 1, 3);
    }

    public final void setPreloadListener(a aVar) {
        a aVar2 = this.ja;
        if (aVar2 != null) {
            aVar2.d(this.fe == 1 ? 2 : 1, "");
        }
        this.ja = aVar;
    }

    private static float q(AdTemplate adTemplate) {
        int i = adTemplate.type;
        if (i == 1) {
            return 0.6013f;
        }
        return (i == 2 || i == 3) ? 0.283f : 0.968f;
    }

    /* JADX WARN: Multi-variable type inference failed */
    private void r(AdTemplate adTemplate) {
        com.kwad.components.core.e.d.d dVar = new com.kwad.components.core.e.d.d(this.mAdTemplate);
        this.mApkDownloadHelper = dVar;
        dVar.setOnShowListener(this);
        this.mApkDownloadHelper.setOnDismissListener(this);
        this.mAdTemplate = adTemplate;
        this.mAdInfo = com.kwad.sdk.core.response.helper.e.eM(this.mAdTemplate);
        Double d = iT.get(Long.valueOf(this.mAdTemplate.posId));
        if (d != null) {
            this.iL.setRatio(d.floatValue());
        } else if (com.kwad.sdk.core.response.helper.b.dw(this.mAdTemplate) > 0.0d) {
            this.iL.setRatio(com.kwad.sdk.core.response.helper.b.dw(this.mAdTemplate));
        } else if (this.iL.getRatio() == 0.0d) {
            this.iL.setRatio(q(this.mAdTemplate));
        }
        com.kwad.components.core.offline.a.c.a aVar = (com.kwad.components.core.offline.a.c.a) com.kwad.sdk.components.d.f(com.kwad.components.core.offline.a.c.a.class);
        this.fD = aVar;
        if (aVar != null && aVar.tG() && com.kwad.sdk.core.response.helper.a.cY(this.mAdInfo)) {
            this.ih = true;
        }
    }

    private void bf() {
        com.kwad.components.core.webview.b bVar = this.jh;
        if (bVar != null) {
            bVar.kT();
        }
        this.mAdWebView.setVisibility(4);
        this.mAdWebView.setBackgroundColor(0);
        this.jh = new com.kwad.components.core.webview.b();
        this.jh.a(new com.kwad.components.core.webview.b.a().be(this.mAdTemplate).bs(com.kwad.sdk.core.response.helper.b.dn(this.mAdTemplate)).f(this.mAdWebView).m(this.iL).f(this.mApkDownloadHelper).a(this.ji));
        this.mAdWebView.loadUrl(com.kwad.sdk.core.response.helper.b.dn(this.mAdTemplate));
        com.kwad.components.ad.feed.monitor.b.a(this.mAdTemplate, com.kwad.sdk.core.response.helper.b.dn(this.mAdTemplate));
        cG();
    }

    /* JADX INFO: renamed from: com.kwad.components.ad.feed.widget.q$12, reason: invalid class name */
    final class AnonymousClass12 extends com.kwad.components.core.webview.c {
        AnonymousClass12() {
        }

        @Override // com.kwad.components.core.webview.c
        public final void a(com.kwad.components.core.webview.a aVar, com.kwad.sdk.core.webview.b bVar) {
            bVar.bbX = false;
            aVar.a(new com.kwad.components.core.webview.jshandler.h(q.this.mAdTemplate.loadType));
            q.this.iP = new be();
            aVar.a(q.this.iP);
            aVar.a(new aq(q.this.getOpenNewPageListener()));
            aVar.a(new WebCardVideoPositionHandler(new WebCardVideoPositionHandler.a() { // from class: com.kwad.components.ad.feed.widget.q.12.1
                @Override // com.kwad.components.core.webview.jshandler.WebCardVideoPositionHandler.a
                public final void a(WebCardVideoPositionHandler.VideoPosition videoPosition) {
                    if (q.this.mAdInfo != null) {
                        if (com.kwad.sdk.core.response.helper.a.bi(q.this.mAdInfo) || q.this.ih) {
                            q.this.jb = (ViewGroup.MarginLayoutParams) q.this.hZ.getLayoutParams();
                            int iCeil = (int) Math.ceil(q.this.iM);
                            int i = q.this.mWidth;
                            if (videoPosition.widthRation == 0.0d) {
                                videoPosition.widthRation = 0.9200000166893005d;
                                videoPosition.leftMarginRation = 0.03999999910593033d;
                            }
                            q.this.jb.topMargin = (int) (videoPosition.topMarginRation * ((double) iCeil));
                            double d = i;
                            q.this.jb.leftMargin = (int) (videoPosition.leftMarginRation * d);
                            q.this.jb.width = (int) (d * videoPosition.widthRation);
                            q.this.jb.height = (int) (((double) q.this.jb.width) * videoPosition.heightWidthRation);
                            q.this.hZ.setRadius(videoPosition.borderRadius);
                            q.this.hZ.setLayoutParams(q.this.jb);
                            q.this.hZ.setVisibility(0);
                            if ((q.this.ce instanceof KSAdVideoPlayConfigImpl) && ((KSAdVideoPlayConfigImpl) q.this.ce).getVideoSoundValue() != 0) {
                                q.this.mIsAudioEnable = q.this.ce.isVideoSoundEnable();
                            } else {
                                q.this.mIsAudioEnable = com.kwad.sdk.core.response.helper.a.ch(q.this.mAdInfo);
                            }
                            q.this.mAdTemplate.mIsAudioEnable = q.this.mIsAudioEnable;
                            q.this.cv = com.kwad.sdk.core.response.helper.a.bv(q.this.mAdInfo);
                            if (!q.this.ih) {
                                q.this.b(q.this.ce);
                            } else if (q.this.ig != null) {
                                q.this.ig.setAudioEnabled(q.this.h(q.this.mIsAudioEnable), false);
                            }
                        }
                    }
                }
            }));
            aVar.a(new ad(bVar, new ad.a() { // from class: com.kwad.components.ad.feed.widget.q.12.2
                @Override // com.kwad.components.core.webview.jshandler.ad.a
                public final void cM() {
                    q.this.jc.post(new bi() { // from class: com.kwad.components.ad.feed.widget.q.12.2.1
                        @Override // com.kwad.sdk.utils.bi
                        public final void doTask() {
                            q.this.Aa();
                        }
                    });
                }
            }));
            aVar.a(new bb(new bb.a() { // from class: com.kwad.components.ad.feed.widget.q.12.3
                @Override // com.kwad.components.core.webview.jshandler.bb.a
                public final void cN() {
                    q.d(q.this, true);
                    q.this.cH();
                }
            }));
            q.this.je = new at();
            aVar.a(q.this.je);
            if (q.this.ih) {
                aVar.a(new com.kwad.components.core.webview.jshandler.g(1, 1));
                q.this.iS = new WebCardRegisterLiveShopListener();
                q.this.iR = new WebCardRegisterLiveMessageListener();
                aVar.a(q.this.iS);
                aVar.a(q.this.iR);
                aVar.a(new ba(q.this.getRegisterLiveListener()));
            }
        }

        @Override // com.kwad.components.core.webview.c
        public final void a(az azVar) {
            q.this.iQ = azVar;
        }

        @Override // com.kwad.components.core.webview.c
        public final void onAdShow() {
            super.onAdShow();
            by.runOnUiThread(new bi() { // from class: com.kwad.components.ad.feed.widget.q.12.4
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    if (q.this.avu == null || q.this.isNative) {
                        return;
                    }
                    q.this.avu.onAdShow();
                    com.kwad.components.ad.feed.monitor.b.c(q.this.mAdTemplate, 2, 2);
                }
            });
        }

        @Override // com.kwad.components.core.webview.c
        public final void a(com.kwad.components.core.webview.jshandler.al.a aVar) {
            if (q.this.isNative) {
                return;
            }
            q.this.mAdWebView.setVisibility(0);
            if (q.this.iM == 0.0d) {
                q.this.iM = aVar.height;
                double d = aVar.height / q.this.mWidth;
                q.this.iL.setRatio((float) d);
                q.iT.put(Long.valueOf(q.this.mAdTemplate.posId), Double.valueOf(d));
            }
        }

        @Override // com.kwad.components.core.webview.c
        public final void b(ae.a aVar) {
            aVar.height = 0;
            aVar.width = q.this.mWidth;
        }

        @Override // com.kwad.components.core.webview.c
        public final void a(com.kwad.sdk.core.webview.d.b.a aVar) {
            q.this.cI();
            int i = aVar.arc;
            if (aVar.QC) {
                i = aVar.ara ? 1 : 2;
            }
            com.kwad.components.core.e.d.a.a(new com.kwad.components.core.e.d.a.C0428a(q.this.getContext()).aF(q.this.mAdTemplate).b(q.this.mApkDownloadHelper).as(q.a(q.this, aVar)).aD(i).aC(aVar.ne).ao((aVar.ard == null || TextUtils.isEmpty(aVar.ard.QQ)) ? "" : aVar.ard.QQ).aB(5).ay(aVar.QC).aw(com.kwad.sdk.core.response.helper.a.bi(q.this.mAdInfo)).A(q.this.ig == null ? 0L : q.this.ig.getPlayDuration()).au(true).a(new com.kwad.components.core.e.d.a.b() { // from class: com.kwad.components.ad.feed.widget.q.12.5
                @Override // com.kwad.components.core.e.d.a.b
                public final void onAdClicked() {
                    if (q.this.avu != null) {
                        q.this.avu.onAdClicked();
                    }
                }
            }));
        }

        @Override // com.kwad.components.core.webview.c
        public final void a(as.a aVar) {
            if (q.this.iU) {
                return;
            }
            q.this.fe = aVar.status;
            if (q.this.fe != 1) {
                q.this.a("3", 3, 4);
                return;
            }
            q.this.jc.removeCallbacksAndMessages(null);
            if (q.this.iY != null) {
                q.this.iY.setVisibility(8);
            }
            q.this.mAdWebView.setVisibility(0);
            com.kwad.components.core.p.a.vX().aZ(q.this.mAdTemplate);
            if (q.this.ja != null) {
                q.this.ja.d(2, "");
            }
        }

        @Override // com.kwad.components.core.webview.c
        public final void onReceivedHttpError(int i, String str, String str2) {
            q.this.a("1", 2, 5);
        }

        @Override // com.kwad.components.core.webview.c
        public final void onPageFinished() {
            com.kwad.components.ad.feed.monitor.b.a(q.this.mAdTemplate, com.kwad.sdk.core.response.helper.b.dn(q.this.mAdTemplate), System.currentTimeMillis() - q.this.mAdWebView.getLoadTime());
        }
    }

    private void cG() {
        this.jc.postDelayed(new bi() { // from class: com.kwad.components.ad.feed.widget.q.13
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                q.this.mAdWebView.stopLoading();
                q.this.mAdWebView.setVisibility(8);
                q.this.a("0", 1, 6);
            }
        }, 2500L);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(String str, int i, int i2) {
        int i3;
        com.kwad.sdk.core.d.c.d("FeedWebView", "handleWebViewError " + str);
        this.jc.removeCallbacksAndMessages(null);
        if (this.iU) {
            return;
        }
        this.iU = true;
        if (this.mAdWebView != null) {
            com.kwad.components.ad.feed.monitor.b.a(this.mAdTemplate, com.kwad.sdk.core.response.helper.b.dn(this.mAdTemplate), System.currentTimeMillis() - this.mAdWebView.getLoadTime(), i);
        }
        com.kwad.components.core.p.a.vX().b(this.mAdTemplate, com.kwad.sdk.core.response.helper.b.dn(this.mAdTemplate), str);
        try {
            i3 = Integer.parseInt(str);
        } catch (NumberFormatException unused) {
            com.kwad.sdk.core.d.c.d("FeedWebView", "handleWebViewError errorCode exception" + str);
            i3 = 0;
        }
        com.kwad.components.ad.feed.monitor.b.a(i3, com.kwad.sdk.core.response.helper.a.bk(this.mAdInfo), this.mAdTemplate, i2);
        a aVar = this.ja;
        if (aVar != null) {
            aVar.d(1, str);
        }
        this.ja = null;
        if (this.iY == null) {
            this.isNative = true;
            e((ViewGroup) this);
            int iBk = com.kwad.sdk.core.response.helper.a.bk(this.mAdInfo);
            IAdLivePlayModule iAdLivePlayModule = this.ig;
            if (iAdLivePlayModule != null) {
                iAdLivePlayModule.setAudioEnabled(false, false);
                this.ig.onDestroy();
                this.ig = null;
            }
            IAdLiveOfflineView iAdLiveOfflineView = this.fC;
            if (iAdLiveOfflineView != null) {
                iAdLiveOfflineView.onDestroy();
                this.fC = null;
            }
            com.kwad.components.core.widget.b bVarA = com.kwad.components.ad.feed.b.a(this.mContext, FeedType.fromInt(this.mAdTemplate.type, this.mAdTemplate.defaultType), iBk);
            this.iY = bVarA;
            if (bVarA != null) {
                this.iY.setMargin(com.kwad.sdk.c.a.a.a(this.mContext, 16.0f));
                this.iL.removeAllViews();
                this.iL.setRatio(0.0d);
                KsAdWebView ksAdWebView = this.mAdWebView;
                if (ksAdWebView != null) {
                    ksAdWebView.setVisibility(8);
                }
                this.hZ.setVisibility(8);
                this.iY.setInnerAdInteractionListener(this.jj);
                this.iL.addView(this.iY);
                this.iY.d(this.mAdResultData);
                com.kwad.components.core.widget.b bVar = this.iY;
                if (bVar instanceof c) {
                    ((c) bVar).b(this.ce);
                }
            }
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public ba.c getRegisterLiveListener() {
        return new ba.c() { // from class: com.kwad.components.ad.feed.widget.q.15
            @Override // com.kwad.components.core.webview.jshandler.ba.c
            public final void a(ba.b bVar) {
                q.this.iW = bVar;
                if (q.this.iX != null) {
                    q.this.iW.a(q.this.iX);
                    q.this.iX = null;
                }
            }
        };
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void cH() {
        float fDt = com.kwad.sdk.core.response.helper.b.dt(this.mAdTemplate);
        this.hv = new com.kwad.components.ad.feed.d.InterfaceC0364d() { // from class: com.kwad.components.ad.feed.widget.q.18
            @Override // com.kwad.components.ad.feed.d.InterfaceC0364d
            public final boolean b(final double d) {
                if (!cb.r(q.this.iL, (int) (com.kwad.sdk.core.config.e.Ko() * 100.0f)) || !q.this.fv()) {
                    return false;
                }
                com.kwad.components.core.e.d.a.a(new com.kwad.components.core.e.d.a.C0428a(q.this.getContext()).aF(q.this.mAdTemplate).b(q.this.mApkDownloadHelper).aD(2).as(false).au(false).aC(157).aB(5).aw(true).a(new com.kwad.components.core.e.d.a.b() { // from class: com.kwad.components.ad.feed.widget.q.18.1
                    @Override // com.kwad.components.core.e.d.a.b
                    public final void onAdClicked() {
                        com.kwad.sdk.core.d.c.d("FeedWebView", "convertEnable End" + com.kwad.sdk.core.response.helper.e.eW(q.this.mAdTemplate));
                        com.kwad.sdk.core.adlog.c.b bVar = new com.kwad.sdk.core.adlog.c.b();
                        bVar.j(d);
                        bVar.dS(157);
                        q.this.c(bVar);
                    }
                }));
                return true;
            }
        };
        com.kwad.components.ad.feed.d.a(com.kwad.sdk.core.response.helper.b.dI(this.mAdInfo), fDt, this.mContext, this.hv, com.kwad.sdk.core.response.helper.b.dJ(this.mAdInfo));
    }

    /* JADX INFO: Access modifiers changed from: private */
    public aq.a getOpenNewPageListener() {
        return new aq.a() { // from class: com.kwad.components.ad.feed.widget.q.19
            @Override // com.kwad.components.core.webview.jshandler.aq.a
            public final void a(com.kwad.components.core.webview.a.b bVar) {
                AdWebViewActivityProxy.launch(q.this.mContext, new AdWebViewActivityProxy.a.C0449a().aW(bVar.title).aX(bVar.url).aQ(true).aU(q.this.mAdTemplate).um());
            }
        };
    }

    @Override // com.kwad.components.core.widget.b
    public final void aa() {
        az azVar;
        if (!this.mAdTemplate.mPvReported && this.avu != null && this.isNative) {
            this.avu.onAdShow();
            com.kwad.components.ad.feed.monitor.b.c(this.mAdTemplate, 1, 2);
        }
        if (this.isNative || (azVar = this.iQ) == null) {
            return;
        }
        azVar.yK();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void cI() {
        if (this.iZ) {
            return;
        }
        this.iZ = true;
        com.kwad.components.ad.feed.monitor.b.a(this.mAdTemplate, 2, getStayTime());
    }

    private boolean cJ() {
        return this.fe == 1;
    }

    @Override // com.kwad.components.core.widget.b, com.kwad.sdk.core.j.c
    public final void bv() {
        super.bv();
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

    /* JADX INFO: Access modifiers changed from: private */
    public com.kwad.components.core.l.a.b getCurrentVoiceItem() {
        if (this.fP == null) {
            this.fP = new com.kwad.components.core.l.a.b(new com.kwad.components.core.l.a.c() { // from class: com.kwad.components.ad.feed.widget.q.2
                @Override // com.kwad.components.core.l.a.c
                public final void bH() {
                    if (q.this.ih) {
                        if (q.this.ig == null) {
                            q qVar = q.this;
                            qVar.ig = qVar.cw();
                        }
                        IAdLivePlayModule iAdLivePlayModule = q.this.ig;
                        q qVar2 = q.this;
                        iAdLivePlayModule.setAudioEnabled(qVar2.h(qVar2.mIsAudioEnable), false);
                        return;
                    }
                    if (q.this.cB != null) {
                        com.kwad.sdk.core.video.videoview.a aVar = q.this.cB;
                        q qVar3 = q.this;
                        aVar.setVideoSoundEnable(qVar3.h(qVar3.mIsAudioEnable));
                    }
                }
            });
        }
        return this.fP;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public IAdLivePlayModule cw() {
        cx();
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
        by.postOnUiThread(new bi() { // from class: com.kwad.components.ad.feed.widget.q.3
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                q.this.c(view);
            }
        });
        cK();
        if (this.mIsAudioEnable) {
            com.kwad.components.core.t.a.aN(this.mContext).a(this.cM);
        }
        return adLivePlayModule;
    }

    private void cK() {
        this.fC.registerLiveMessageListener(new AdLiveMessageListener() { // from class: com.kwad.components.ad.feed.widget.q.4
            @Override // com.kwad.components.offline.api.core.adlive.listener.AdLiveMessageListener
            public final void handleAdLiveMessage(List<AdLiveMessageInfo> list) {
                if (q.this.iR != null) {
                    q.this.iR.u(list);
                }
            }
        });
        this.fC.registerLiveShopListener(new AdLiveShopListener() { // from class: com.kwad.components.ad.feed.widget.q.5
            @Override // com.kwad.components.offline.api.core.adlive.listener.AdLiveShopListener
            public final void handleAdLiveShop(AdLiveShopInfo adLiveShopInfo) {
                if (q.this.iS != null) {
                    q.this.iS.a(adLiveShopInfo);
                }
            }
        });
    }

    private void cx() {
        String url = com.kwad.sdk.core.response.helper.a.bA(this.mAdInfo).getUrl();
        this.ia.setVisibility(0);
        this.fR.setVisibility(0);
        if (!TextUtils.isEmpty(url)) {
            this.ia.setImageDrawable(null);
            KSImageLoader.loadImage(this.ia, url, this.mAdTemplate, new DisplayImageOptionsCompat.Builder().setBlurRadius(50).build(), new SimpleImageLoadingListener() { // from class: com.kwad.components.ad.feed.widget.q.6
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
    public void c(View view) {
        int width = this.hZ.getWidth();
        int height = this.hZ.getHeight();
        if (width == 0 || height == 0) {
            return;
        }
        RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams((int) (height * 0.5625f), height);
        layoutParams.addRule(13, -1);
        view.setLayoutParams(layoutParams);
    }

    public final void b(KsAdVideoPlayConfig ksAdVideoPlayConfig) {
        String strFv;
        String url = com.kwad.sdk.core.response.helper.a.bA(this.mAdInfo).getUrl();
        if (!TextUtils.isEmpty(url)) {
            this.ia.setImageDrawable(null);
            KSImageLoader.loadImage(this.ia, url, this.mAdTemplate);
            this.ia.setVisibility(0);
        } else {
            this.ia.setVisibility(8);
        }
        com.kwad.sdk.core.video.videoview.a aVar = new com.kwad.sdk.core.video.videoview.a(this.mContext);
        this.cB = aVar;
        aVar.setTag(this.cv);
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
        this.cB.a(new com.kwad.sdk.contentalliance.a.a.b.a(this.mAdTemplate).dO(strM).dP(com.kwad.sdk.core.response.helper.h.b(com.kwad.sdk.core.response.helper.e.eN(this.mAdTemplate))).a(this.mAdTemplate.mVideoPlayerStatus).b(new com.kwad.sdk.contentalliance.a.a.a(this.mAdTemplate, System.currentTimeMillis())).IS(), null);
        com.kwad.sdk.core.video.videoview.a.InterfaceC0519a interfaceC0519a = new com.kwad.sdk.core.video.videoview.a.InterfaceC0519a() { // from class: com.kwad.components.ad.feed.widget.q.7
            @Override // com.kwad.sdk.core.video.videoview.a.InterfaceC0519a
            public final com.kwad.sdk.core.video.a.c a(com.kwad.sdk.contentalliance.a.a.b bVar) {
                if (!((Boolean) com.kwad.sdk.core.config.e.b(com.kwad.sdk.core.config.c.aQq)).booleanValue() || !((Boolean) com.kwad.sdk.core.config.e.b(com.kwad.sdk.core.config.c.aQr)).booleanValue()) {
                    return null;
                }
                com.kwad.components.core.video.g gVar = new com.kwad.components.core.video.g(bVar, q.this.mAdTemplate);
                if (com.kwad.components.core.video.g.isWaynePlayerReady()) {
                    return gVar;
                }
                return null;
            }
        };
        this.cK = interfaceC0519a;
        this.cB.setExternalPlayerListener(interfaceC0519a);
        this.cB.setVideoSoundEnable(h(this.mIsAudioEnable));
        this.ib = new com.kwad.components.core.video.e(this.mContext, this.mAdTemplate, this.cB, ksAdVideoPlayConfig);
        this.hH = SystemClock.elapsedRealtime();
        this.ib.setVideoPlayCallback(getVideoPlayCallback());
        this.ib.setAdClickListener(this.f6if);
        this.cB.setController(this.ib);
        if (this.hZ.getTag() != null) {
            KSRelativeLayout kSRelativeLayout = this.hZ;
            kSRelativeLayout.removeView((View) kSRelativeLayout.getTag());
            this.hZ.setTag(null);
        }
        this.hZ.addView(this.cB, 1);
        this.hZ.setTag(this.cB);
        this.hZ.setClickable(true);
        new com.kwad.sdk.widget.h(this.hZ, this);
        if (this.mIsAudioEnable) {
            com.kwad.components.core.t.a.aN(this.mContext).a(this.cM);
        }
        if (this.mAdTemplate.type == 1 || this.mAdTemplate.type == 19) {
            this.iN.setVisibility(0);
            this.iO.setVisibility(0);
            this.iO.setText(com.kwad.components.ad.feed.f.l(this.mAdTemplate));
            new com.kwad.sdk.widget.h(this.iO, this);
        }
    }

    @Override // com.kwad.sdk.widget.d
    public final void a(View view) {
        if (view == this.hZ) {
            if (this.cB.isIdle()) {
                com.kwad.sdk.utils.o.fo(this.mAdTemplate);
                this.cB.setKsPlayLogParam(com.kwad.sdk.contentalliance.a.a.a.ci(this.mAdTemplate));
                this.cB.start();
                return;
            }
            a(this.cB, 100);
            return;
        }
        if (view == this.iO) {
            a(this.cB, 25);
        }
    }

    @Override // com.kwad.sdk.widget.d
    public final void a(View view, float f, float f2, float f3, float f4) {
        if (com.kwad.sdk.core.response.helper.d.eB(this.mAdTemplate)) {
            if (view == this.hZ || view == this.iO) {
                a(this.cB, MediaPlayer.MEDIA_PLAYER_OPTION_GET_DROP_COUNT);
            }
        }
    }

    private com.kwad.components.core.video.a.b getVideoPlayCallback() {
        return new com.kwad.components.core.video.a.b() { // from class: com.kwad.components.ad.feed.widget.q.8
            private boolean eQ = false;

            @Override // com.kwad.components.core.video.a.c
            public final void d(long j) {
                q.this.c(j);
            }

            @Override // com.kwad.components.core.video.a.c
            public final void onVideoPlayStart() {
                com.kwad.components.core.l.a.ty().a(q.this.getCurrentVoiceItem());
                com.kwad.components.ad.feed.monitor.b.a(q.this.mAdTemplate, 1, 1, com.kwad.sdk.core.response.helper.a.M(q.this.mAdInfo), null, SystemClock.elapsedRealtime() - q.this.hH);
                com.kwad.sdk.core.adlog.c.cp(q.this.mAdTemplate);
                q.this.iP.bV(3);
                if (q.this.ic != null && (q.this.ic.getParent() instanceof ViewGroup)) {
                    ((ViewGroup) q.this.ic.getParent()).removeView(q.this.ic);
                    q.this.ic.cB();
                    q.this.ic = null;
                }
                if (q.this.jd == null && com.kwad.sdk.core.response.helper.b.dr(q.this.mAdTemplate) && q.this.jf) {
                    q.this.jd = new e(q.this.mContext);
                    q.this.hZ.addView(q.this.jd, new FrameLayout.LayoutParams(-1, -1));
                    q.this.jd.setOnViewEventListener(new com.kwad.sdk.widget.d() { // from class: com.kwad.components.ad.feed.widget.q.8.1
                        @Override // com.kwad.sdk.widget.d
                        public final void a(View view) {
                            if (com.kwad.sdk.core.response.helper.b.ds(q.this.mAdTemplate)) {
                                return;
                            }
                            q.this.E(158);
                        }

                        @Override // com.kwad.sdk.widget.d
                        public final void a(View view, float f, float f2, float f3, float f4) {
                            if (com.kwad.sdk.core.response.helper.b.ds(q.this.mAdTemplate) || !com.kwad.sdk.core.response.helper.d.eB(q.this.mAdTemplate)) {
                                return;
                            }
                            q.this.E(MediaPlayer.MEDIA_PLAYER_OPTION_GET_DROP_COUNT);
                        }
                    });
                    q.this.jd.a(new AnimatorListenerAdapter() { // from class: com.kwad.components.ad.feed.widget.q.8.2
                        @Override // android.animation.AnimatorListenerAdapter, android.animation.Animator.AnimatorListener
                        public final void onAnimationEnd(Animator animator) {
                            super.onAnimationEnd(animator);
                            q.this.je.bU(1);
                            q.this.hZ.removeView(q.this.jd);
                        }
                    });
                }
            }

            @Override // com.kwad.components.core.video.a.c
            public final void as() {
                if (!this.eQ) {
                    this.eQ = true;
                    com.kwad.components.core.p.a.vX().a(q.this.mAdTemplate, System.currentTimeMillis(), 1);
                }
                com.kwad.sdk.core.video.videoview.a aVar = q.this.cB;
                q qVar = q.this;
                aVar.setVideoSoundEnable(qVar.h(qVar.mIsAudioEnable));
            }

            @Override // com.kwad.components.core.video.a.c
            public final void at() {
                com.kwad.sdk.core.adlog.c.cq(q.this.mAdTemplate);
                q.this.iP.bV(9);
                q.this.hZ.setVisibility(8);
                if (com.kwad.components.ad.feed.a.b.ch() && q.this.ic == null && !q.this.jf) {
                    q.this.ic = new d(q.this.mContext);
                    FrameLayout.LayoutParams layoutParams = new FrameLayout.LayoutParams(-1, -1);
                    q qVar = q.this;
                    qVar.addView(qVar.ic, layoutParams);
                    q.this.ic.cA();
                }
            }

            @Override // com.kwad.components.core.video.a.b
            public final void onVideoPlayError(int i, int i2) {
                com.kwad.components.ad.feed.monitor.b.a(q.this.mAdTemplate, 2, 1, com.kwad.sdk.core.response.helper.a.M(q.this.mAdInfo), i + " " + i2, SystemClock.elapsedRealtime() - q.this.hH);
            }
        };
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void E(final int i) {
        cI();
        com.kwad.components.core.e.d.a.a(new com.kwad.components.core.e.d.a.C0428a(getContext()).aF(this.mAdTemplate).b(this.mApkDownloadHelper).aD(1).as(true).aC(i).aB(5).au(false).aw(true).a(new com.kwad.components.core.e.d.a.b() { // from class: com.kwad.components.ad.feed.widget.q.9
            @Override // com.kwad.components.core.e.d.a.b
            public final void onAdClicked() {
                q.this.bO(i);
            }
        }));
    }

    private void a(com.kwad.sdk.core.video.videoview.a aVar, final int i) {
        if (aVar != null) {
            String strM = com.kwad.sdk.core.response.helper.a.M(this.mAdInfo);
            this.ib.setAutoRelease(false);
            AdVideoPlayerViewCache.getInstance().a(strM, this.cB);
            FeedType.fromInt(this.mAdTemplate.type, this.mAdTemplate.defaultType);
            cI();
            com.kwad.components.core.e.d.a.a(new com.kwad.components.core.e.d.a.C0428a(getContext()).aF(this.mAdTemplate).b(this.mApkDownloadHelper).aD(2).aw(com.kwad.sdk.core.response.helper.a.bi(this.mAdInfo)).a(new com.kwad.components.core.e.d.a.b() { // from class: com.kwad.components.ad.feed.widget.q.10
                @Override // com.kwad.components.core.e.d.a.b
                public final void onAdClicked() {
                    q.this.bO(i);
                }
            }));
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

    @Override // com.kwad.sdk.widget.KSFrameLayout, android.view.View
    public final void onWindowFocusChanged(boolean z) {
        IAdLivePlayModule iAdLivePlayModule;
        ViewGroup viewGroup;
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
                if (aVar != null && (viewGroup = (ViewGroup) aVar.getParent()) != this.hZ) {
                    viewGroup.removeView(this.cB);
                    if (this.hZ.getTag() != null) {
                        KSRelativeLayout kSRelativeLayout = this.hZ;
                        kSRelativeLayout.removeView((View) kSRelativeLayout.getTag());
                        this.hZ.setTag(null);
                    }
                    this.hZ.addView(this.cB);
                    this.hZ.setTag(this.cB);
                    this.cB.setVideoSoundEnable(this.mIsAudioEnable);
                    this.ib.setVideoPlayCallback(getVideoPlayCallback());
                    this.ib.setAdClickListener(this.f6if);
                    this.ib.getAdTemplate().mAdWebVideoPageShowing = false;
                    this.ib.xT();
                    this.ib.setAutoRelease(true);
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

    private boolean cv() {
        IAdLiveOfflineView iAdLiveOfflineView = this.fC;
        if (iAdLiveOfflineView == null || iAdLiveOfflineView.getView() == null || this.ig == null) {
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
            this.ig.setAudioEnabled(h(this.mIsAudioEnable), false);
            IAdLivePlayModule adLivePlayModule = this.fD.getAdLivePlayModule(this.fC, ServiceProvider.getAppId(), String.valueOf(com.kwad.sdk.core.response.helper.a.cw(this.mAdInfo)), com.kwad.sdk.core.response.helper.a.cx(this.mAdInfo), com.kwad.sdk.core.response.helper.a.cy(this.mAdInfo), com.kwad.sdk.core.response.helper.e.eG(this.mAdTemplate));
            this.ig = adLivePlayModule;
            adLivePlayModule.registerAdLivePlayStateListener(this.et);
        }
        this.ig.onResume();
        return true;
    }

    private static boolean b(com.kwad.sdk.core.webview.d.b.a aVar) {
        if (aVar.QC) {
            return aVar.ara;
        }
        return aVar.arc == 1;
    }

    @Override // com.kwad.components.core.widget.b, com.kwad.sdk.widget.KSFrameLayout
    public final void ae() {
        super.ae();
        if (this.hv != null) {
            com.kwad.components.ad.feed.d.a(com.kwad.sdk.core.response.helper.b.dI(this.mAdInfo), com.kwad.sdk.core.response.helper.b.dt(this.mAdTemplate), this.mContext, this.hv, com.kwad.sdk.core.response.helper.b.dJ(this.mAdInfo));
        }
    }

    @Override // com.kwad.components.core.widget.b, com.kwad.sdk.widget.KSFrameLayout
    public final void af() {
        super.af();
        this.jc.removeCallbacksAndMessages(null);
        com.kwad.sdk.utils.o.fn(this.mAdTemplate);
        com.kwad.components.ad.feed.d.InterfaceC0364d interfaceC0364d = this.hv;
        if (interfaceC0364d != null) {
            com.kwad.components.ad.feed.d.a(interfaceC0364d);
        }
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
        this.iW = null;
        this.iX = null;
    }
}
