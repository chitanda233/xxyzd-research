package com.kwad.components.ad.nativead;

import android.content.Context;
import android.graphics.BitmapFactory;
import android.text.TextUtils;
import android.view.View;
import android.widget.ImageView;
import android.widget.RelativeLayout;
import com.kwad.components.core.internal.api.KSAdVideoPlayConfigImpl;
import com.kwad.components.core.liveEnd.AdLiveEndCommonResultData;
import com.kwad.components.core.page.AdWebViewActivityProxy;
import com.kwad.components.core.webview.jshandler.WebCardRegisterLiveMessageListener;
import com.kwad.components.core.webview.jshandler.WebCardRegisterLiveShopListener;
import com.kwad.components.core.webview.jshandler.ac;
import com.kwad.components.core.webview.jshandler.ae;
import com.kwad.components.core.webview.jshandler.af;
import com.kwad.components.core.webview.jshandler.ai;
import com.kwad.components.core.webview.jshandler.am;
import com.kwad.components.core.webview.jshandler.aq;
import com.kwad.components.core.webview.jshandler.as;
import com.kwad.components.core.webview.jshandler.az;
import com.kwad.components.core.webview.jshandler.ba;
import com.kwad.components.core.webview.jshandler.bc;
import com.kwad.components.core.webview.jshandler.be;
import com.kwad.components.core.webview.jshandler.n;
import com.kwad.components.core.webview.jshandler.z;
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
import com.kwad.sdk.api.KsNativeAd;
import com.kwad.sdk.core.imageloader.KSImageLoader;
import com.kwad.sdk.core.imageloader.core.DisplayImageOptionsCompat;
import com.kwad.sdk.core.imageloader.core.decode.DecodedResult;
import com.kwad.sdk.core.imageloader.core.listener.SimpleImageLoadingListener;
import com.kwad.sdk.core.imageloader.utils.BlurUtils;
import com.kwad.sdk.core.network.l;
import com.kwad.sdk.core.network.o;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.response.model.BaseResultData;
import com.kwad.sdk.core.view.AdBasePvFrameLayout;
import com.kwad.sdk.core.webview.KsAdWebView;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;
import com.kwad.sdk.widget.KSRelativeLayout;
import com.kwad.sdk.wrapper.m;
import java.io.InputStream;
import java.util.Iterator;
import java.util.List;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class e extends KSRelativeLayout implements com.kwad.sdk.core.j.c {
    private boolean cA;
    private OfflineOnAudioConflictListener cM;
    private List<Integer> cv;
    private final AdLivePlayStateListener et;
    private IAdLiveOfflineView fC;
    private com.kwad.components.core.offline.a.c.a fD;
    private com.kwad.components.core.l.a.b fP;
    private com.kwad.components.core.webview.a fb;
    private com.kwad.sdk.core.webview.b fc;
    private int fe;
    private as.b fj;
    private com.kwad.components.core.widget.a.c fs;
    private KSRelativeLayout hZ;
    private be iP;
    private az iQ;
    private WebCardRegisterLiveMessageListener iR;
    private WebCardRegisterLiveShopListener iS;
    private ba.b iW;
    private ba.a iX;
    public IAdLivePlayModule ig;
    private IAdLiveEndRequest jk;
    private AdInfo mAdInfo;
    private AdTemplate mAdTemplate;
    private KsAdWebView mAdWebView;
    private com.kwad.components.core.e.d.d mApkDownloadHelper;
    private Context mContext;
    private boolean mIsAudioEnable;
    private final l<com.kwad.components.core.liveEnd.a, AdLiveEndCommonResultData> mNetworking;
    private ImageView pH;
    private RelativeLayout pI;
    private AdBasePvFrameLayout pJ;
    private KSAdVideoPlayConfigImpl pK;
    private KsNativeAd.VideoPlayListener pn;
    private int pp;
    private int pq;
    private d.a pv;

    public e(Context context) {
        super(context);
        this.pp = 0;
        this.pq = 0;
        this.fj = new as.b() { // from class: com.kwad.components.ad.nativead.e.10
            @Override // com.kwad.components.core.webview.jshandler.as.b
            public final void a(as.a aVar) {
                e.this.fe = aVar.status;
                if (e.this.fe != 1) {
                    e.this.mAdWebView.setVisibility(8);
                } else {
                    e.this.mAdWebView.setVisibility(0);
                }
            }
        };
        this.mNetworking = new l<com.kwad.components.core.liveEnd.a, AdLiveEndCommonResultData>() { // from class: com.kwad.components.ad.nativead.e.12
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
                return new com.kwad.components.core.liveEnd.a(e.this.jk);
            }
        };
        this.et = new AdLivePlayStateListenerAdapter() { // from class: com.kwad.components.ad.nativead.e.2
            @Override // com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListenerAdapter, com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListener
            public final void onLivePlayProgress(long j) {
                super.onLivePlayProgress(j);
                e.this.c(j);
            }

            @Override // com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListenerAdapter, com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListener
            public final void onLivePlayEnd() {
                super.onLivePlayEnd();
                if (e.this.pn != null) {
                    e.this.pn.onVideoPlayComplete();
                }
                String strBn = com.kwad.sdk.core.response.helper.a.bn(e.this.mAdInfo);
                if (TextUtils.isEmpty(strBn)) {
                    return;
                }
                com.kwad.components.core.offline.a.c.a aVar = (com.kwad.components.core.offline.a.c.a) com.kwad.sdk.components.d.f(com.kwad.components.core.offline.a.c.a.class);
                if (aVar != null) {
                    e.this.jk = aVar.getAdLiveEndRequest(strBn);
                }
                e.this.mNetworking.request(new o<com.kwad.components.core.liveEnd.a, AdLiveEndCommonResultData>() { // from class: com.kwad.components.ad.nativead.e.2.1
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
                        if (e.this.iW != null) {
                            e.this.iW.a(aVar3);
                        } else {
                            e.this.iX = aVar3;
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
                super.onLivePlayStart();
                com.kwad.components.core.l.a.ty().a(e.this.getCurrentVoiceItem());
                IAdLivePlayModule iAdLivePlayModule = e.this.ig;
                e eVar = e.this;
                iAdLivePlayModule.setAudioEnabled(eVar.h(eVar.mIsAudioEnable), false);
                if (e.this.pn != null) {
                    e.this.pn.onVideoPlayStart();
                }
            }

            @Override // com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListenerAdapter, com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListener
            public final void onLivePlayResume() {
                super.onLivePlayResume();
                com.kwad.components.core.l.a.ty().a(e.this.getCurrentVoiceItem());
                IAdLivePlayModule iAdLivePlayModule = e.this.ig;
                e eVar = e.this;
                iAdLivePlayModule.setAudioEnabled(eVar.h(eVar.mIsAudioEnable), false);
                try {
                    e.this.pn.onVideoPlayResume();
                } catch (Throwable th) {
                    com.kwad.sdk.core.d.c.printStackTraceOnly(th);
                }
            }

            @Override // com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListenerAdapter, com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListener
            public final void onLivePlayPause() {
                super.onLivePlayPause();
                try {
                    e.this.pn.onVideoPlayPause();
                } catch (Throwable th) {
                    com.kwad.sdk.core.d.c.printStackTraceOnly(th);
                }
            }

            @Override // com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListenerAdapter, com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListener
            public final void onLivePrepared() {
                super.onLivePrepared();
                com.kwad.components.core.l.a.ty().a(e.this.getCurrentVoiceItem());
                try {
                    e.this.pn.onVideoPlayReady();
                } catch (Throwable th) {
                    com.kwad.sdk.core.d.c.printStackTraceOnly(th);
                }
                if (e.this.ig != null) {
                    e.this.ig.setAudioEnabled(false, false);
                }
            }

            @Override // com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListenerAdapter, com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListener
            public final void onLivePlayCompleted() {
                super.onLivePlayCompleted();
                if (e.this.pn != null) {
                    e.this.pn.onVideoPlayComplete();
                }
            }
        };
        this.cM = new OfflineOnAudioConflictListener() { // from class: com.kwad.components.ad.nativead.e.3
            @Override // com.kwad.components.offline.api.core.api.OfflineOnAudioConflictListener
            public final void onAudioBeReleased() {
            }

            @Override // com.kwad.components.offline.api.core.api.OfflineOnAudioConflictListener
            public final void onAudioBeOccupied() {
                if (e.this.ig != null) {
                    e.this.ig.setAudioEnabled(false, false);
                }
            }
        };
        initView();
    }

    private void initView() {
        m.inflate(getContext(), R.layout.ksad_native_live_layout, this);
        AdBasePvFrameLayout adBasePvFrameLayout = (AdBasePvFrameLayout) findViewById(R.id.ksad_root_container);
        this.pJ = adBasePvFrameLayout;
        this.pH = (ImageView) adBasePvFrameLayout.findViewById(R.id.ksad_live_bg_img);
        this.hZ = (KSRelativeLayout) this.pJ.findViewById(R.id.ksad_live_container);
        this.pI = (RelativeLayout) this.pJ.findViewById(R.id.ksad_live_video_container);
        KsAdWebView ksAdWebView = (KsAdWebView) this.pJ.findViewById(R.id.ksad_web_card_webView);
        this.mAdWebView = ksAdWebView;
        ksAdWebView.setBackgroundColor(0);
        this.fD = (com.kwad.components.core.offline.a.c.a) com.kwad.sdk.components.d.f(com.kwad.components.core.offline.a.c.a.class);
    }

    public final void setInnerAdInteractionListener(d.a aVar) {
        this.pv = aVar;
    }

    public final void setVideoPlayListener(KsNativeAd.VideoPlayListener videoPlayListener) {
        this.pn = videoPlayListener;
    }

    public final void a(Context context, AdTemplate adTemplate, com.kwad.components.core.e.d.d dVar, KSAdVideoPlayConfigImpl kSAdVideoPlayConfigImpl) {
        this.mAdTemplate = adTemplate;
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
        this.mAdInfo = adInfoEM;
        this.mContext = context;
        this.pK = kSAdVideoPlayConfigImpl;
        this.mApkDownloadHelper = dVar;
        this.cv = com.kwad.sdk.core.response.helper.a.bv(adInfoEM);
        this.fs = new g(getParent() == null ? this : (View) getParent());
        if (this.pK.getVideoSoundValue() != 0) {
            this.mIsAudioEnable = this.pK.isVideoSoundEnable();
        } else {
            this.mIsAudioEnable = com.kwad.sdk.core.response.helper.a.ch(this.mAdInfo);
        }
        fu();
        fy();
    }

    private void fu() {
        try {
            this.pp = this.mAdTemplate.mAdScene.nativeAdExtraData.showLiveStatus;
            this.pq = this.mAdTemplate.mAdScene.nativeAdExtraData.showLiveStyle;
        } catch (Throwable unused) {
        }
    }

    private void fy() {
        this.mAdWebView.setVisibility(8);
        be();
        if (cJ()) {
            this.mAdWebView.reload();
        } else {
            bf();
        }
    }

    private void bf() {
        if (com.kwad.sdk.core.response.helper.b.dC(this.mAdTemplate)) {
            fz();
        }
    }

    private void fz() {
        bh();
        this.mAdWebView.setClientConfig(this.mAdWebView.getClientConfig().fm(this.mAdTemplate));
        com.kwad.components.core.webview.a aVar = new com.kwad.components.core.webview.a(this.mAdWebView);
        this.fb = aVar;
        a(aVar);
        this.mAdWebView.addJavascriptInterface(this.fb, "KwaiAd");
        this.mAdWebView.loadUrl(com.kwad.sdk.core.response.helper.b.dq(this.mAdTemplate));
    }

    private void be() {
        com.kwad.sdk.core.webview.b bVar = new com.kwad.sdk.core.webview.b();
        this.fc = bVar;
        bVar.setAdTemplate(this.mAdTemplate);
        this.fc.mScreenOrientation = 0;
        this.fc.bbV = null;
        this.fc.adZ = this.pJ;
        this.fc.adg = this.mAdWebView;
        this.fc.mReportExtData = null;
        this.fc.bbX = false;
    }

    private void bh() {
        com.kwad.components.core.webview.a aVar = this.fb;
        if (aVar != null) {
            aVar.destroy();
            this.fb = null;
        }
    }

    private boolean cJ() {
        return this.fe == 1;
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
        this.pI.removeAllViews();
        this.pI.addView(view);
        by.postOnUiThread(new bi() { // from class: com.kwad.components.ad.nativead.e.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                e.this.c(view);
            }
        });
        cK();
        if (this.mIsAudioEnable) {
            com.kwad.components.core.t.a.aN(this.mContext).a(this.cM);
        }
        return adLivePlayModule;
    }

    private void cx() {
        String url = com.kwad.sdk.core.response.helper.a.bA(this.mAdInfo).getUrl();
        if (!TextUtils.isEmpty(url)) {
            this.pH.setImageDrawable(null);
            KSImageLoader.loadImage(this.pH, url, this.mAdTemplate, new DisplayImageOptionsCompat.Builder().setBlurRadius(50).build(), new SimpleImageLoadingListener() { // from class: com.kwad.components.ad.nativead.e.5
                @Override // com.kwad.sdk.core.imageloader.core.listener.SimpleImageLoadingListener, com.kwad.sdk.core.imageloader.core.listener.ImageLoadingListener
                public final boolean onDecode(String str, InputStream inputStream, DecodedResult decodedResult) {
                    decodedResult.mBitmap = BlurUtils.stackBlur(BitmapFactory.decodeStream(inputStream), 50, false);
                    return true;
                }
            });
            this.pH.setVisibility(0);
            return;
        }
        this.pH.setVisibility(8);
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

    private void cK() {
        this.fC.registerLiveMessageListener(new AdLiveMessageListener() { // from class: com.kwad.components.ad.nativead.e.6
            @Override // com.kwad.components.offline.api.core.adlive.listener.AdLiveMessageListener
            public final void handleAdLiveMessage(List<AdLiveMessageInfo> list) {
                if (e.this.iR != null) {
                    e.this.iR.u(list);
                }
            }
        });
        this.fC.registerLiveShopListener(new AdLiveShopListener() { // from class: com.kwad.components.ad.nativead.e.7
            @Override // com.kwad.components.offline.api.core.adlive.listener.AdLiveShopListener
            public final void handleAdLiveShop(AdLiveShopInfo adLiveShopInfo) {
                if (e.this.iS != null) {
                    e.this.iS.a(adLiveShopInfo);
                }
            }
        });
    }

    private void a(com.kwad.components.core.webview.a aVar) {
        this.iP = new be();
        az azVar = new az();
        this.iQ = azVar;
        aVar.a(azVar);
        aVar.a(new ac(this.fc, this.mApkDownloadHelper, getClickListener(), (byte) 0));
        aVar.a(new z(this.fc, this.mApkDownloadHelper, getClickListener()));
        aVar.a(new com.kwad.components.core.webview.tachikoma.b.f());
        aVar.a(new af(this.fc));
        aVar.a(new ai(this.fc));
        aVar.a(new ae(this.fc));
        aVar.a(new as(this.fj, com.kwad.sdk.core.response.helper.b.dn(this.mAdTemplate)));
        aVar.a(new bc(this.fc, this.mApkDownloadHelper));
        aVar.a(new am(this.fc));
        aVar.b(new com.kwad.components.core.webview.jshandler.o(this.fc));
        aVar.b(new n(this.fc));
        aVar.a(this.iP);
        aVar.a(new aq(getOpenNewPageListener()));
        aVar.a(new com.kwad.components.core.webview.jshandler.g(this.pp, this.pq));
        this.iS = new WebCardRegisterLiveShopListener();
        this.iR = new WebCardRegisterLiveMessageListener();
        aVar.a(this.iS);
        aVar.a(this.iR);
        aVar.a(new ba(getRegisterLiveListener()));
    }

    private ba.c getRegisterLiveListener() {
        return new ba.c() { // from class: com.kwad.components.ad.nativead.e.8
            @Override // com.kwad.components.core.webview.jshandler.ba.c
            public final void a(ba.b bVar) {
                e.this.iW = bVar;
                if (e.this.iX != null) {
                    e.this.iW.a(e.this.iX);
                    e.this.iX = null;
                }
            }
        };
    }

    private aq.a getOpenNewPageListener() {
        return new aq.a() { // from class: com.kwad.components.ad.nativead.e.9
            @Override // com.kwad.components.core.webview.jshandler.aq.a
            public final void a(com.kwad.components.core.webview.a.b bVar) {
                AdWebViewActivityProxy.launch(e.this.mContext, new AdWebViewActivityProxy.a.C0449a().aW(bVar.title).aX(bVar.url).aU(e.this.mAdTemplate).um());
            }
        };
    }

    private com.kwad.sdk.core.webview.d.a.a getClickListener() {
        return new com.kwad.sdk.core.webview.d.a.a() { // from class: com.kwad.components.ad.nativead.e.11
            @Override // com.kwad.sdk.core.webview.d.a.a
            public final void a(com.kwad.sdk.core.webview.d.b.a aVar) {
                int i = aVar.arc;
                if (aVar.QC) {
                    i = aVar.ara ? 1 : 2;
                }
                com.kwad.components.core.e.d.a.a(new com.kwad.components.core.e.d.a.C0428a(e.this.getContext()).aF(e.this.mAdTemplate).b(e.this.mApkDownloadHelper).as(false).aD(i).ay(aVar.QC).aw(com.kwad.sdk.core.response.helper.a.bi(e.this.mAdInfo)).A(e.this.ig == null ? 0L : e.this.ig.getPlayDuration()).ao((aVar.ard == null || TextUtils.isEmpty(aVar.ard.QQ)) ? "" : aVar.ard.QQ).au(true).a(new com.kwad.components.core.e.d.a.b() { // from class: com.kwad.components.ad.nativead.e.11.1
                    @Override // com.kwad.components.core.e.d.a.b
                    public final void onAdClicked() {
                        if (e.this.pv != null) {
                            e.this.pv.l(e.this.mAdWebView);
                        }
                    }
                }));
            }
        };
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
                com.kwad.sdk.core.adlog.c.a(this.mAdTemplate, iCeil, (JSONObject) null);
                it.remove();
                return;
            }
        }
    }

    @Override // com.kwad.sdk.widget.KSRelativeLayout
    public final void ae() {
        super.ae();
        this.fs.Am();
        this.fs.a(this);
    }

    @Override // com.kwad.sdk.widget.KSRelativeLayout
    public final void af() {
        super.af();
        this.fs.Am();
        this.fs.b(this);
        IAdLivePlayModule iAdLivePlayModule = this.ig;
        if (iAdLivePlayModule != null) {
            iAdLivePlayModule.onDestroy();
            this.ig = null;
        }
        com.kwad.components.core.l.a.ty().c(this.fP);
        this.iX = null;
        this.iW = null;
        IAdLiveOfflineView iAdLiveOfflineView = this.fC;
        if (iAdLiveOfflineView != null) {
            iAdLiveOfflineView.onDestroy();
            this.fC = null;
        }
    }

    @Override // com.kwad.sdk.core.j.c
    public final void bv() {
        com.kwad.components.core.l.a.ty().a(getCurrentVoiceItem());
        IAdLivePlayModule iAdLivePlayModule = this.ig;
        if (iAdLivePlayModule == null) {
            this.ig = cw();
        } else {
            iAdLivePlayModule.onResume();
        }
    }

    @Override // com.kwad.sdk.core.j.c
    public final void bw() {
        IAdLivePlayModule iAdLivePlayModule = this.ig;
        if (iAdLivePlayModule != null) {
            iAdLivePlayModule.onPause();
        }
        com.kwad.components.core.l.a.ty().c(this.fP);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public com.kwad.components.core.l.a.b getCurrentVoiceItem() {
        if (this.fP == null) {
            this.fP = new com.kwad.components.core.l.a.b(new com.kwad.components.core.l.a.c() { // from class: com.kwad.components.ad.nativead.e.4
                @Override // com.kwad.components.core.l.a.c
                public final void bH() {
                    if (e.this.ig == null) {
                        e eVar = e.this;
                        eVar.ig = eVar.cw();
                    }
                    if (e.this.ig != null) {
                        IAdLivePlayModule iAdLivePlayModule = e.this.ig;
                        e eVar2 = e.this;
                        iAdLivePlayModule.setAudioEnabled(eVar2.h(eVar2.mIsAudioEnable), false);
                    }
                }
            });
        }
        return this.fP;
    }
}
