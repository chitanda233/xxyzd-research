package com.bytedance.msdk.adapter.sigmob;

import android.content.Context;
import android.text.TextUtils;
import android.util.SparseArray;
import android.view.ViewGroup;
import androidx.core.view.PointerIconCompat;
import com.bykv.vk.openvk.api.proto.ValueSet;
import com.bytedance.JProtect;
import com.bytedance.msdk.adapter.sigmob.base.MediationAdLoaderBaseFunction;
import com.bytedance.msdk.adapter.sigmob.base.config.MediationAdSlotValueSet;
import com.bytedance.msdk.adapter.sigmob.base.proto.AdnAdapterValueSetBuilder;
import com.bytedance.msdk.adapter.sigmob.base.proto.MediationBaseAdBridge;
import com.bytedance.msdk.adapter.sigmob.base.utils.MediationApiLog;
import com.bytedance.msdk.adapter.sigmob.base.utils.MediationValueUtil;
import com.sigmob.sdk.base.models.WindAdMetaData;
import com.sigmob.windad.Splash.WindSplashAD;
import com.sigmob.windad.Splash.WindSplashADListener;
import com.sigmob.windad.Splash.WindSplashAdRequest;
import com.sigmob.windad.WindAdError;
import java.util.HashMap;
import java.util.function.Function;

/* JADX INFO: loaded from: classes2.dex */
public class SigmobSplashLoader extends MediationAdLoaderBaseFunction {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private int f1892a = 3000;
    private SigmobSplashAd b;

    class SigmobSplashAd extends MediationBaseAdBridge {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        WindSplashAD f1893a;
        WindSplashADListener b;

        public SigmobSplashAd(MediationAdSlotValueSet mediationAdSlotValueSet, Function function) {
            super(mediationAdSlotValueSet, function);
            this.b = new WindSplashADListener() { // from class: com.bytedance.msdk.adapter.sigmob.SigmobSplashLoader.SigmobSplashAd.1
                @Override // com.sigmob.windad.Splash.WindSplashADListener
                @JProtect
                public void onSplashAdClick(String str) {
                    MediationApiLog.i("TTMediationSDK", "SigmobSplashLoader onSplashAdClick ");
                    if (SigmobSplashAd.this.mGMAd != null) {
                        SparseArray<Object> sparseArray = new SparseArray<>();
                        sparseArray.put(-99999987, Integer.valueOf(PointerIconCompat.TYPE_VERTICAL_TEXT));
                        sparseArray.put(-99999985, Void.class);
                        SigmobSplashAd.this.mGMAd.apply(sparseArray);
                    }
                }

                @Override // com.sigmob.windad.Splash.WindSplashADListener
                @JProtect
                public void onSplashAdClose(String str) {
                    MediationApiLog.i("TTMediationSDK", "SigmobSplashLoader onSplashAdClose ");
                    if (SigmobSplashAd.this.mGMAd != null) {
                        SparseArray<Object> sparseArray = new SparseArray<>();
                        sparseArray.put(-99999987, 1011);
                        sparseArray.put(-99999985, Void.class);
                        SigmobSplashAd.this.mGMAd.apply(sparseArray);
                    }
                    if (SigmobSplashAd.this.f1893a != null) {
                        SigmobSplashAd.this.f1893a.destroy();
                    }
                }

                @Override // com.sigmob.windad.Splash.WindSplashADListener
                @JProtect
                public void onSplashAdLoadFail(WindAdError windAdError, String str) {
                    MediationApiLog.i("TTMediationSDK", "SigmobSplashLoader onSplashAdLoadFail ");
                    if (windAdError != null) {
                        SigmobSplashLoader.this.notifyAdFailed(windAdError.getErrorCode(), windAdError.getMessage());
                    } else {
                        SigmobSplashLoader.this.notifyAdFailed(80001, "加载失败");
                    }
                }

                @Override // com.sigmob.windad.Splash.WindSplashADListener
                @JProtect
                public void onSplashAdLoadSuccess(String str) {
                    MediationApiLog.i("TTMediationSDK", "SigmobSplashLoader onSplashAdLoadSuccess ");
                    SigmobSplashLoader sigmobSplashLoader = SigmobSplashLoader.this;
                    SigmobSplashAd sigmobSplashAd = SigmobSplashAd.this;
                    sigmobSplashLoader.notifyAdSuccess(sigmobSplashAd, sigmobSplashAd.mGMAd);
                }

                @Override // com.sigmob.windad.Splash.WindSplashADListener
                @JProtect
                public void onSplashAdShow(String str) {
                    MediationApiLog.i("TTMediationSDK", "SigmobSplashLoader onSplashAdShow ");
                    if (SigmobSplashAd.this.mGMAd != null) {
                        SparseArray<Object> sparseArray = new SparseArray<>();
                        sparseArray.put(-99999987, Integer.valueOf(PointerIconCompat.TYPE_TEXT));
                        sparseArray.put(-99999985, Void.class);
                        SigmobSplashAd.this.mGMAd.apply(sparseArray);
                    }
                }

                @Override // com.sigmob.windad.Splash.WindSplashADListener
                @JProtect
                public void onSplashAdShowError(WindAdError windAdError, String str) {
                    MediationApiLog.i("TTMediationSDK", "SigmobSplashLoader onSplashAdShowError ");
                    if (SigmobSplashAd.this.mGMAd != null) {
                        SparseArray<Object> sparseArray = new SparseArray<>();
                        sparseArray.put(-99999987, Integer.valueOf(PointerIconCompat.TYPE_TOP_LEFT_DIAGONAL_DOUBLE_ARROW));
                        sparseArray.put(-99999985, Void.class);
                        sparseArray.put(8014, Integer.valueOf(windAdError != null ? windAdError.getErrorCode() : 0));
                        sparseArray.put(8015, windAdError != null ? windAdError.getMessage() : "广告对象无效");
                        SigmobSplashAd.this.mGMAd.apply(sparseArray);
                    }
                }

                @Override // com.sigmob.windad.Splash.WindSplashADListener
                @JProtect
                public void onSplashAdSkip(String str) {
                    MediationApiLog.i("TTMediationSDK", "SigmobSplashLoader onSplashAdSkip ");
                    if (SigmobSplashAd.this.mGMAd != null) {
                        SparseArray<Object> sparseArray = new SparseArray<>();
                        sparseArray.put(-99999987, Integer.valueOf(PointerIconCompat.TYPE_ZOOM_OUT));
                        sparseArray.put(-99999985, Void.class);
                        SigmobSplashAd.this.mGMAd.apply(sparseArray);
                    }
                }
            };
        }

        @JProtect
        void a() {
            WindSplashAdRequest windSplashAdRequest = new WindSplashAdRequest(SigmobSplashLoader.this.getAdnId(), getUserID(), null);
            windSplashAdRequest.setFetchDelay(SigmobSplashLoader.this.a());
            this.f1893a = new WindSplashAD(windSplashAdRequest, this.b);
            if (TextUtils.isEmpty(SigmobSplashLoader.this.getAdm())) {
                MediationApiLog.i("TTMediationSDK", "SigmobSplashLoader loadAd.......loadAd start....");
                this.f1893a.loadAd();
            } else {
                MediationApiLog.i("TTMediationSDK", "SigmobSplashLoader loadBidAd.......loadAd start....adm:" + SigmobSplashLoader.this.getAdm());
                this.f1893a.loadAd(SigmobSplashLoader.this.getAdm());
            }
        }

        /* JADX WARN: Type inference failed for: r3v2, types: [T, java.util.HashMap, java.util.Map] */
        @Override // com.bytedance.msdk.adapter.sigmob.base.proto.AdnAdapterBaseFunction
        public <T> T applyFunction(int i, SparseArray<Object> sparseArray, Class<T> cls) {
            if (i == 6152) {
                MediationApiLog.i("TTMediationSDK", "SigmobSplashLoader showSplashAd ");
                ViewGroup viewGroup = (ViewGroup) MediationValueUtil.objectValue(sparseArray.get(20060), ViewGroup.class, null);
                if (viewGroup != null) {
                    showSplashAd(viewGroup);
                }
            } else if (i != 6154 && i != 6161) {
                if (i == 8109) {
                    onDestroy();
                } else {
                    if (i == 8120) {
                        return (T) Boolean.valueOf(hasDestroyed());
                    }
                    if (i == 8121) {
                        return (T) isReadyStatusForProto2(isReadyStatus(), sparseArray, cls);
                    }
                    if (i == 8239) {
                        try {
                            WindAdMetaData windAdMetaData = this.f1893a.getWindAdMetaData();
                            if (windAdMetaData != null) {
                                ?? r3 = (T) new HashMap();
                                r3.put("adid", windAdMetaData.getAdId());
                                return r3;
                            }
                        } catch (Throwable th) {
                            th.printStackTrace();
                        }
                    }
                }
            }
            return (T) MediationValueUtil.checkClassType(cls);
        }

        @Override // com.bykv.vk.openvk.api.proto.Caller
        public <T> T call(int i, ValueSet valueSet, Class<T> cls) {
            return (T) applyFunction(i, AdnAdapterValueSetBuilder.converToSparseArray(valueSet), cls);
        }

        @Override // com.bytedance.msdk.adapter.sigmob.base.proto.MediationBaseAdBridge
        public boolean hasDestroyed() {
            return this.f1893a == null;
        }

        @Override // com.bytedance.msdk.adapter.sigmob.base.proto.MediationBaseAdBridge
        public Integer isReadyStatus() {
            WindSplashAD windSplashAD = this.f1893a;
            return Integer.valueOf((windSplashAD == null || !windSplashAD.isReady()) ? 4 : 2);
        }

        @Override // com.bytedance.msdk.adapter.sigmob.base.proto.MediationBaseAdBridge
        public void onDestroy() {
            this.f1893a = null;
        }

        @JProtect
        public void showSplashAd(ViewGroup viewGroup) {
            if (this.f1893a == null || viewGroup == null) {
                return;
            }
            viewGroup.removeAllViews();
            this.f1893a.show(viewGroup);
        }

        @Override // com.bykv.vk.openvk.api.proto.Bridge
        public ValueSet values() {
            return null;
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public int a() {
        int i = this.f1892a;
        if (i < 1000) {
            return 1;
        }
        return i / 1000;
    }

    @Override // com.bytedance.msdk.adapter.sigmob.base.MediationAdLoaderBaseFunction
    public void realLoader(Context context, MediationAdSlotValueSet mediationAdSlotValueSet) {
        MediationApiLog.i("TTMediationSDK", "SigmobSplashLoader realLoader adnId:" + getAdnId());
        this.f1892a = getLoadTimeOut();
        SigmobSplashAd sigmobSplashAd = new SigmobSplashAd(mediationAdSlotValueSet, getGMBridge());
        this.b = sigmobSplashAd;
        sigmobSplashAd.a();
    }
}
