package com.sigmob.windad.natives;

import android.app.Activity;
import android.graphics.Bitmap;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import com.sigmob.sdk.base.models.SigImage;
import com.sigmob.sdk.base.models.WindAdMetaData;
import com.sigmob.windad.WindAdError;
import java.util.List;
import java.util.Map;

/* JADX INFO: loaded from: classes4.dex */
public interface WindNativeAdData {

    public interface DislikeInteractionCallback {
        void onCancel();

        void onSelected(int position, String value, boolean enforce);

        void onShow();
    }

    public interface NativeADMediaListener {
        void onVideoCompleted();

        void onVideoError(WindAdError error);

        void onVideoLoad();

        void onVideoPause();

        void onVideoResume();

        void onVideoStart();
    }

    void bindImageViews(List<ImageView> imageViews, int defaultImageRes);

    void bindMediaView(ViewGroup mediaLayout, NativeADMediaListener nativeADMediaListener);

    void bindMediaViewWithoutAppInfo(ViewGroup mediaLayout, NativeADMediaListener nativeADMediaListener);

    void bindViewForInteraction(View view, List<View> clickableViews, List<View> creativeViewList, View disLikeView, NativeADEventListener nativeAdEventListener);

    void destroy();

    AdAppInfo getAdAppInfo();

    Bitmap getAdLogo();

    int getAdPatternType();

    View getAdView();

    String getCTAText();

    String getCurrency();

    String getDesc();

    String getEcpm();

    String getIconUrl();

    List<SigImage> getImageList();

    int getInteractionType();

    Map<String, String> getSaasOptions();

    String getTitle();

    String getVideoCoverImageUrl();

    int getVideoCurrentPosition();

    int getVideoDuration();

    int getVideoHeight();

    int getVideoProgress();

    int getVideoWidth();

    WindAdMetaData getWindAdMetaData();

    void pauseVideo();

    void resumeVideo();

    void setDislikeInteractionCallback(Activity activity, DislikeInteractionCallback dislikeInteractionCallback);

    void setVideoMute(boolean mute);

    void startVideo();

    void stopVideo();
}
