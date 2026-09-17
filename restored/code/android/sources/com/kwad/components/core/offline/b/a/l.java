package com.kwad.components.core.offline.b.a;

import android.content.Context;
import android.content.pm.PackageInfo;
import com.kwad.components.core.offline.moitor.AdLivePlayMonitorInfo;
import com.kwad.components.offline.api.core.IOfflineHostApi;
import com.kwad.components.offline.api.core.adInnerEc.IAdInnerEcHostProvider;
import com.kwad.components.offline.api.core.adInnerEc.IFullLive;
import com.kwad.components.offline.api.core.adlive.ILive;
import com.kwad.components.offline.api.core.api.IAsync;
import com.kwad.components.offline.api.core.api.IBundleLoadListener;
import com.kwad.components.offline.api.core.api.IBundleService;
import com.kwad.components.offline.api.core.api.ICache;
import com.kwad.components.offline.api.core.api.ICrash;
import com.kwad.components.offline.api.core.api.ICrashCustomKeyValue;
import com.kwad.components.offline.api.core.api.ICrashOccurListener;
import com.kwad.components.offline.api.core.api.IDownloader;
import com.kwad.components.offline.api.core.api.IEncrypt;
import com.kwad.components.offline.api.core.api.IEnvironment;
import com.kwad.components.offline.api.core.api.IFlowUuid;
import com.kwad.components.offline.api.core.api.IImageLoader;
import com.kwad.components.offline.api.core.api.ILifeCycle;
import com.kwad.components.offline.api.core.api.ILoggerReporter;
import com.kwad.components.offline.api.core.api.INet;
import com.kwad.components.offline.api.core.api.IOfflineCompoLogcat;
import com.kwad.components.offline.api.core.api.ISensorManagerProxy;
import com.kwad.components.offline.api.core.api.ISystemProperties;
import com.kwad.components.offline.api.core.api.IVibratorUtil;
import com.kwad.components.offline.api.core.api.IZipper;
import com.kwad.components.offline.api.core.imageplayer.IImagePlayer;
import com.kwad.components.offline.api.core.network.IIdc;
import com.kwad.components.offline.api.core.network.INetworkManager;
import com.kwad.components.offline.api.core.video.IVideo;
import com.kwad.components.offline.api.core.webview.IWebView;
import com.kwad.components.offline.api.tk.model.report.TKExceptionUploadParams;
import com.kwad.sdk.utils.aa;
import com.kwad.sdk.utils.as;
import com.kwad.sdk.utils.bc;
import com.kwad.sdk.utils.be;
import com.kwad.sdk.utils.bv;
import com.kwai.adclient.kscommerciallogger.model.BusinessType;
import java.io.File;
import java.util.List;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class l implements IOfflineHostApi {
    private IAsync abT;
    private IEnvironment abU;
    private IZipper abV;
    private INet abW;
    private IEncrypt abX;
    private IOfflineCompoLogcat abY;
    private ICrash abZ;
    private ILoggerReporter aca;
    private IDownloader acb;
    private IImageLoader acc;
    private IVideo acd;
    private ILive ace;
    private ICache acf;
    private IWebView acg;
    private IVibratorUtil ach;
    private IIdc aci;
    private IImagePlayer acj;
    private ILifeCycle ack;
    private INetworkManager acl;
    private ISystemProperties acm;
    private IFlowUuid acn;
    private ISensorManagerProxy aco;
    private o acp;
    private a acq;
    private IFullLive acr;

    @Override // com.kwad.components.offline.api.core.IOfflineHostApi
    public final IEnvironment env() {
        if (this.abU == null) {
            this.abU = new e();
        }
        return this.abU;
    }

    @Override // com.kwad.components.offline.api.core.IOfflineHostApi
    public final IAsync async() {
        if (this.abT == null) {
            this.abT = new b();
        }
        return this.abT;
    }

    @Override // com.kwad.components.offline.api.core.IOfflineHostApi
    public final IZipper zipper() {
        if (this.abV == null) {
            this.abV = new u();
        }
        return this.abV;
    }

    @Override // com.kwad.components.offline.api.core.IOfflineHostApi
    public final INet net() {
        if (this.abW == null) {
            this.abW = new j();
        }
        return this.abW;
    }

    @Override // com.kwad.components.offline.api.core.IOfflineHostApi
    public final IEncrypt encrypt() {
        if (this.abX == null) {
            this.abX = new d();
        }
        return this.abX;
    }

    @Override // com.kwad.components.offline.api.core.IOfflineHostApi
    public final IOfflineCompoLogcat log() {
        if (this.abY == null) {
            this.abY = new m();
        }
        return this.abY;
    }

    @Override // com.kwad.components.offline.api.core.IOfflineHostApi
    public final ICrash crash() {
        if (this.abZ == null) {
            this.abZ = new ICrash() { // from class: com.kwad.components.core.offline.b.a.l.1
                @Override // com.kwad.components.offline.api.core.api.ICrash
                public final void gatherException(Throwable th) {
                    com.kwad.sdk.service.d.gatherException(th);
                }

                @Override // com.kwad.components.offline.api.core.api.ICrash
                public final void gatherException(TKExceptionUploadParams tKExceptionUploadParams) {
                    com.kwad.sdk.service.d.I(tKExceptionUploadParams.key, tKExceptionUploadParams.toJson().toString());
                }

                @Override // com.kwad.components.offline.api.core.api.ICrash
                public final void addCustomKeyValue(final ICrashCustomKeyValue iCrashCustomKeyValue) {
                    com.kwad.sdk.service.d.b(new com.kwad.sdk.service.a.c() { // from class: com.kwad.components.core.offline.b.a.l.1.1
                        @Override // com.kwad.sdk.service.a.c
                        public final String getKey() {
                            ICrashCustomKeyValue iCrashCustomKeyValue2 = iCrashCustomKeyValue;
                            if (iCrashCustomKeyValue2 != null) {
                                return iCrashCustomKeyValue2.getKey();
                            }
                            return null;
                        }

                        @Override // com.kwad.sdk.service.a.c
                        public final JSONObject getValue() {
                            ICrashCustomKeyValue iCrashCustomKeyValue2 = iCrashCustomKeyValue;
                            if (iCrashCustomKeyValue2 != null) {
                                return iCrashCustomKeyValue2.getValue();
                            }
                            return null;
                        }
                    });
                }

                @Override // com.kwad.components.offline.api.core.api.ICrash
                public final void addOnCrashListener(final ICrashOccurListener iCrashOccurListener) {
                    com.kwad.sdk.service.d.a(new com.kwad.sdk.service.a.g() { // from class: com.kwad.components.core.offline.b.a.l.1.2
                        @Override // com.kwad.sdk.service.a.g
                        public final void o(int i, String str) {
                            ICrashOccurListener iCrashOccurListener2 = iCrashOccurListener;
                            if (iCrashOccurListener2 != null) {
                                iCrashOccurListener2.onCrashOccur(i, str);
                            }
                        }
                    });
                }
            };
        }
        return this.abZ;
    }

    @Override // com.kwad.components.offline.api.core.IOfflineHostApi
    public final ILoggerReporter loggerReporter() {
        if (this.aca == null) {
            this.aca = new ILoggerReporter() { // from class: com.kwad.components.core.offline.b.a.l.2
                @Override // com.kwad.components.offline.api.core.api.ILoggerReporter
                public final void reportEvent(com.kwad.sdk.commercial.d dVar) {
                    com.kwad.sdk.commercial.c.d(dVar);
                }
            };
        }
        return this.aca;
    }

    @Override // com.kwad.components.offline.api.core.IOfflineHostApi
    public final IDownloader downloader() {
        if (this.acb == null) {
            this.acb = new IDownloader() { // from class: com.kwad.components.core.offline.b.a.l.3
                @Override // com.kwad.components.offline.api.core.api.IDownloader
                public final boolean downloadSync(File file, String str) {
                    return com.kwad.sdk.core.download.a.d(str, file);
                }
            };
        }
        return this.acb;
    }

    @Override // com.kwad.components.offline.api.core.IOfflineHostApi
    public final IImageLoader imageLoader() {
        if (this.acc == null) {
            this.acc = new h();
        }
        return this.acc;
    }

    @Override // com.kwad.components.offline.api.core.IOfflineHostApi
    public final IVideo video() {
        if (this.acd == null) {
            this.acd = new com.kwad.components.core.offline.b.c.e();
        }
        return this.acd;
    }

    @Override // com.kwad.components.offline.api.core.IOfflineHostApi
    public final ILive live() {
        if (this.ace == null) {
            this.ace = new com.kwad.components.core.offline.b.b.a();
        }
        return this.ace;
    }

    @Override // com.kwad.components.offline.api.core.IOfflineHostApi
    public final ICache cache() {
        if (this.acf == null) {
            this.acf = new c();
        }
        return this.acf;
    }

    @Override // com.kwad.components.offline.api.core.IOfflineHostApi
    public final IWebView webview() {
        if (this.acg == null) {
            this.acg = new com.kwad.components.core.offline.b.d.b();
        }
        return this.acg;
    }

    @Override // com.kwad.components.offline.api.core.IOfflineHostApi
    public final IVibratorUtil vibratorUtil() {
        if (this.ach == null) {
            this.ach = new t();
        }
        return this.ach;
    }

    @Override // com.kwad.components.offline.api.core.IOfflineHostApi
    public final IIdc idc() {
        if (this.aci == null) {
            this.aci = new p();
        }
        return this.aci;
    }

    @Override // com.kwad.components.offline.api.core.IOfflineHostApi
    public final IImagePlayer imagePlayer() {
        com.kwad.components.core.h.d dVar = new com.kwad.components.core.h.d();
        this.acj = dVar;
        return dVar;
    }

    @Override // com.kwad.components.offline.api.core.IOfflineHostApi
    public final IBundleService bundleService() {
        return new IBundleService() { // from class: com.kwad.components.core.offline.b.a.l.4
            @Override // com.kwad.components.offline.api.core.api.IBundleService
            public final void loadBundle(Context context, String str, final IBundleLoadListener iBundleLoadListener) {
                com.kwad.components.core.webview.tachikoma.g.yT().b(context, str, new com.kwad.components.core.webview.tachikoma.g.b() { // from class: com.kwad.components.core.offline.b.a.l.4.1
                    @Override // com.kwad.components.core.webview.tachikoma.g.b
                    public final void onSuccess() {
                        IBundleLoadListener iBundleLoadListener2 = iBundleLoadListener;
                        if (iBundleLoadListener2 != null) {
                            iBundleLoadListener2.onSuccess();
                        }
                    }

                    @Override // com.kwad.components.core.webview.tachikoma.g.b
                    public final void onFailed(String str2) {
                        IBundleLoadListener iBundleLoadListener2 = iBundleLoadListener;
                        if (iBundleLoadListener2 != null) {
                            iBundleLoadListener2.onFailed(str2);
                        }
                    }
                });
            }

            @Override // com.kwad.components.offline.api.core.api.IBundleService
            public final void loadBundleWithString(Context context, String str, final IBundleLoadListener iBundleLoadListener) {
                com.kwad.components.core.webview.tachikoma.g.yT().a(context, str, new com.kwad.components.core.webview.tachikoma.g.b() { // from class: com.kwad.components.core.offline.b.a.l.4.2
                    @Override // com.kwad.components.core.webview.tachikoma.g.b
                    public final void onSuccess() {
                        IBundleLoadListener iBundleLoadListener2 = iBundleLoadListener;
                        if (iBundleLoadListener2 != null) {
                            iBundleLoadListener2.onSuccess();
                        }
                    }

                    @Override // com.kwad.components.core.webview.tachikoma.g.b
                    public final void onFailed(String str2) {
                        IBundleLoadListener iBundleLoadListener2 = iBundleLoadListener;
                        if (iBundleLoadListener2 != null) {
                            iBundleLoadListener2.onFailed(str2);
                        }
                    }
                });
            }

            @Override // com.kwad.components.offline.api.core.api.IBundleService
            public final void unloadBundle(String str) {
                com.kwad.components.core.webview.tachikoma.g.yT().unloadBundle(str);
            }
        };
    }

    @Override // com.kwad.components.offline.api.core.IOfflineHostApi
    public final ILifeCycle lifeCycle() {
        if (this.ack == null) {
            this.ack = new i();
        }
        return this.ack;
    }

    @Override // com.kwad.components.offline.api.core.IOfflineHostApi
    public final INetworkManager networkManager() {
        if (this.acl == null) {
            this.acl = new k();
        }
        return this.acl;
    }

    @Override // com.kwad.components.offline.api.core.IOfflineHostApi
    public final ISystemProperties systemProperty() {
        if (this.acm == null) {
            this.acm = new q();
        }
        return this.acm;
    }

    @Override // com.kwad.components.offline.api.core.IOfflineHostApi
    public final IFlowUuid flowUuid() {
        if (this.acn == null) {
            this.acn = new f();
        }
        return this.acn;
    }

    @Override // com.kwad.components.offline.api.core.IOfflineHostApi
    public final ISensorManagerProxy sensorManager() {
        if (this.aco == null) {
            this.aco = new r();
        }
        return this.aco;
    }

    @Override // com.kwad.components.offline.api.core.IOfflineHostApi
    public final long getSystemTimeInMs(Context context, boolean z) {
        return bv.C(context, z);
    }

    @Override // com.kwad.components.offline.api.core.IOfflineHostApi
    public final void saveTKTemplateCache(String str, int i, String str2) {
        com.kwad.components.core.webview.tachikoma.h.yW().b(str, i, str2);
    }

    @Override // com.kwad.components.offline.api.core.IOfflineHostApi
    public final List<String> getTKPreloadMemCacheTemplates() {
        return com.kwad.sdk.core.config.e.getTKPreloadMemCacheTemplates();
    }

    @Override // com.kwad.components.offline.api.core.IOfflineHostApi
    public final boolean isOrientationPortrait() {
        return as.isOrientationPortrait();
    }

    @Override // com.kwad.components.offline.api.core.IOfflineHostApi
    public final int getTKErrorDetailCount() {
        return com.kwad.sdk.core.config.e.getTKErrorDetailCount();
    }

    @Override // com.kwad.components.offline.api.core.IOfflineHostApi
    public final int getAppIconId(Context context) {
        return bc.getAppIconId(context);
    }

    @Override // com.kwad.components.offline.api.core.IOfflineHostApi
    public final int getId(Context context, String str) {
        return bc.getId(context, str);
    }

    @Override // com.kwad.components.offline.api.core.IOfflineHostApi
    public final int getDrawableId(Context context, String str) {
        return bc.aD(context, str);
    }

    @Override // com.kwad.components.offline.api.core.IOfflineHostApi
    public final PackageInfo getPackageInfo(Context context, String str, int i) {
        return aa.getPackageInfo(context, str, i);
    }

    @Override // com.kwad.components.offline.api.core.IOfflineHostApi
    public final boolean canUseStorage() {
        return !be.useStoragePermissionDisable();
    }

    /* JADX INFO: Access modifiers changed from: private */
    @Override // com.kwad.components.offline.api.core.IOfflineHostApi
    /* JADX INFO: renamed from: tR, reason: merged with bridge method [inline-methods] */
    public o deviceManager() {
        if (this.acp == null) {
            this.acp = new o();
        }
        return this.acp;
    }

    @Override // com.kwad.components.offline.api.core.IOfflineHostApi
    public final String getWaynePlayerPlayConfig() {
        return com.kwad.sdk.core.config.e.KX();
    }

    @Override // com.kwad.components.offline.api.core.IOfflineHostApi
    public final IAdInnerEcHostProvider getAdInnerEcHostProvider() {
        if (this.acq == null) {
            this.acq = new a();
        }
        return this.acq;
    }

    @Override // com.kwad.components.offline.api.core.IOfflineHostApi
    public final IFullLive getFullLive() {
        if (this.acr == null) {
            this.acr = new g();
        }
        return this.acr;
    }

    @Override // com.kwad.components.offline.api.core.IOfflineHostApi
    public final void adLiveErrorReport(int i, String str, String str2, Long l, int i2, String str3) {
        if (l == null) {
            l = -1L;
        }
        com.kwad.sdk.commercial.c.d(com.kwad.sdk.commercial.d.Iz().dm(ILoggerReporter.Category.ERROR_LOG).g(1.0d).P("ad_sdk_live_video_error_monitor", "status").b(BusinessType.OTHER).A(new AdLivePlayMonitorInfo().setScene(i).setAppId(str).setAuthorId(str2).setUserId(l).setErrorCode(i2).setErrorMsg(str3)).a(com.kwai.adclient.kscommerciallogger.model.b.buL));
    }
}
