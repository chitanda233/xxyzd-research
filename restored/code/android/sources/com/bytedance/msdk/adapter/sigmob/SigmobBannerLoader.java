package com.bytedance.msdk.adapter.sigmob;

import android.app.Activity;
import android.content.Context;
import android.os.Handler;
import android.os.Looper;
import android.util.SparseArray;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import androidx.core.view.PointerIconCompat;
import com.bykv.vk.openvk.api.proto.ValueSet;
import com.bytedance.JProtect;
import com.bytedance.msdk.adapter.sigmob.base.config.MediationAdSlotValueSet;
import com.bytedance.msdk.adapter.sigmob.base.config.MediationViewBinder;
import com.bytedance.msdk.adapter.sigmob.base.proto.AdnAdapterBridgeWrapper;
import com.bytedance.msdk.adapter.sigmob.base.proto.AdnAdapterValueSetBuilder;
import com.bytedance.msdk.adapter.sigmob.base.proto.MediationBaseAdBridge;
import com.bytedance.msdk.adapter.sigmob.base.utils.MediationValueUtil;
import com.sigmob.sdk.base.models.WindAdMetaData;
import com.sigmob.windad.WindAdError;
import com.sigmob.windad.natives.AdAppInfo;
import com.sigmob.windad.natives.NativeADEventListener;
import com.sigmob.windad.natives.WindNativeAdData;
import com.sigmob.windad.natives.WindNativeAdRequest;
import com.sigmob.windad.natives.WindNativeUnifiedAd;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.function.Function;

/* JADX INFO: loaded from: classes2.dex */
public class SigmobBannerLoader extends SigmobBaseLoader {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private MediationAdSlotValueSet f1870a;
    private Function b;
    private WindNativeUnifiedAd c;

    class SigmobNativeAd extends MediationBaseAdBridge {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        WindNativeAdData f1872a;
        private volatile boolean c;

        /* JADX WARN: Code duplicated, block: B:24:0x00e9  */
        /* JADX WARN: Code duplicated, block: B:26:0x00f1  */
        /* JADX WARN: Code duplicated, block: B:28:0x00f9  */
        public SigmobNativeAd(WindNativeAdData windNativeAdData) {
            int i;
            String cTAText;
            int i2;
            super(SigmobBannerLoader.this.f1870a, SigmobBannerLoader.this.b);
            this.c = false;
            this.f1872a = windNativeAdData;
            SparseArray<Object> sparseArray = new SparseArray<>();
            try {
                AdAppInfo adAppInfo = this.f1872a.getAdAppInfo();
                if (adAppInfo != null) {
                    sparseArray.put(8056, adAppInfo.getAppName());
                    sparseArray.put(8057, adAppInfo.getAuthorName());
                    sparseArray.put(8080, adAppInfo.getPrivacyAgreementUrl());
                    sparseArray.put(8081, adAppInfo.getVersionName());
                    sparseArray.put(8079, adAppInfo.getPermissionsUrl());
                    sparseArray.put(8551, adAppInfo.getDescriptionUrl());
                    sparseArray.put(8078, Long.valueOf(adAppInfo.getAppSize()));
                    sparseArray.put(8047, Integer.valueOf(adAppInfo.getAppSize()));
                }
            } catch (Throwable th) {
                th.printStackTrace();
            }
            sparseArray.put(8046, this.f1872a.getDesc());
            sparseArray.put(8048, this.f1872a.getIconUrl());
            sparseArray.put(8045, this.f1872a.getTitle());
            sparseArray.put(8061, this.f1872a.getCTAText());
            sparseArray.put(8049, this.f1872a.getTitle());
            int adPatternType = this.f1872a.getAdPatternType();
            if (adPatternType == 0) {
                i = -1;
            } else if (adPatternType == 1) {
                i = 5;
            } else {
                if (adPatternType != 2) {
                    if (adPatternType == 3) {
                        i = 4;
                    }
                    cTAText = this.f1872a.getCTAText();
                    if (cTAText.contains("下载")) {
                        i2 = 4;
                    } else if (cTAText.contains("详情") && cTAText.contains("拨打")) {
                        i2 = 5;
                    } else {
                        i2 = 3;
                    }
                    sparseArray.put(8059, i2);
                    sparseArray.put(8033, false);
                    sparseArray.put(-99999987, 8140);
                    sparseArray.put(-99999985, Void.class);
                    this.mGMAd.apply(sparseArray);
                }
                i = 3;
            }
            sparseArray.put(8060, i);
            cTAText = this.f1872a.getCTAText();
            if (cTAText.contains("下载")) {
                i2 = 4;
            } else if (cTAText.contains("详情")) {
                i2 = 3;
            } else {
                i2 = 5;
            }
            sparseArray.put(8059, i2);
            sparseArray.put(8033, false);
            sparseArray.put(-99999987, 8140);
            sparseArray.put(-99999985, Void.class);
            this.mGMAd.apply(sparseArray);
        }

        private int a() {
            int adPatternType = this.f1872a.getAdPatternType();
            if (adPatternType == 1) {
                return 5;
            }
            if (adPatternType != 2) {
                return adPatternType != 3 ? -1 : 4;
            }
            return 3;
        }

        /* JADX WARN: Type inference failed for: r10v3, types: [T, java.util.HashMap, java.util.Map] */
        @Override // com.bytedance.msdk.adapter.sigmob.base.proto.AdnAdapterBaseFunction
        public <T> T applyFunction(int i, SparseArray<Object> sparseArray, Class<T> cls) {
            if (i == 8121) {
                return (T) isReadyStatusForProto2(isReadyStatus(), sparseArray, cls);
            }
            if (i == 8120) {
                return (T) Boolean.valueOf(hasDestroyed());
            }
            if (i == 8159) {
                Activity activity = (Activity) MediationValueUtil.objectValue(sparseArray.get(20033), Activity.class, null);
                ViewGroup viewGroup = (ViewGroup) MediationValueUtil.objectValue(sparseArray.get(8067), ViewGroup.class, null);
                List<View> list = (List) MediationValueUtil.objectValue(sparseArray.get(8068), List.class, null);
                List<View> list2 = (List) MediationValueUtil.objectValue(sparseArray.get(8069), List.class, null);
                registerView(activity, viewGroup, list, list2, Utils.buildViewBinder(AdnAdapterBridgeWrapper.covertToFunction(MediationValueUtil.objectValue(sparseArray.get(8071), Object.class, null))));
            } else if (i == 8109) {
                onDestroy();
            } else if (i == 8239) {
                try {
                    WindAdMetaData windAdMetaData = this.f1872a.getWindAdMetaData();
                    if (windAdMetaData != null) {
                        ?? r10 = (T) new HashMap();
                        r10.put("adid", windAdMetaData.getAdId());
                        return r10;
                    }
                } catch (Throwable th) {
                    th.printStackTrace();
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
            return this.c;
        }

        @Override // com.bytedance.msdk.adapter.sigmob.base.proto.MediationBaseAdBridge
        public void onDestroy() {
            this.c = true;
            new Handler(Looper.getMainLooper()).post(new Runnable() { // from class: com.bytedance.msdk.adapter.sigmob.SigmobBannerLoader.SigmobNativeAd.4
                @Override // java.lang.Runnable
                public void run() {
                    if (SigmobNativeAd.this.f1872a != null) {
                        SigmobNativeAd.this.f1872a.destroy();
                    }
                    if (SigmobBannerLoader.this.c != null) {
                        SigmobBannerLoader.this.c.destroy();
                    }
                }
            });
        }

        @JProtect
        public void registerView(Context context, ViewGroup viewGroup, List<View> list, List<View> list2, MediationViewBinder mediationViewBinder) {
            WindNativeAdData windNativeAdData;
            View viewFindViewById;
            WindNativeAdData windNativeAdData2 = this.f1872a;
            if (windNativeAdData2 != null) {
                windNativeAdData2.bindViewForInteraction(viewGroup, list, list2, null, new NativeADEventListener() { // from class: com.bytedance.msdk.adapter.sigmob.SigmobBannerLoader.SigmobNativeAd.1
                    @Override // com.sigmob.windad.natives.NativeADEventListener
                    public void onAdClicked() {
                        if (SigmobNativeAd.this.mGMAd != null) {
                            SparseArray<Object> sparseArray = new SparseArray<>();
                            sparseArray.put(-99999987, Integer.valueOf(PointerIconCompat.TYPE_VERTICAL_TEXT));
                            sparseArray.put(-99999985, Void.class);
                            SigmobNativeAd.this.mGMAd.apply(sparseArray);
                        }
                    }

                    @Override // com.sigmob.windad.natives.NativeADEventListener
                    public void onAdDetailDismiss() {
                    }

                    @Override // com.sigmob.windad.natives.NativeADEventListener
                    public void onAdDetailShow() {
                    }

                    @Override // com.sigmob.windad.natives.NativeADEventListener
                    public void onAdError(WindAdError windAdError) {
                    }

                    @Override // com.sigmob.windad.natives.NativeADEventListener
                    public void onAdExposed() {
                        if (SigmobNativeAd.this.mGMAd != null) {
                            SparseArray<Object> sparseArray = new SparseArray<>();
                            sparseArray.put(-99999987, Integer.valueOf(PointerIconCompat.TYPE_TEXT));
                            sparseArray.put(-99999985, Void.class);
                            SigmobNativeAd.this.mGMAd.apply(sparseArray);
                        }
                    }
                });
                if (context instanceof Activity) {
                    this.f1872a.setDislikeInteractionCallback((Activity) context, new WindNativeAdData.DislikeInteractionCallback() { // from class: com.bytedance.msdk.adapter.sigmob.SigmobBannerLoader.SigmobNativeAd.2
                        @Override // com.sigmob.windad.natives.WindNativeAdData.DislikeInteractionCallback
                        public void onCancel() {
                        }

                        @Override // com.sigmob.windad.natives.WindNativeAdData.DislikeInteractionCallback
                        public void onSelected(int i, String str, boolean z) {
                            if (SigmobNativeAd.this.mGMAd != null) {
                                SparseArray<Object> sparseArray = new SparseArray<>();
                                sparseArray.put(-99999987, Integer.valueOf(PointerIconCompat.TYPE_HORIZONTAL_DOUBLE_ARROW));
                                sparseArray.put(-99999985, Void.class);
                                SigmobNativeAd.this.mGMAd.apply(sparseArray);
                            }
                        }

                        @Override // com.sigmob.windad.natives.WindNativeAdData.DislikeInteractionCallback
                        public void onShow() {
                        }
                    });
                }
            }
            WindNativeAdData windNativeAdData3 = this.f1872a;
            if (windNativeAdData3 != null && windNativeAdData3.getAdLogo() != null && (viewFindViewById = viewGroup.findViewById(mediationViewBinder.logoLayoutId)) != null) {
                viewFindViewById.setVisibility(0);
                if (viewFindViewById instanceof ViewGroup) {
                    ViewGroup viewGroup2 = (ViewGroup) viewFindViewById;
                    viewGroup2.removeAllViews();
                    ImageView imageView = new ImageView(context);
                    imageView.setImageBitmap(this.f1872a.getAdLogo());
                    imageView.setScaleType(ImageView.ScaleType.CENTER_INSIDE);
                    ViewGroup.LayoutParams layoutParams = viewFindViewById.getLayoutParams();
                    layoutParams.width = Utils.dp2px(context, 38.0f);
                    layoutParams.height = Utils.dp2px(context, 38.0f);
                    viewFindViewById.setLayoutParams(layoutParams);
                    viewGroup2.addView(imageView, -1, -1);
                } else if (viewFindViewById instanceof ImageView) {
                    ((ImageView) viewFindViewById).setImageBitmap(this.f1872a.getAdLogo());
                }
            }
            if (a() == 5) {
                ViewGroup viewGroup3 = (ViewGroup) viewGroup.findViewById(mediationViewBinder.mediaViewId);
                if (viewGroup3 == null || (windNativeAdData = this.f1872a) == null) {
                    return;
                }
                windNativeAdData.bindMediaView(viewGroup3, new WindNativeAdData.NativeADMediaListener() { // from class: com.bytedance.msdk.adapter.sigmob.SigmobBannerLoader.SigmobNativeAd.3
                    @Override // com.sigmob.windad.natives.WindNativeAdData.NativeADMediaListener
                    public void onVideoCompleted() {
                    }

                    @Override // com.sigmob.windad.natives.WindNativeAdData.NativeADMediaListener
                    public void onVideoError(WindAdError windAdError) {
                    }

                    @Override // com.sigmob.windad.natives.WindNativeAdData.NativeADMediaListener
                    public void onVideoLoad() {
                    }

                    @Override // com.sigmob.windad.natives.WindNativeAdData.NativeADMediaListener
                    public void onVideoPause() {
                    }

                    @Override // com.sigmob.windad.natives.WindNativeAdData.NativeADMediaListener
                    public void onVideoResume() {
                    }

                    @Override // com.sigmob.windad.natives.WindNativeAdData.NativeADMediaListener
                    public void onVideoStart() {
                    }
                });
                return;
            }
            if (a() == 2 || a() == 3) {
                if (this.f1872a != null) {
                    View viewFindViewById2 = viewGroup.findViewById(mediationViewBinder.mainImageId);
                    if (viewFindViewById2 instanceof ImageView) {
                        ArrayList arrayList = new ArrayList();
                        arrayList.add((ImageView) viewFindViewById2);
                        this.f1872a.bindImageViews(arrayList, 0);
                        return;
                    }
                    return;
                }
                return;
            }
            if (a() != 4 || this.f1872a == null) {
                return;
            }
            View viewFindViewById3 = viewGroup.findViewById(mediationViewBinder.groupImage1Id);
            View viewFindViewById4 = viewGroup.findViewById(mediationViewBinder.groupImage2Id);
            View viewFindViewById5 = viewGroup.findViewById(mediationViewBinder.groupImage3Id);
            ArrayList arrayList2 = new ArrayList();
            if (viewFindViewById3 instanceof ImageView) {
                arrayList2.add((ImageView) viewFindViewById3);
            }
            if (viewFindViewById4 instanceof ImageView) {
                arrayList2.add((ImageView) viewFindViewById4);
            }
            if (viewFindViewById5 instanceof ImageView) {
                arrayList2.add((ImageView) viewFindViewById5);
            }
            this.f1872a.bindImageViews(arrayList2, 0);
        }

        @Override // com.bykv.vk.openvk.api.proto.Bridge
        public ValueSet values() {
            return null;
        }
    }

    private void a() {
        WindNativeUnifiedAd windNativeUnifiedAd = new WindNativeUnifiedAd(new WindNativeAdRequest(getAdnId(), this.f1870a.getUserId(), 1, null));
        this.c = windNativeUnifiedAd;
        windNativeUnifiedAd.setNativeAdLoadListener(new WindNativeUnifiedAd.WindNativeAdLoadListener() { // from class: com.bytedance.msdk.adapter.sigmob.SigmobBannerLoader.1
            @Override // com.sigmob.windad.natives.WindNativeUnifiedAd.WindNativeAdLoadListener
            public void onAdError(WindAdError windAdError, String str) {
                if (windAdError != null) {
                    SigmobBannerLoader.this.notifyAdFailed(windAdError.getErrorCode(), windAdError.getMessage());
                } else {
                    SigmobBannerLoader.this.notifyAdFailed(80001, "error is null");
                }
            }

            @Override // com.sigmob.windad.natives.WindNativeUnifiedAd.WindNativeAdLoadListener
            public void onAdLoad(List<WindNativeAdData> list, String str) {
                if (list == null || list.isEmpty()) {
                    SigmobBannerLoader.this.notifyAdFailed(80001, "load成功，但list为空");
                    return;
                }
                for (WindNativeAdData windNativeAdData : list) {
                    if (windNativeAdData != null) {
                        SigmobBannerLoader.this.notifyAdSuccess(SigmobBannerLoader.this.new SigmobNativeAd(windNativeAdData), SigmobBannerLoader.this.b);
                        return;
                    }
                }
            }
        });
        this.c.loadAd();
    }

    @Override // com.bytedance.msdk.adapter.sigmob.base.MediationAdLoaderBaseFunction
    public void realLoader(Context context, MediationAdSlotValueSet mediationAdSlotValueSet) {
        String str;
        if (context == null || mediationAdSlotValueSet == null) {
            str = "context is null or adSlotValueSet is null";
        } else {
            this.f1870a = mediationAdSlotValueSet;
            this.b = getGMBridge();
            if (mediationAdSlotValueSet.getAdSubType() == 4) {
                int originType = mediationAdSlotValueSet.getOriginType();
                if (originType == 1) {
                    str = "sigmob不支持信息流模版";
                } else {
                    if (originType == 2) {
                        a();
                        return;
                    }
                    str = "sigmob渲染类型错误";
                }
            } else {
                str = "sigmob不支持banner";
            }
        }
        notifyAdFailed(80001, str);
    }
}
