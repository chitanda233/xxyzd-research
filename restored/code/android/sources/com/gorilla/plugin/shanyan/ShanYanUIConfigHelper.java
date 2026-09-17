package com.gorilla.plugin.shanyan;

import android.app.Activity;
import android.content.Context;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.Color;
import android.graphics.drawable.BitmapDrawable;
import android.graphics.drawable.Drawable;
import android.graphics.drawable.GradientDrawable;
import android.text.TextUtils;
import android.util.Base64;
import android.util.DisplayMetrics;
import android.util.Log;
import android.view.View;
import android.widget.ImageView;
import android.widget.RelativeLayout;
import android.widget.TextView;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.chuanglan.shanyan_sdk.OneKeyLoginManager;
import com.chuanglan.shanyan_sdk.listener.ShanYanCustomInterface;
import com.chuanglan.shanyan_sdk.tool.ShanYanUIConfig;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class ShanYanUIConfigHelper {
    private static final int BRAND_ORANGE = Color.parseColor("#FF925C");
    private static final int SECONDARY_TEXT = Color.parseColor("#8E8E8E");
    private static final int HEADER_BACKGROUND = Color.parseColor("#1F2830");

    private ShanYanUIConfigHelper() {
    }

    public static void applyConfig(Activity activity, JSONObject jSONObject) {
        if (activity == null) {
            return;
        }
        Log.i("ShanYanUIConfigHelper", "applyConfig: customLogo=" + ((jSONObject == null || TextUtils.isEmpty(jSONObject.optString("customLogoBase64", ""))) ? false : true));
        DisplayMetrics displayMetrics = activity.getResources().getDisplayMetrics();
        int iMin = Math.min(Math.round(displayMetrics.widthPixels / displayMetrics.density), Math.round(displayMetrics.heightPixels / displayMetrics.density));
        boolean z = iMin >= 600;
        OneKeyLoginManager.getInstance().setAuthThemeConfig(buildConfig(activity, jSONObject, createPortraitSpec(iMin, z)), buildConfig(activity, jSONObject, createLandscapeSpec(iMin, z)));
    }

    private static ShanYanUIConfig buildConfig(Activity activity, JSONObject jSONObject, LayoutSpec layoutSpec) {
        ImageView.ScaleType scaleType;
        int i = layoutSpec.dialogWidth;
        int i2 = layoutSpec.dialogHeight;
        float f = i;
        int iRound = Math.round((189.0f * f) / 1000.0f);
        int i3 = i - 60;
        int iMax = Math.max(i - ((layoutSpec.isTablet ? 16 : 10) * 2), i - 42) - 5;
        ShanYanUIConfig.Builder builder = new ShanYanUIConfig.Builder();
        builder.setDialogTheme(true, i, i2, 0, 0, false);
        builder.setDialogDimAmount(0.35f);
        builder.setAuthBGImgPath(createDialogBackground(activity));
        builder.setAuthNavHidden(true);
        builder.setLogoHidden(true);
        builder.setNumberColor(-16777216);
        builder.setNumberSize(24);
        builder.setNumberBold(true);
        builder.setNumFieldWidth(i);
        builder.setNumFieldHeight(layoutSpec.numberHeight);
        int i4 = layoutSpec.sloganTop + layoutSpec.sloganHeight + layoutSpec.numberTopGap;
        builder.setNumFieldOffsetY(i4);
        int i5 = SECONDARY_TEXT;
        builder.setSloganTextColor(i5);
        builder.setSloganTextSize(14);
        builder.setSloganOffsetY(layoutSpec.sloganTop);
        builder.setLogBtnImgPath(loadDrawable(activity, "shanyan_login_button"));
        builder.setLogBtnText("本机号码一键登录");
        int i6 = BRAND_ORANGE;
        builder.setLogBtnTextColor(i6);
        builder.setLogBtnTextSize(18);
        builder.setLogBtnTextBold(true);
        builder.setLogBtnWidth(i3);
        builder.setLogBtnHeight(layoutSpec.loginButtonHeight);
        builder.setLogBtnOffsetY(i4 + layoutSpec.numberHeight + layoutSpec.loginTopGap);
        builder.setCheckBoxHidden(false);
        builder.setPrivacyState(jSONObject == null || jSONObject.optBoolean("privacyChecked", true));
        Drawable drawableLoadDrawable = loadDrawable(activity, "checkbox_selected");
        Drawable drawableLoadDrawable2 = loadDrawable(activity, "checkbox_unselected");
        if (drawableLoadDrawable != null) {
            builder.setCheckedImgPath(drawableLoadDrawable);
        }
        if (drawableLoadDrawable2 != null) {
            builder.setUncheckedImgPath(drawableLoadDrawable2);
        }
        builder.setCheckBoxWH(15, 15);
        builder.setcheckBoxOffsetXY(13, 5);
        builder.setCheckBoxMargin(1, 1, 1, 1);
        String strResolveUrl = resolveUrl(jSONObject, "userUrl");
        String strResolveUrl2 = resolveUrl(jSONObject, "privacyUrl");
        builder.setPrivacySmhHidden(true);
        if (!TextUtils.isEmpty(strResolveUrl)) {
            builder.setAppPrivacyOne("《用户协议》", strResolveUrl);
            if (!TextUtils.isEmpty(strResolveUrl2)) {
                builder.setAppPrivacyTwo("《隐私政策》", strResolveUrl2);
            }
        } else if (!TextUtils.isEmpty(strResolveUrl2)) {
            builder.setAppPrivacyOne("《隐私政策》", strResolveUrl2);
        }
        builder.setAppPrivacyColor(Color.parseColor("#8F8F8F"), i6);
        builder.setPrivacyWidth(iMax);
        builder.setPrivacyOffsetX(0);
        builder.setPrivacyGravityHorizontalCenter(true);
        builder.setPrivacyOffsetGravityLeft(false);
        builder.setPrivacyTextSize(10);
        builder.setPrivacyTextLineSpacing(0.0f, 1.2f);
        builder.setPrivacyText("同意", (TextUtils.isEmpty(strResolveUrl) || TextUtils.isEmpty(strResolveUrl2)) ? "" : "和", "", "", "并授权获得本机号码");
        builder.setPrivacyOffsetBottomY(layoutSpec.privacyBottom);
        builder.setPrivacyCustomToastText("请先阅读并同意协议");
        builder.setPrivacyNavHidden(true);
        builder.setPrivacyStatusBarHidden(false);
        builder.setPrivacyStatusBarColor(-1);
        builder.setPrivacyLightColor(false);
        builder.setPrivacyTitleArray(new String[]{"", "", ""});
        RelativeLayout relativeLayout = new RelativeLayout(activity);
        relativeLayout.setLayoutParams(new RelativeLayout.LayoutParams(0, 0));
        relativeLayout.setVisibility(8);
        builder.setLoadingView(relativeLayout);
        RelativeLayout relativeLayout2 = new RelativeLayout(activity);
        RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(-1, dp(activity, iRound + 10));
        layoutParams.addRule(10);
        relativeLayout2.setLayoutParams(layoutParams);
        ImageView imageView = new ImageView(activity);
        Drawable drawableLoadCustomLogo = loadCustomLogo(activity, jSONObject);
        boolean z = drawableLoadCustomLogo != null;
        if (!z) {
            drawableLoadCustomLogo = loadDrawable(activity, "shanyan_top_decoration");
        }
        if (drawableLoadCustomLogo == null) {
            drawableLoadCustomLogo = loadDrawable(activity, "gorilla_logo");
        }
        imageView.setImageDrawable(drawableLoadCustomLogo);
        if (z) {
            scaleType = ImageView.ScaleType.FIT_CENTER;
        } else {
            scaleType = ImageView.ScaleType.FIT_XY;
        }
        imageView.setScaleType(scaleType);
        if (z) {
            imageView.setBackgroundColor(HEADER_BACKGROUND);
            int iRound2 = Math.round(f * 0.345f);
            int iRound3 = Math.round(iRound * 0.275f);
            imageView.setPadding(dp(activity, iRound2), dp(activity, iRound3), dp(activity, iRound2), dp(activity, iRound3));
        }
        RelativeLayout.LayoutParams layoutParams2 = new RelativeLayout.LayoutParams(-1, dp(activity, iRound));
        layoutParams2.addRule(10);
        imageView.setLayoutParams(layoutParams2);
        relativeLayout2.addView(imageView);
        ImageView imageView2 = new ImageView(activity);
        imageView2.setImageDrawable(loadDrawable(activity, "shanyan_close_icon"));
        imageView2.setScaleType(ImageView.ScaleType.CENTER_INSIDE);
        imageView2.setPadding(dp(activity, 8), dp(activity, 8), dp(activity, 8), dp(activity, 8));
        imageView2.setClickable(true);
        imageView2.setOnClickListener(new View.OnClickListener() { // from class: com.gorilla.plugin.shanyan.ShanYanUIConfigHelper$$ExternalSyntheticLambda1
            @Override // android.view.View.OnClickListener
            public final void onClick(View view) {
                ShanYanUIConfigHelper.lambda$buildConfig$0(view);
            }
        });
        RelativeLayout.LayoutParams layoutParams3 = new RelativeLayout.LayoutParams(dp(activity, 44), dp(activity, 44));
        layoutParams3.addRule(11);
        layoutParams3.addRule(10);
        layoutParams3.setMargins(0, dp(activity, 4), dp(activity, 4), 0);
        imageView2.setLayoutParams(layoutParams3);
        relativeLayout2.addView(imageView2);
        builder.addCustomView(relativeLayout2, false, false, null);
        TextView textView = new TextView(activity);
        textView.setText("其他账号登录");
        textView.setTextColor(i5);
        textView.setTextSize(2, 14.0f);
        textView.setPaintFlags(textView.getPaintFlags() | 8);
        textView.setGravity(17);
        textView.setIncludeFontPadding(false);
        textView.setClickable(true);
        textView.setLayoutParams(new RelativeLayout.LayoutParams(-1, -2));
        builder.setRelativeCustomView(textView, false, 0, 10, 0, 2, createSwitchLoginHandler());
        return builder.build();
    }

    static /* synthetic */ void lambda$buildConfig$0(View view) {
        OneKeyLoginManager.getInstance().finishAuthActivity();
        ShanYanCloseAuthCallback.fire();
    }

    private static String resolveUrl(JSONObject jSONObject, String str) {
        if (jSONObject == null) {
            return null;
        }
        String strOptString = jSONObject.optString(str, "");
        if (TextUtils.isEmpty(strOptString)) {
            return null;
        }
        return strOptString;
    }

    private static Drawable loadDrawable(Activity activity, String str) {
        int identifier = activity.getResources().getIdentifier(str, "drawable", activity.getPackageName());
        if (identifier == 0) {
            identifier = activity.getResources().getIdentifier(str, "mipmap", activity.getPackageName());
        }
        if (identifier != 0) {
            return activity.getResources().getDrawable(identifier, activity.getTheme());
        }
        return null;
    }

    private static Drawable loadCustomLogo(Activity activity, JSONObject jSONObject) {
        if (jSONObject == null) {
            return null;
        }
        String strOptString = jSONObject.optString("customLogoBase64", "");
        if (TextUtils.isEmpty(strOptString)) {
            return null;
        }
        try {
            byte[] bArrDecode = Base64.decode(strOptString, 0);
            Bitmap bitmapDecodeByteArray = BitmapFactory.decodeByteArray(bArrDecode, 0, bArrDecode.length);
            if (bitmapDecodeByteArray != null) {
                return new BitmapDrawable(activity.getResources(), bitmapDecodeByteArray);
            }
            return null;
        } catch (IllegalArgumentException e) {
            Log.w("ShanYanUIConfigHelper", "Invalid custom login logo data", e);
            return null;
        }
    }

    private static Drawable createDialogBackground(Activity activity) {
        GradientDrawable gradientDrawable = new GradientDrawable();
        gradientDrawable.setColor(-1);
        gradientDrawable.setCornerRadius(dp(activity, 8));
        return gradientDrawable;
    }

    private static ShanYanCustomInterface createCloseHandler() {
        return new ShanYanCustomInterface() { // from class: com.gorilla.plugin.shanyan.ShanYanUIConfigHelper$$ExternalSyntheticLambda2
            @Override // com.chuanglan.shanyan_sdk.listener.ShanYanCustomInterface
            public final void onClick(Context context, View view) {
                ShanYanUIConfigHelper.lambda$createCloseHandler$1(context, view);
            }
        };
    }

    static /* synthetic */ void lambda$createCloseHandler$1(Context context, View view) {
        OneKeyLoginManager.getInstance().finishAuthActivity();
        ShanYanCloseAuthCallback.fire();
    }

    private static ShanYanCustomInterface createSwitchLoginHandler() {
        return new ShanYanCustomInterface() { // from class: com.gorilla.plugin.shanyan.ShanYanUIConfigHelper$$ExternalSyntheticLambda0
            @Override // com.chuanglan.shanyan_sdk.listener.ShanYanCustomInterface
            public final void onClick(Context context, View view) {
                ShanYanUIConfigHelper.lambda$createSwitchLoginHandler$2(context, view);
            }
        };
    }

    static /* synthetic */ void lambda$createSwitchLoginHandler$2(Context context, View view) {
        OneKeyLoginManager.getInstance().finishAuthActivity();
        ShanYanSwitchLoginCallback.fire();
    }

    private static int dp(Activity activity, int i) {
        return Math.round(i * activity.getResources().getDisplayMetrics().density);
    }

    private static LayoutSpec createPortraitSpec(int i, boolean z) {
        int iRound;
        if (z) {
            iRound = Math.min(Math.round(i * 0.55f), 420);
        } else {
            iRound = Math.round(i * 0.81f);
        }
        int i2 = iRound;
        return new LayoutSpec(z, i2, z ? MediaPlayer.MEDIA_PLAYER_OPTION_ENABLE_STALL_COUNTER : Math.max(Math.round(i2 * 0.92f), MediaPlayer.MEDIA_PLAYER_OPTION_LAST_VIDEO_RENDER_TIME), Math.round((i2 * 189.0f) / 1000.0f) + 28, 22, 2, 40, 18, 44, z ? 14 : 10);
    }

    private static LayoutSpec createLandscapeSpec(int i, boolean z) {
        return createPortraitSpec(i, z);
    }

    private static final class LayoutSpec {
        final int dialogHeight;
        final int dialogWidth;
        final boolean isTablet;
        final int loginButtonHeight;
        final int loginTopGap;
        final int numberHeight;
        final int numberTopGap;
        final int privacyBottom;
        final int sloganHeight;
        final int sloganTop;

        LayoutSpec(boolean z, int i, int i2, int i3, int i4, int i5, int i6, int i7, int i8, int i9) {
            this.isTablet = z;
            this.dialogWidth = i;
            this.dialogHeight = i2;
            this.sloganTop = i3;
            this.sloganHeight = i4;
            this.numberTopGap = i5;
            this.numberHeight = i6;
            this.loginTopGap = i7;
            this.loginButtonHeight = i8;
            this.privacyBottom = i9;
        }
    }
}
