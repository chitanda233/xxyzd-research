package com.bytedance.android;

import android.app.Activity;
import android.text.TextUtils;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.view.ViewParent;
import android.widget.Button;
import android.widget.FrameLayout;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.RelativeLayout;
import android.widget.TextView;
import android.widget.Toast;
import com.bytedance.sdk.openadsdk.mediation.ad.IMediationDislikeCallback;
import com.bytedance.sdk.openadsdk.mediation.ad.IMediationNativeAdInfo;
import com.bytedance.sdk.openadsdk.mediation.ad.MediationAdDislike;
import com.bytedance.sdk.openadsdk.mediation.ad.MediationNativeToBannerListener;
import com.bytedance.sdk.openadsdk.mediation.ad.MediationViewBinder;
import java.util.ArrayList;
import java.util.Map;

/* JADX INFO: loaded from: classes2.dex */
public class MediationNativeToBannerUtils {
    public static MediationNativeToBannerListener getMediationNativeToBannerListener(final Activity activity) {
        return new MediationNativeToBannerListener() { // from class: com.bytedance.android.MediationNativeToBannerUtils.1
            @Override // com.bytedance.sdk.openadsdk.mediation.ad.MediationNativeToBannerListener, com.bytedance.sdk.openadsdk.mediation.ad.IMediationNativeToBannerListener
            public View getMediationBannerViewFromNativeAd(IMediationNativeAdInfo iMediationNativeAdInfo) {
                return MediationNativeToBannerUtils.getCSJMBannerViewFromNativeAd(iMediationNativeAdInfo, activity);
            }
        };
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static View getCSJMBannerViewFromNativeAd(IMediationNativeAdInfo iMediationNativeAdInfo, Activity activity) {
        if (iMediationNativeAdInfo.getAdImageMode() == 2) {
            return getSmallAdView(null, iMediationNativeAdInfo, activity);
        }
        if (iMediationNativeAdInfo.getAdImageMode() == 3) {
            return getLargeAdView(null, iMediationNativeAdInfo, activity);
        }
        if (iMediationNativeAdInfo.getAdImageMode() == 4) {
            return getGroupAdView(null, iMediationNativeAdInfo, activity);
        }
        if (iMediationNativeAdInfo.getAdImageMode() == 5) {
            return getVideoView(null, iMediationNativeAdInfo, activity);
        }
        if (iMediationNativeAdInfo.getAdImageMode() == 16) {
            return getVerticalAdView(null, iMediationNativeAdInfo, activity);
        }
        if (iMediationNativeAdInfo.getAdImageMode() == 15) {
            return getVideoView(null, iMediationNativeAdInfo, activity);
        }
        Toast.makeText(activity, "图片展示样式错误", 0).show();
        return null;
    }

    private static View getVerticalAdView(ViewGroup viewGroup, IMediationNativeAdInfo iMediationNativeAdInfo, Activity activity) {
        View viewInflate = LayoutInflater.from(activity).inflate(R.layout.listitem_ad_vertical_pic, viewGroup, false);
        VerticalAdViewHolder verticalAdViewHolder = new VerticalAdViewHolder();
        verticalAdViewHolder.mTitle = (TextView) viewInflate.findViewById(R.id.tv_listitem_ad_title);
        verticalAdViewHolder.mSource = (TextView) viewInflate.findViewById(R.id.tv_listitem_ad_source);
        verticalAdViewHolder.mDescription = (TextView) viewInflate.findViewById(R.id.tv_listitem_ad_desc);
        verticalAdViewHolder.mVerticalImage = (ImageView) viewInflate.findViewById(R.id.iv_listitem_image);
        verticalAdViewHolder.mIcon = (ImageView) viewInflate.findViewById(R.id.iv_listitem_icon);
        verticalAdViewHolder.mDislike = (ImageView) viewInflate.findViewById(R.id.iv_listitem_dislike);
        verticalAdViewHolder.mCreativeButton = (Button) viewInflate.findViewById(R.id.btn_listitem_creative);
        verticalAdViewHolder.mLogo = (RelativeLayout) viewInflate.findViewById(R.id.tt_ad_logo);
        verticalAdViewHolder.app_info = (LinearLayout) viewInflate.findViewById(R.id.app_info);
        verticalAdViewHolder.app_name = (TextView) viewInflate.findViewById(R.id.app_name);
        verticalAdViewHolder.author_name = (TextView) viewInflate.findViewById(R.id.author_name);
        verticalAdViewHolder.package_size = (TextView) viewInflate.findViewById(R.id.package_size);
        verticalAdViewHolder.permissions_url = (TextView) viewInflate.findViewById(R.id.permissions_url);
        verticalAdViewHolder.permissions_content = (TextView) viewInflate.findViewById(R.id.permissions_content);
        verticalAdViewHolder.privacy_agreement = (TextView) viewInflate.findViewById(R.id.privacy_agreement);
        verticalAdViewHolder.version_name = (TextView) viewInflate.findViewById(R.id.version_name);
        MediationViewBinder mediationViewBinderBuild = new MediationViewBinder.Builder(R.layout.listitem_ad_vertical_pic).titleId(R.id.tv_listitem_ad_title).descriptionTextId(R.id.tv_listitem_ad_desc).mainImageId(R.id.iv_listitem_image).iconImageId(R.id.iv_listitem_icon).callToActionId(R.id.btn_listitem_creative).sourceId(R.id.tv_listitem_ad_source).logoLayoutId(R.id.tt_ad_logo).build();
        verticalAdViewHolder.viewBinder = mediationViewBinderBuild;
        bindData(viewInflate, verticalAdViewHolder, iMediationNativeAdInfo, mediationViewBinderBuild, activity);
        if (iMediationNativeAdInfo.getImageUrl() != null) {
            NativeAdManager.loadImgByVolley(iMediationNativeAdInfo.getImageUrl(), verticalAdViewHolder.mVerticalImage);
        }
        return viewInflate;
    }

    /* JADX WARN: Multi-variable type inference failed */
    private static View getVideoView(ViewGroup viewGroup, IMediationNativeAdInfo iMediationNativeAdInfo, Activity activity) {
        View view = null;
        Object[] objArr = 0;
        try {
            View viewInflate = LayoutInflater.from(activity).inflate(R.layout.listitem_ad_large_video, viewGroup, false);
            try {
                VideoAdViewHolder videoAdViewHolder = new VideoAdViewHolder();
                videoAdViewHolder.mTitle = (TextView) viewInflate.findViewById(R.id.tv_listitem_ad_title);
                videoAdViewHolder.mDescription = (TextView) viewInflate.findViewById(R.id.tv_listitem_ad_desc);
                videoAdViewHolder.mSource = (TextView) viewInflate.findViewById(R.id.tv_listitem_ad_source);
                videoAdViewHolder.videoView = (FrameLayout) viewInflate.findViewById(R.id.iv_listitem_video);
                videoAdViewHolder.mIcon = (ImageView) viewInflate.findViewById(R.id.iv_listitem_icon);
                videoAdViewHolder.mDislike = (ImageView) viewInflate.findViewById(R.id.iv_listitem_dislike);
                videoAdViewHolder.mCreativeButton = (Button) viewInflate.findViewById(R.id.btn_listitem_creative);
                videoAdViewHolder.mLogo = (RelativeLayout) viewInflate.findViewById(R.id.tt_ad_logo);
                videoAdViewHolder.app_info = (LinearLayout) viewInflate.findViewById(R.id.app_info);
                videoAdViewHolder.app_name = (TextView) viewInflate.findViewById(R.id.app_name);
                videoAdViewHolder.author_name = (TextView) viewInflate.findViewById(R.id.author_name);
                videoAdViewHolder.package_size = (TextView) viewInflate.findViewById(R.id.package_size);
                videoAdViewHolder.permissions_url = (TextView) viewInflate.findViewById(R.id.permissions_url);
                videoAdViewHolder.permissions_content = (TextView) viewInflate.findViewById(R.id.permissions_content);
                videoAdViewHolder.privacy_agreement = (TextView) viewInflate.findViewById(R.id.privacy_agreement);
                videoAdViewHolder.version_name = (TextView) viewInflate.findViewById(R.id.version_name);
                MediationViewBinder mediationViewBinderBuild = new MediationViewBinder.Builder(R.layout.listitem_ad_large_video).titleId(R.id.tv_listitem_ad_title).sourceId(R.id.tv_listitem_ad_source).descriptionTextId(R.id.tv_listitem_ad_desc).mediaViewIdId(R.id.iv_listitem_video).callToActionId(R.id.btn_listitem_creative).logoLayoutId(R.id.tt_ad_logo).iconImageId(R.id.iv_listitem_icon).build();
                videoAdViewHolder.viewBinder = mediationViewBinderBuild;
                bindData(viewInflate, videoAdViewHolder, iMediationNativeAdInfo, mediationViewBinderBuild, activity);
                return viewInflate;
            } catch (Exception e) {
                e = e;
                view = viewInflate;
                e.printStackTrace();
                return view;
            }
        } catch (Exception e2) {
            e = e2;
        }
    }

    private static View getLargeAdView(ViewGroup viewGroup, IMediationNativeAdInfo iMediationNativeAdInfo, Activity activity) {
        View viewInflate = LayoutInflater.from(activity).inflate(R.layout.listitem_ad_large_pic, viewGroup, false);
        LargeAdViewHolder largeAdViewHolder = new LargeAdViewHolder();
        largeAdViewHolder.mTitle = (TextView) viewInflate.findViewById(R.id.tv_listitem_ad_title);
        largeAdViewHolder.mDescription = (TextView) viewInflate.findViewById(R.id.tv_listitem_ad_desc);
        largeAdViewHolder.mSource = (TextView) viewInflate.findViewById(R.id.tv_listitem_ad_source);
        largeAdViewHolder.mLargeImage = (ImageView) viewInflate.findViewById(R.id.iv_listitem_image);
        largeAdViewHolder.mIcon = (ImageView) viewInflate.findViewById(R.id.iv_listitem_icon);
        largeAdViewHolder.mDislike = (ImageView) viewInflate.findViewById(R.id.iv_listitem_dislike);
        largeAdViewHolder.mCreativeButton = (Button) viewInflate.findViewById(R.id.btn_listitem_creative);
        largeAdViewHolder.mLogo = (RelativeLayout) viewInflate.findViewById(R.id.tt_ad_logo);
        largeAdViewHolder.app_info = (LinearLayout) viewInflate.findViewById(R.id.app_info);
        largeAdViewHolder.app_name = (TextView) viewInflate.findViewById(R.id.app_name);
        largeAdViewHolder.author_name = (TextView) viewInflate.findViewById(R.id.author_name);
        largeAdViewHolder.package_size = (TextView) viewInflate.findViewById(R.id.package_size);
        largeAdViewHolder.permissions_url = (TextView) viewInflate.findViewById(R.id.permissions_url);
        largeAdViewHolder.permissions_content = (TextView) viewInflate.findViewById(R.id.permissions_content);
        largeAdViewHolder.privacy_agreement = (TextView) viewInflate.findViewById(R.id.privacy_agreement);
        largeAdViewHolder.version_name = (TextView) viewInflate.findViewById(R.id.version_name);
        MediationViewBinder mediationViewBinderBuild = new MediationViewBinder.Builder(R.layout.listitem_ad_large_pic).titleId(R.id.tv_listitem_ad_title).descriptionTextId(R.id.tv_listitem_ad_desc).sourceId(R.id.tv_listitem_ad_source).mainImageId(R.id.iv_listitem_image).callToActionId(R.id.btn_listitem_creative).logoLayoutId(R.id.tt_ad_logo).iconImageId(R.id.iv_listitem_icon).build();
        largeAdViewHolder.viewBinder = mediationViewBinderBuild;
        bindData(viewInflate, largeAdViewHolder, iMediationNativeAdInfo, mediationViewBinderBuild, activity);
        if (iMediationNativeAdInfo.getImageUrl() != null) {
            NativeAdManager.loadImgByVolley(iMediationNativeAdInfo.getImageUrl(), largeAdViewHolder.mLargeImage);
        }
        return viewInflate;
    }

    private static View getGroupAdView(ViewGroup viewGroup, IMediationNativeAdInfo iMediationNativeAdInfo, Activity activity) {
        View viewInflate = LayoutInflater.from(activity).inflate(R.layout.listitem_ad_group_pic, viewGroup, false);
        GroupAdViewHolder groupAdViewHolder = new GroupAdViewHolder();
        groupAdViewHolder.mTitle = (TextView) viewInflate.findViewById(R.id.tv_listitem_ad_title);
        groupAdViewHolder.mSource = (TextView) viewInflate.findViewById(R.id.tv_listitem_ad_source);
        groupAdViewHolder.mDescription = (TextView) viewInflate.findViewById(R.id.tv_listitem_ad_desc);
        groupAdViewHolder.mGroupImage1 = (ImageView) viewInflate.findViewById(R.id.iv_listitem_image1);
        groupAdViewHolder.mGroupImage2 = (ImageView) viewInflate.findViewById(R.id.iv_listitem_image2);
        groupAdViewHolder.mGroupImage3 = (ImageView) viewInflate.findViewById(R.id.iv_listitem_image3);
        groupAdViewHolder.mIcon = (ImageView) viewInflate.findViewById(R.id.iv_listitem_icon);
        groupAdViewHolder.mDislike = (ImageView) viewInflate.findViewById(R.id.iv_listitem_dislike);
        groupAdViewHolder.mCreativeButton = (Button) viewInflate.findViewById(R.id.btn_listitem_creative);
        groupAdViewHolder.mLogo = (RelativeLayout) viewInflate.findViewById(R.id.tt_ad_logo);
        groupAdViewHolder.app_info = (LinearLayout) viewInflate.findViewById(R.id.app_info);
        groupAdViewHolder.app_name = (TextView) viewInflate.findViewById(R.id.app_name);
        groupAdViewHolder.author_name = (TextView) viewInflate.findViewById(R.id.author_name);
        groupAdViewHolder.package_size = (TextView) viewInflate.findViewById(R.id.package_size);
        groupAdViewHolder.permissions_url = (TextView) viewInflate.findViewById(R.id.permissions_url);
        groupAdViewHolder.permissions_content = (TextView) viewInflate.findViewById(R.id.permissions_content);
        groupAdViewHolder.privacy_agreement = (TextView) viewInflate.findViewById(R.id.privacy_agreement);
        groupAdViewHolder.version_name = (TextView) viewInflate.findViewById(R.id.version_name);
        MediationViewBinder mediationViewBinderBuild = new MediationViewBinder.Builder(R.layout.listitem_ad_group_pic).titleId(R.id.tv_listitem_ad_title).descriptionTextId(R.id.tv_listitem_ad_desc).sourceId(R.id.tv_listitem_ad_source).mainImageId(R.id.iv_listitem_image1).logoLayoutId(R.id.tt_ad_logo).callToActionId(R.id.btn_listitem_creative).iconImageId(R.id.iv_listitem_icon).groupImage1Id(R.id.iv_listitem_image1).groupImage2Id(R.id.iv_listitem_image2).groupImage3Id(R.id.iv_listitem_image3).build();
        groupAdViewHolder.viewBinder = mediationViewBinderBuild;
        bindData(viewInflate, groupAdViewHolder, iMediationNativeAdInfo, mediationViewBinderBuild, activity);
        if (iMediationNativeAdInfo.getImageList() != null && iMediationNativeAdInfo.getImageList().size() >= 3) {
            String str = iMediationNativeAdInfo.getImageList().get(0);
            String str2 = iMediationNativeAdInfo.getImageList().get(1);
            String str3 = iMediationNativeAdInfo.getImageList().get(2);
            if (str != null) {
                NativeAdManager.loadImgByVolley(str, groupAdViewHolder.mGroupImage1);
            }
            if (str2 != null) {
                NativeAdManager.loadImgByVolley(str2, groupAdViewHolder.mGroupImage2);
            }
            if (str3 != null) {
                NativeAdManager.loadImgByVolley(str3, groupAdViewHolder.mGroupImage3);
            }
        }
        return viewInflate;
    }

    private static View getSmallAdView(ViewGroup viewGroup, IMediationNativeAdInfo iMediationNativeAdInfo, Activity activity) {
        View viewInflate = LayoutInflater.from(activity).inflate(R.layout.listitem_ad_small_pic, (ViewGroup) null, false);
        SmallAdViewHolder smallAdViewHolder = new SmallAdViewHolder();
        smallAdViewHolder.mTitle = (TextView) viewInflate.findViewById(R.id.tv_listitem_ad_title);
        smallAdViewHolder.mSource = (TextView) viewInflate.findViewById(R.id.tv_listitem_ad_source);
        smallAdViewHolder.mDescription = (TextView) viewInflate.findViewById(R.id.tv_listitem_ad_desc);
        smallAdViewHolder.mSmallImage = (ImageView) viewInflate.findViewById(R.id.iv_listitem_image);
        smallAdViewHolder.mIcon = (ImageView) viewInflate.findViewById(R.id.iv_listitem_icon);
        smallAdViewHolder.mDislike = (ImageView) viewInflate.findViewById(R.id.iv_listitem_dislike);
        smallAdViewHolder.mCreativeButton = (Button) viewInflate.findViewById(R.id.btn_listitem_creative);
        smallAdViewHolder.app_info = (LinearLayout) viewInflate.findViewById(R.id.app_info);
        smallAdViewHolder.app_name = (TextView) viewInflate.findViewById(R.id.app_name);
        smallAdViewHolder.author_name = (TextView) viewInflate.findViewById(R.id.author_name);
        smallAdViewHolder.package_size = (TextView) viewInflate.findViewById(R.id.package_size);
        smallAdViewHolder.permissions_url = (TextView) viewInflate.findViewById(R.id.permissions_url);
        smallAdViewHolder.permissions_content = (TextView) viewInflate.findViewById(R.id.permissions_content);
        smallAdViewHolder.privacy_agreement = (TextView) viewInflate.findViewById(R.id.privacy_agreement);
        smallAdViewHolder.version_name = (TextView) viewInflate.findViewById(R.id.version_name);
        MediationViewBinder mediationViewBinderBuild = new MediationViewBinder.Builder(R.layout.listitem_ad_small_pic).titleId(R.id.tv_listitem_ad_title).sourceId(R.id.tv_listitem_ad_source).descriptionTextId(R.id.tv_listitem_ad_desc).mainImageId(R.id.iv_listitem_image).logoLayoutId(R.id.tt_ad_logo).callToActionId(R.id.btn_listitem_creative).iconImageId(R.id.iv_listitem_icon).build();
        smallAdViewHolder.viewBinder = mediationViewBinderBuild;
        bindData(viewInflate, smallAdViewHolder, iMediationNativeAdInfo, mediationViewBinderBuild, activity);
        if (iMediationNativeAdInfo.getImageUrl() != null) {
            NativeAdManager.loadImgByVolley(iMediationNativeAdInfo.getImageUrl(), smallAdViewHolder.mSmallImage);
        }
        return viewInflate;
    }

    private static void bindData(final View view, AdViewHolder adViewHolder, IMediationNativeAdInfo iMediationNativeAdInfo, MediationViewBinder mediationViewBinder, Activity activity) {
        if (iMediationNativeAdInfo.hasDislike()) {
            final MediationAdDislike dislikeDialog = iMediationNativeAdInfo.getDislikeDialog(activity);
            if (dislikeDialog != null && adViewHolder.mDislike != null) {
                adViewHolder.mDislike.setVisibility(0);
                adViewHolder.mDislike.setOnClickListener(new View.OnClickListener() { // from class: com.bytedance.android.MediationNativeToBannerUtils.2
                    @Override // android.view.View.OnClickListener
                    public void onClick(View view2) {
                        dislikeDialog.setDislikeCallback(new IMediationDislikeCallback() { // from class: com.bytedance.android.MediationNativeToBannerUtils.2.1
                            @Override // com.bytedance.sdk.openadsdk.mediation.ad.IMediationDislikeCallback
                            public void onCancel() {
                            }

                            @Override // com.bytedance.sdk.openadsdk.mediation.ad.IMediationDislikeCallback
                            public void onShow() {
                            }

                            @Override // com.bytedance.sdk.openadsdk.mediation.ad.IMediationDislikeCallback
                            public void onSelected(int i, String str) {
                                if (view != null) {
                                    ViewParent parent = view.getParent();
                                    if (parent instanceof ViewGroup) {
                                        ViewParent parent2 = parent.getParent();
                                        if (parent2 instanceof ViewGroup) {
                                            ((ViewGroup) parent2).removeView((ViewGroup) parent);
                                        }
                                    }
                                }
                            }
                        });
                        dislikeDialog.showDislikeDialog();
                    }
                });
            }
        } else if (adViewHolder.mDislike != null && view != null) {
            adViewHolder.mDislike.setVisibility(0);
            adViewHolder.mDislike.setOnClickListener(new View.OnClickListener() { // from class: com.bytedance.android.MediationNativeToBannerUtils.3
                @Override // android.view.View.OnClickListener
                public void onClick(View view2) {
                    ViewParent parent = view.getParent();
                    if (parent instanceof ViewGroup) {
                        ViewParent parent2 = parent.getParent();
                        if (parent2 instanceof ViewGroup) {
                            ((ViewGroup) parent2).removeView((ViewGroup) parent);
                        }
                    }
                }
            });
        }
        setDownLoadAppInfo(iMediationNativeAdInfo, adViewHolder);
        ArrayList arrayList = new ArrayList();
        arrayList.add(view);
        arrayList.add(adViewHolder.mSource);
        arrayList.add(adViewHolder.mTitle);
        arrayList.add(adViewHolder.mDescription);
        arrayList.add(adViewHolder.mIcon);
        if (adViewHolder instanceof LargeAdViewHolder) {
            arrayList.add(((LargeAdViewHolder) adViewHolder).mLargeImage);
        } else if (adViewHolder instanceof SmallAdViewHolder) {
            arrayList.add(((SmallAdViewHolder) adViewHolder).mSmallImage);
        } else if (adViewHolder instanceof VerticalAdViewHolder) {
            arrayList.add(((VerticalAdViewHolder) adViewHolder).mVerticalImage);
        } else if (adViewHolder instanceof VideoAdViewHolder) {
            arrayList.add(((VideoAdViewHolder) adViewHolder).videoView);
        } else if (adViewHolder instanceof GroupAdViewHolder) {
            GroupAdViewHolder groupAdViewHolder = (GroupAdViewHolder) adViewHolder;
            arrayList.add(groupAdViewHolder.mGroupImage1);
            arrayList.add(groupAdViewHolder.mGroupImage2);
            arrayList.add(groupAdViewHolder.mGroupImage3);
        }
        ArrayList arrayList2 = new ArrayList();
        arrayList2.add(adViewHolder.mCreativeButton);
        iMediationNativeAdInfo.registerView(activity, (ViewGroup) view, arrayList, arrayList2, null, mediationViewBinder);
        adViewHolder.mTitle.setText(iMediationNativeAdInfo.getTitle());
        adViewHolder.mDescription.setText(iMediationNativeAdInfo.getDescription());
        adViewHolder.mSource.setText(TextUtils.isEmpty(iMediationNativeAdInfo.getSource()) ? "" : iMediationNativeAdInfo.getSource());
        String iconUrl = iMediationNativeAdInfo.getIconUrl();
        if (iconUrl != null) {
            NativeAdManager.loadImgByVolley(iconUrl, adViewHolder.mIcon);
        }
        Button button = adViewHolder.mCreativeButton;
        int interactionType = iMediationNativeAdInfo.getInteractionType();
        if (interactionType == 2 || interactionType == 3) {
            button.setVisibility(0);
            button.setText(TextUtils.isEmpty(iMediationNativeAdInfo.getActionText()) ? "查看详情" : iMediationNativeAdInfo.getActionText());
        } else if (interactionType == 4) {
            button.setVisibility(0);
            button.setText(TextUtils.isEmpty(iMediationNativeAdInfo.getActionText()) ? "立即下载" : iMediationNativeAdInfo.getActionText());
        } else if (interactionType == 5) {
            button.setVisibility(0);
            button.setText("立即拨打");
        } else {
            button.setVisibility(8);
            Toast.makeText(activity, "交互类型异常", 0).show();
        }
    }

    private static void setDownLoadAppInfo(IMediationNativeAdInfo iMediationNativeAdInfo, AdViewHolder adViewHolder) {
        if (adViewHolder == null || adViewHolder.app_info == null) {
            return;
        }
        adViewHolder.app_info.setVisibility(8);
    }

    private static String getPermissionsContent(Map<String, String> map) {
        if (map == null) {
            return "";
        }
        StringBuilder sb = new StringBuilder();
        for (Map.Entry<String, String> entry : map.entrySet()) {
            sb.append(entry.getKey() + ", " + entry.getValue());
        }
        return sb.toString();
    }

    private static class VideoAdViewHolder extends AdViewHolder {
        FrameLayout videoView;

        private VideoAdViewHolder() {
            super();
            this.videoView = null;
        }
    }

    private static class LargeAdViewHolder extends AdViewHolder {
        ImageView mLargeImage;

        private LargeAdViewHolder() {
            super();
            this.mLargeImage = null;
        }
    }

    private static class SmallAdViewHolder extends AdViewHolder {
        ImageView mSmallImage;

        private SmallAdViewHolder() {
            super();
            this.mSmallImage = null;
        }
    }

    private static class VerticalAdViewHolder extends AdViewHolder {
        ImageView mVerticalImage;

        private VerticalAdViewHolder() {
            super();
            this.mVerticalImage = null;
        }
    }

    private static class GroupAdViewHolder extends AdViewHolder {
        ImageView mGroupImage1;
        ImageView mGroupImage2;
        ImageView mGroupImage3;

        private GroupAdViewHolder() {
            super();
            this.mGroupImage1 = null;
            this.mGroupImage2 = null;
            this.mGroupImage3 = null;
        }
    }

    private static class AdViewHolder {
        LinearLayout app_info;
        TextView app_name;
        TextView author_name;
        Button mCreativeButton;
        TextView mDescription;
        ImageView mDislike;
        ImageView mIcon;
        RelativeLayout mLogo;
        TextView mSource;
        TextView mTitle;
        TextView package_size;
        TextView permissions_content;
        TextView permissions_url;
        TextView privacy_agreement;
        TextView version_name;
        MediationViewBinder viewBinder;

        private AdViewHolder() {
            this.viewBinder = null;
            this.mIcon = null;
            this.mDislike = null;
            this.mCreativeButton = null;
            this.mTitle = null;
            this.mDescription = null;
            this.mSource = null;
            this.mLogo = null;
            this.app_info = null;
            this.app_name = null;
            this.author_name = null;
            this.package_size = null;
            this.permissions_url = null;
            this.privacy_agreement = null;
            this.version_name = null;
            this.permissions_content = null;
        }
    }
}
