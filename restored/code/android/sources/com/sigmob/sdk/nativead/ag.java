package com.sigmob.sdk.nativead;

import android.app.Activity;
import android.graphics.Bitmap;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.SigImage;
import com.sigmob.sdk.base.models.SigVideo;
import com.sigmob.sdk.base.models.WindAdMetaData;
import com.sigmob.sdk.base.models.rtb.ResponseNativeAd;
import com.sigmob.windad.natives.AdAppInfo;
import com.sigmob.windad.natives.NativeADEventListener;
import com.sigmob.windad.natives.WindNativeAdData;
import java.util.List;
import java.util.Map;

/* JADX INFO: loaded from: classes4.dex */
public class ag implements WindNativeAdData {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final String f3570a;
    private final String b;
    private final String c;
    private final List<SigImage> d;
    private final SigVideo e;
    private int f;
    private final ab g;
    private final AdAppInfo h;

    public ag(BaseAdUnit adUnit) {
        this.f3570a = adUnit.getTitle();
        this.b = adUnit.getDesc();
        this.c = adUnit.getIconUrl();
        this.d = adUnit.getImageUrlList();
        ResponseNativeAd nativeAd = adUnit.getNativeAd();
        if (com.sigmob.sdk.base.utils.v.b(nativeAd)) {
            this.f = nativeAd.type.intValue();
        }
        this.h = adUnit.getAdAppInfo();
        this.e = adUnit.getNativeVideo();
        ab abVar = new ab();
        this.g = abVar;
        abVar.a(adUnit, this);
    }

    public String a() {
        return "sigmob";
    }

    public int b() {
        ab abVar = this.g;
        if (abVar == null) {
            return 0;
        }
        return abVar.p();
    }

    @Override // com.sigmob.windad.natives.WindNativeAdData
    public void bindImageViews(List<ImageView> imageViews, int defaultImageRes) {
        ab abVar = this.g;
        if (abVar == null) {
            return;
        }
        abVar.a(imageViews, defaultImageRes);
    }

    @Override // com.sigmob.windad.natives.WindNativeAdData
    public void bindMediaView(ViewGroup mediaLayout, WindNativeAdData.NativeADMediaListener nativeADMediaListener) {
        ab abVar = this.g;
        if (abVar == null) {
            return;
        }
        abVar.b(mediaLayout, nativeADMediaListener);
    }

    @Override // com.sigmob.windad.natives.WindNativeAdData
    public void bindMediaViewWithoutAppInfo(ViewGroup mediaLayout, WindNativeAdData.NativeADMediaListener nativeADMediaListener) {
        ab abVar = this.g;
        if (abVar == null) {
            return;
        }
        abVar.a(mediaLayout, nativeADMediaListener);
    }

    @Override // com.sigmob.windad.natives.WindNativeAdData
    public void bindViewForInteraction(View view, List<View> clickableViews, List<View> creativeViewList, View disLikeView, NativeADEventListener nativeAdEventListener) {
        ab abVar = this.g;
        if (abVar == null) {
            return;
        }
        abVar.a(view, clickableViews, creativeViewList, disLikeView, nativeAdEventListener);
    }

    public int c() {
        ab abVar = this.g;
        if (abVar == null) {
            return 0;
        }
        return abVar.v();
    }

    public int d() {
        return this.f;
    }

    @Override // com.sigmob.windad.natives.WindNativeAdData
    public void destroy() {
        ab abVar = this.g;
        if (abVar == null) {
            return;
        }
        abVar.x();
    }

    public void e() {
        ab abVar = this.g;
        if (abVar == null) {
            return;
        }
        abVar.w();
    }

    @Override // com.sigmob.windad.natives.WindNativeAdData
    public AdAppInfo getAdAppInfo() {
        return this.h;
    }

    @Override // com.sigmob.windad.natives.WindNativeAdData
    public Bitmap getAdLogo() {
        ab abVar = this.g;
        if (abVar == null) {
            return null;
        }
        return abVar.C();
    }

    @Override // com.sigmob.windad.natives.WindNativeAdData
    public int getAdPatternType() {
        return this.f;
    }

    @Override // com.sigmob.windad.natives.WindNativeAdData
    public View getAdView() {
        ab abVar = this.g;
        if (abVar == null) {
            return null;
        }
        return abVar.q();
    }

    @Override // com.sigmob.windad.natives.WindNativeAdData
    public String getCTAText() {
        ab abVar = this.g;
        return abVar == null ? "" : abVar.B();
    }

    @Override // com.sigmob.windad.natives.WindNativeAdData
    public String getCurrency() {
        ab abVar = this.g;
        return abVar == null ? "" : abVar.J();
    }

    @Override // com.sigmob.windad.natives.WindNativeAdData
    public String getDesc() {
        return this.b;
    }

    @Override // com.sigmob.windad.natives.WindNativeAdData
    public String getEcpm() {
        ab abVar = this.g;
        return abVar == null ? "" : abVar.I();
    }

    @Override // com.sigmob.windad.natives.WindNativeAdData
    public String getIconUrl() {
        return this.c;
    }

    @Override // com.sigmob.windad.natives.WindNativeAdData
    public List<SigImage> getImageList() {
        return this.d;
    }

    @Override // com.sigmob.windad.natives.WindNativeAdData
    public int getInteractionType() {
        ab abVar = this.g;
        if (abVar == null) {
            return 0;
        }
        return abVar.A();
    }

    @Override // com.sigmob.windad.natives.WindNativeAdData
    public Map<String, String> getSaasOptions() {
        ab abVar = this.g;
        if (abVar == null) {
            return null;
        }
        return abVar.M();
    }

    @Override // com.sigmob.windad.natives.WindNativeAdData
    public String getTitle() {
        return this.f3570a;
    }

    @Override // com.sigmob.windad.natives.WindNativeAdData
    public String getVideoCoverImageUrl() {
        ab abVar = this.g;
        if (abVar == null) {
            return null;
        }
        return abVar.K();
    }

    @Override // com.sigmob.windad.natives.WindNativeAdData
    public int getVideoCurrentPosition() {
        ab abVar = this.g;
        if (abVar == null) {
            return 0;
        }
        return abVar.t();
    }

    @Override // com.sigmob.windad.natives.WindNativeAdData
    public int getVideoDuration() {
        ab abVar = this.g;
        if (abVar == null) {
            return 0;
        }
        return abVar.s();
    }

    @Override // com.sigmob.windad.natives.WindNativeAdData
    public int getVideoHeight() {
        SigVideo sigVideo = this.e;
        if (sigVideo == null) {
            return 0;
        }
        return sigVideo.getHeight();
    }

    @Override // com.sigmob.windad.natives.WindNativeAdData
    public int getVideoProgress() {
        ab abVar = this.g;
        if (abVar == null) {
            return 0;
        }
        return abVar.u();
    }

    @Override // com.sigmob.windad.natives.WindNativeAdData
    public int getVideoWidth() {
        SigVideo sigVideo = this.e;
        if (sigVideo == null) {
            return 0;
        }
        return sigVideo.getWidth();
    }

    @Override // com.sigmob.windad.natives.WindNativeAdData
    public WindAdMetaData getWindAdMetaData() {
        ab abVar = this.g;
        if (abVar == null) {
            return null;
        }
        return abVar.L();
    }

    @Override // com.sigmob.windad.natives.WindNativeAdData
    public void pauseVideo() {
        ab abVar = this.g;
        if (abVar == null) {
            return;
        }
        abVar.E();
    }

    @Override // com.sigmob.windad.natives.WindNativeAdData
    public void resumeVideo() {
        ab abVar = this.g;
        if (abVar == null) {
            return;
        }
        abVar.G();
    }

    @Override // com.sigmob.windad.natives.WindNativeAdData
    public void setDislikeInteractionCallback(Activity activity, WindNativeAdData.DislikeInteractionCallback dislikeInteractionCallback) {
        ab abVar = this.g;
        if (abVar == null) {
            return;
        }
        abVar.a(dislikeInteractionCallback);
    }

    @Override // com.sigmob.windad.natives.WindNativeAdData
    public void setVideoMute(boolean mute) {
        ab abVar = this.g;
        if (abVar == null) {
            return;
        }
        abVar.b(mute);
    }

    @Override // com.sigmob.windad.natives.WindNativeAdData
    public void startVideo() {
        ab abVar = this.g;
        if (abVar == null) {
            return;
        }
        abVar.D();
    }

    @Override // com.sigmob.windad.natives.WindNativeAdData
    public void stopVideo() {
        ab abVar = this.g;
        if (abVar == null) {
            return;
        }
        abVar.H();
    }
}
