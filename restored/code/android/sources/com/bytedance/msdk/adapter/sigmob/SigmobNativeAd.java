package com.bytedance.msdk.adapter.sigmob;

import android.app.Activity;
import android.content.Context;
import android.os.Handler;
import android.os.Looper;
import android.util.SparseArray;
import android.view.View;
import android.view.ViewGroup;
import android.view.ViewTreeObserver;
import android.widget.FrameLayout;
import android.widget.ImageView;
import com.bykv.vk.openvk.api.proto.ValueSet;
import com.bytedance.msdk.adapter.sigmob.base.ad.MediationNativeAd;
import com.bytedance.msdk.adapter.sigmob.base.config.MediationViewBinder;
import com.bytedance.msdk.adapter.sigmob.base.proto.AdnAdapterBridgeWrapper;
import com.bytedance.msdk.adapter.sigmob.base.proto.AdnAdapterValueSetBuilder;
import com.bytedance.msdk.adapter.sigmob.base.utils.MediationApiLog;
import com.bytedance.msdk.adapter.sigmob.base.utils.MediationValueUtil;
import com.sigmob.sdk.base.models.SigImage;
import com.sigmob.sdk.base.models.WindAdMetaData;
import com.sigmob.windad.WindAdError;
import com.sigmob.windad.natives.AdAppInfo;
import com.sigmob.windad.natives.NativeADEventListener;
import com.sigmob.windad.natives.WindNativeAdData;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.LinkedList;
import java.util.List;
import java.util.function.Function;

/* JADX INFO: loaded from: classes2.dex */
public class SigmobNativeAd extends MediationNativeAd {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private WindNativeAdData f1881a;
    private volatile boolean b;
    private SigmobNativeLoader c;
    private WindNativeAdData.NativeADMediaListener d;
    private Context e;

    public SigmobNativeAd(Context context, WindNativeAdData windNativeAdData, SigmobNativeLoader sigmobNativeLoader, Function function) {
        super(sigmobNativeLoader, function);
        this.b = false;
        this.e = context;
        this.f1881a = windNativeAdData;
        this.c = sigmobNativeLoader;
        b();
    }

    private List<String> a() {
        ArrayList arrayList = new ArrayList();
        WindNativeAdData windNativeAdData = this.f1881a;
        if (windNativeAdData != null && windNativeAdData.getImageList().size() != 0) {
            for (SigImage sigImage : this.f1881a.getImageList()) {
                if (sigImage != null) {
                    arrayList.add(sigImage.getImageUrl());
                }
            }
        }
        return arrayList;
    }

    private void a(Context context, ViewGroup viewGroup, MediationViewBinder mediationViewBinder) {
        WindNativeAdData windNativeAdData;
        View viewFindViewById;
        WindNativeAdData windNativeAdData2 = this.f1881a;
        if (windNativeAdData2 != null && windNativeAdData2.getAdLogo() != null && (viewFindViewById = viewGroup.findViewById(mediationViewBinder.logoLayoutId)) != null) {
            viewFindViewById.setVisibility(0);
            if (viewFindViewById instanceof ViewGroup) {
                ViewGroup viewGroup2 = (ViewGroup) viewFindViewById;
                viewGroup2.removeAllViews();
                ImageView imageView = new ImageView(context);
                imageView.setImageBitmap(this.f1881a.getAdLogo());
                imageView.setScaleType(ImageView.ScaleType.CENTER_INSIDE);
                ViewGroup.LayoutParams layoutParams = viewFindViewById.getLayoutParams();
                layoutParams.width = dp2px(context, 38.0f);
                layoutParams.height = dp2px(context, 38.0f);
                viewFindViewById.setLayoutParams(layoutParams);
                viewGroup2.addView(imageView, -1, -1);
            } else if (viewFindViewById instanceof ImageView) {
                ((ImageView) viewFindViewById).setImageBitmap(this.f1881a.getAdLogo());
            }
        }
        if (getImageMode() == 5) {
            FrameLayout frameLayout = (FrameLayout) viewGroup.findViewById(mediationViewBinder.mediaViewId);
            if (frameLayout == null || (windNativeAdData = this.f1881a) == null) {
                return;
            }
            windNativeAdData.bindMediaView(frameLayout, this.d);
            return;
        }
        if (getImageMode() == 2 || getImageMode() == 3) {
            if (this.f1881a != null) {
                View viewFindViewById2 = viewGroup.findViewById(mediationViewBinder.mainImageId);
                if (viewFindViewById2 instanceof ImageView) {
                    ArrayList arrayList = new ArrayList();
                    arrayList.add((ImageView) viewFindViewById2);
                    this.f1881a.bindImageViews(arrayList, 0);
                    return;
                }
                return;
            }
            return;
        }
        if (getImageMode() != 4 || this.f1881a == null) {
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
        this.f1881a.bindImageViews(arrayList2, 0);
    }

    private void a(Context context, ViewGroup viewGroup, List<View> list, List<View> list2, MediationViewBinder mediationViewBinder, List<View> list3) {
        if (context == null) {
            context = viewGroup.getContext();
        }
        if (this.f1881a != null) {
            if (getImageMode() == 5) {
                if (Utils.isSdkVersionGe("4.25.14")) {
                    try {
                        boolean zIsMuted = this.c.isMuted();
                        this.f1881a.setVideoMute(zIsMuted);
                        MediationApiLog.i("setVideoMute: " + zIsMuted);
                    } catch (Throwable th) {
                        MediationApiLog.e("setVideoMute error: " + th.getMessage());
                    }
                }
                this.d = new WindNativeAdData.NativeADMediaListener() { // from class: com.bytedance.msdk.adapter.sigmob.SigmobNativeAd.2
                    @Override // com.sigmob.windad.natives.WindNativeAdData.NativeADMediaListener
                    public void onVideoCompleted() {
                        SigmobNativeAd.this.notifyOnVideoComplete();
                    }

                    @Override // com.sigmob.windad.natives.WindNativeAdData.NativeADMediaListener
                    public void onVideoError(WindAdError windAdError) {
                        if (windAdError != null) {
                            SigmobNativeAd.this.notifyOnVideoError(windAdError.getErrorCode(), windAdError.getMessage());
                        } else {
                            SigmobNativeAd.this.notifyOnVideoError(80004, "error is null");
                        }
                    }

                    @Override // com.sigmob.windad.natives.WindNativeAdData.NativeADMediaListener
                    public void onVideoLoad() {
                    }

                    @Override // com.sigmob.windad.natives.WindNativeAdData.NativeADMediaListener
                    public void onVideoPause() {
                        SigmobNativeAd.this.notifyOnVideoPause();
                    }

                    @Override // com.sigmob.windad.natives.WindNativeAdData.NativeADMediaListener
                    public void onVideoResume() {
                        SigmobNativeAd.this.notifyOnVideoResume();
                    }

                    @Override // com.sigmob.windad.natives.WindNativeAdData.NativeADMediaListener
                    public void onVideoStart() {
                        SigmobNativeAd.this.notifyOnVideoStart();
                    }
                };
            }
            this.f1881a.bindViewForInteraction(viewGroup, list, list2, null, new NativeADEventListener() { // from class: com.bytedance.msdk.adapter.sigmob.SigmobNativeAd.3
                @Override // com.sigmob.windad.natives.NativeADEventListener
                public void onAdClicked() {
                    SigmobNativeAd.this.notifyOnClickAd();
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
                    SigmobNativeAd.this.notifyOnShowAd();
                }
            });
        }
        if (mediationViewBinder != null) {
            a(context, viewGroup, mediationViewBinder);
        } else {
            a(list3);
        }
    }

    private void a(List<View> list) {
        if (this.f1881a == null || list == null || list.size() == 0) {
            return;
        }
        LinkedList linkedList = new LinkedList();
        for (View view : list) {
            if (view instanceof ImageView) {
                linkedList.add((ImageView) view);
            }
        }
        this.f1881a.bindImageViews(linkedList, 0);
    }

    /* JADX WARN: Code duplicated, block: B:24:0x00e7  */
    /* JADX WARN: Code duplicated, block: B:26:0x00ef  */
    /* JADX WARN: Code duplicated, block: B:28:0x00f7  */
    private void b() {
        int i;
        String cTAText;
        int i2;
        SparseArray<Object> sparseArray = new SparseArray<>();
        try {
            AdAppInfo adAppInfo = this.f1881a.getAdAppInfo();
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
        sparseArray.put(8046, this.f1881a.getDesc());
        sparseArray.put(8048, this.f1881a.getIconUrl());
        sparseArray.put(8045, this.f1881a.getTitle());
        sparseArray.put(8061, this.f1881a.getCTAText());
        sparseArray.put(8049, this.f1881a.getTitle());
        int adPatternType = this.f1881a.getAdPatternType();
        if (adPatternType == 0) {
            i = -1;
        } else if (adPatternType == 1) {
            i = 5;
        } else {
            if (adPatternType != 2) {
                if (adPatternType == 3) {
                    sparseArray.put(8053, a());
                    i = 4;
                }
                cTAText = this.f1881a.getCTAText();
                if (cTAText.contains("下载")) {
                    i2 = 4;
                } else if (cTAText.contains("详情") && cTAText.contains("拨打")) {
                    i2 = 5;
                } else {
                    i2 = 3;
                }
                sparseArray.put(8059, i2);
                sparseArray.put(8033, false);
                notifyNativeValue(sparseArray);
            }
            sparseArray.put(8053, a());
            i = 3;
        }
        sparseArray.put(8060, i);
        cTAText = this.f1881a.getCTAText();
        if (cTAText.contains("下载")) {
            i2 = 4;
        } else if (cTAText.contains("详情")) {
            i2 = 3;
        } else {
            i2 = 5;
        }
        sparseArray.put(8059, i2);
        sparseArray.put(8033, false);
        notifyNativeValue(sparseArray);
    }

    private View c() {
        if (this.e == null) {
            return null;
        }
        final FrameLayout frameLayout = new FrameLayout(this.e);
        frameLayout.setLayoutParams(new ViewGroup.LayoutParams(-1, -1));
        if (frameLayout.getViewTreeObserver() != null) {
            frameLayout.getViewTreeObserver().addOnGlobalLayoutListener(new ViewTreeObserver.OnGlobalLayoutListener() { // from class: com.bytedance.msdk.adapter.sigmob.SigmobNativeAd.1
                @Override // android.view.ViewTreeObserver.OnGlobalLayoutListener
                public void onGlobalLayout() {
                    if (frameLayout.getVisibility() == 0) {
                        if (SigmobNativeAd.this.f1881a != null) {
                            SigmobNativeAd.this.f1881a.bindMediaView(frameLayout, SigmobNativeAd.this.d);
                        }
                        if (frameLayout.getViewTreeObserver() != null) {
                            frameLayout.getViewTreeObserver().removeOnGlobalLayoutListener(this);
                        }
                    }
                }
            });
        }
        return frameLayout;
    }

    public static int dp2px(Context context, float f) {
        return (int) ((f * context.getResources().getDisplayMetrics().density) + 0.5f);
    }

    /* JADX WARN: Type inference failed for: r12v6, types: [T, java.util.HashMap, java.util.Map] */
    @Override // com.bytedance.msdk.adapter.sigmob.base.proto.AdnAdapterBaseFunction
    public <T> T applyFunction(int i, SparseArray<Object> sparseArray, Class<T> cls) {
        WindNativeAdData windNativeAdData;
        if (i == 8159) {
            a((Activity) MediationValueUtil.objectValue(sparseArray.get(20033), Activity.class, null), (ViewGroup) MediationValueUtil.objectValue(sparseArray.get(8067), ViewGroup.class, null), (List) MediationValueUtil.objectValue(sparseArray.get(8068), List.class, null), (List) MediationValueUtil.objectValue(sparseArray.get(8069), List.class, null), Utils.buildViewBinder(AdnAdapterBridgeWrapper.covertToFunction(MediationValueUtil.objectValue(sparseArray.get(8071), Object.class, null))), (List) MediationValueUtil.objectValue(sparseArray.get(8053), List.class, null));
        } else if (i == 8109) {
            this.b = true;
            new Handler(Looper.getMainLooper()).post(new Runnable() { // from class: com.bytedance.msdk.adapter.sigmob.SigmobNativeAd.4
                @Override // java.lang.Runnable
                public void run() {
                    if (SigmobNativeAd.this.f1881a != null) {
                        SigmobNativeAd.this.f1881a.destroy();
                    }
                    if (SigmobNativeAd.this.c.getWindNativeUnifiedAd() != null) {
                        SigmobNativeAd.this.c.getWindNativeUnifiedAd().destroy();
                    }
                }
            });
        } else {
            if (i == 8120) {
                return (T) Boolean.valueOf(this.b);
            }
            if (i == 8148) {
                WindNativeAdData windNativeAdData2 = this.f1881a;
                if (windNativeAdData2 != null) {
                    windNativeAdData2.resumeVideo();
                }
            } else if (i == 8149) {
                WindNativeAdData windNativeAdData3 = this.f1881a;
                if (windNativeAdData3 != null) {
                    windNativeAdData3.pauseVideo();
                }
            } else if (i == 6085) {
                Activity activity = (Activity) MediationValueUtil.objectValue(sparseArray.get(20033), Activity.class, null);
                WindNativeAdData windNativeAdData4 = this.f1881a;
                if (windNativeAdData4 != null) {
                    windNativeAdData4.setDislikeInteractionCallback(activity, new WindNativeAdData.DislikeInteractionCallback() { // from class: com.bytedance.msdk.adapter.sigmob.SigmobNativeAd.5
                        @Override // com.sigmob.windad.natives.WindNativeAdData.DislikeInteractionCallback
                        public void onCancel() {
                            SigmobNativeAd.this.notifyDislikeOnCancel();
                        }

                        @Override // com.sigmob.windad.natives.WindNativeAdData.DislikeInteractionCallback
                        public void onSelected(int i2, String str, boolean z) {
                            SigmobNativeAd.this.notifyDislikeClick(str, null);
                            SigmobNativeAd.this.notifyDislikeSelect(i2, str);
                        }

                        @Override // com.sigmob.windad.natives.WindNativeAdData.DislikeInteractionCallback
                        public void onShow() {
                            SigmobNativeAd.this.notifyDislikeOnShow();
                        }
                    });
                }
            } else {
                if (i == 6164) {
                    if (this.e != null) {
                        return (T) c();
                    }
                    return null;
                }
                if (i == 8268) {
                    if (Utils.isSdkVersionGe("4.25.14") && (windNativeAdData = this.f1881a) != null) {
                        try {
                            return (T) Double.valueOf(windNativeAdData.getVideoDuration());
                        } catch (Throwable th) {
                            MediationApiLog.e("getVideoDuration error: " + th.getMessage());
                        }
                    }
                    return (T) Double.valueOf(0.0d);
                }
                if (i != 8269) {
                    if (i == 8267) {
                        WindNativeAdData windNativeAdData5 = this.f1881a;
                        if (windNativeAdData5 != null) {
                            return (T) windNativeAdData5.getAdLogo();
                        }
                    } else if (i == 8239) {
                        try {
                            WindAdMetaData windAdMetaData = this.f1881a.getWindAdMetaData();
                            if (windAdMetaData != null) {
                                ?? r12 = (T) new HashMap();
                                r12.put("adid", windAdMetaData.getAdId());
                                return r12;
                            }
                        } catch (Throwable th2) {
                            th2.printStackTrace();
                        }
                    }
                }
            }
        }
        return (T) MediationValueUtil.checkClassType(cls);
    }

    @Override // com.bytedance.msdk.adapter.sigmob.base.ad.MediationNativeAd, com.bykv.vk.openvk.api.proto.Caller
    public <T> T call(int i, ValueSet valueSet, Class<T> cls) {
        return (T) applyFunction(i, AdnAdapterValueSetBuilder.converToSparseArray(valueSet), cls);
    }
}
