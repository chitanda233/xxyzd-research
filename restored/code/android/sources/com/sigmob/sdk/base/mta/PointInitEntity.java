package com.sigmob.sdk.base.mta;

import android.text.TextUtils;
import android.util.Base64;
import com.czhj.sdk.common.ClientMetadata;
import com.czhj.sdk.common.mta.DeviceContext;
import com.czhj.sdk.common.mta.PointEntitySuper;
import com.czhj.sdk.common.network.Networking;
import com.czhj.sdk.logger.SigmobLog;
import com.sigmob.sdk.b;
import com.sigmob.sdk.base.i;
import com.sigmob.sdk.base.o;
import com.sigmob.windad.WindAds;
import java.util.Iterator;

/* JADX INFO: loaded from: classes3.dex */
public class PointInitEntity extends PointEntitySuper {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private String f3231a;
    private String b;
    private String c;

    @Override // com.czhj.sdk.common.mta.PointEntitySuper
    public String appId() {
        return WindAds.sharedAds().getAppId();
    }

    public String getBattery_level() {
        return String.format("%.2f", ClientMetadata.getInstance().getBatteryLevel());
    }

    public String getBattery_save_enabled() {
        return String.valueOf(ClientMetadata.getInstance().getBatterySaveEnable());
    }

    public String getBattery_state() {
        return String.valueOf(ClientMetadata.getInstance().getBatteryState());
    }

    public String getBrand() {
        return ClientMetadata.getDeviceBrand();
    }

    public String getBrowser() {
        return Networking.getUserAgent();
    }

    public String getCheight() {
        return String.valueOf(ClientMetadata.getInstance().getDeviceScreenHeightDip());
    }

    public String getClientpixel() {
        return String.format("%sx%s", Integer.valueOf(ClientMetadata.getInstance().getDisplayMetrics().widthPixels), Integer.valueOf(ClientMetadata.getInstance().getDisplayMetrics().heightPixels));
    }

    public String getClienttype() {
        return ClientMetadata.getDeviceModel();
    }

    public String getCwidth() {
        return String.valueOf(ClientMetadata.getInstance().getDeviceScreenWidthDip());
    }

    @Override // com.czhj.sdk.common.mta.PointEntitySuper
    public DeviceContext getDeviceContext() {
        return b.b();
    }

    public String getDevice_type() {
        return ClientMetadata.getInstance().isTablet() ? "5" : "4";
    }

    public String getDheight() {
        return String.valueOf(ClientMetadata.getInstance().getDeviceScreenRealHeightDip());
    }

    public String getDwidth() {
        return String.valueOf(ClientMetadata.getInstance().getDeviceScreenRealWidthDip());
    }

    public String getIsEmulator() {
        return ClientMetadata.isEmulator() ? "1" : "0";
    }

    public String getIs_custom_android_id() {
        return this.b;
    }

    public String getIs_custom_imei() {
        return this.f3231a;
    }

    public String getIs_custom_oaid() {
        return this.c;
    }

    public String getPkgname() {
        return ClientMetadata.getInstance().getAppPackageName();
    }

    public String getResolution() {
        return String.format("%sx%s", Integer.valueOf(ClientMetadata.getInstance().getRealMetrics().widthPixels), Integer.valueOf(ClientMetadata.getInstance().getRealMetrics().heightPixels));
    }

    public String getScreenangle() {
        return String.valueOf(Math.abs(ClientMetadata.getInstance().getOrientationInt().intValue() - 1) * 90);
    }

    public String getScreendensity() {
        return String.valueOf(ClientMetadata.getInstance().getDensityDpi());
    }

    @Override // com.czhj.sdk.common.mta.PointEntitySuper
    public String getSdkversion() {
        return "4.25.14";
    }

    public String getTargetSdkVersion() {
        return ClientMetadata.getInstance().getTargetSdkVersion();
    }

    public String getVender() {
        return ClientMetadata.getDeviceManufacturer();
    }

    public String getWifi_id() {
        String wifiName = ClientMetadata.getInstance().getWifiName();
        return TextUtils.isEmpty(wifiName) ? wifiName : Base64.encodeToString(ClientMetadata.getInstance().getWifiName().getBytes(), 2);
    }

    public String getWifi_mac() {
        return ClientMetadata.getInstance().getWifimac();
    }

    @Override // com.czhj.sdk.common.mta.PointEntitySuper
    public boolean isAcTypeBlock() {
        if (!i.a().i()) {
            return true;
        }
        Iterator<Integer> it = o.a().M().iterator();
        while (it.hasNext()) {
            if (getAc_type().equals(String.valueOf(it.next()))) {
                SigmobLog.e("black ac type " + getAc_type());
                return true;
            }
        }
        return false;
    }

    public void setIs_custom_android_id(String is_custom_android_id) {
        this.b = is_custom_android_id;
    }

    public void setIs_custom_imei(String is_custom_imei) {
        this.f3231a = is_custom_imei;
    }

    public void setIs_custom_oaid(String is_custom_oaid) {
        this.c = is_custom_oaid;
    }
}
