package cn.thinkingdata.analytics;

import android.content.Context;
import android.content.res.Resources;
import cn.thinkingdata.core.preset.TDPresetUtils;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class TDPresetProperties {
    private static final String TAG = "ThinkingAnalytics.TDPresetProperties";
    public static final List<String> disableList = new ArrayList();
    public String appVersion;
    public String bundleId;
    public String carrier;
    public String deviceId;
    public String deviceModel;
    public String deviceType;
    public String disk;
    public int fps;
    public String installTime;
    public boolean isSimulator;
    public String manufacture;
    public String networkType;
    public String os;
    public String osVersion;
    private JSONObject presetProperties;
    public String ram;
    public int screenHeight;
    public int screenWidth;
    public String systemLanguage;
    public double zoneOffset;

    public TDPresetProperties() {
    }

    public TDPresetProperties(JSONObject jSONObject) {
        this.presetProperties = jSONObject;
        List<String> list = disableList;
        if (!list.contains(TDPresetUtils.KEY_BUNDLE_ID)) {
            this.bundleId = jSONObject.optString(TDPresetUtils.KEY_BUNDLE_ID);
        }
        if (!list.contains(TDPresetUtils.KEY_CARRIER)) {
            this.carrier = jSONObject.optString(TDPresetUtils.KEY_CARRIER);
        }
        if (!list.contains(TDPresetUtils.KEY_DEVICE_ID)) {
            this.deviceId = jSONObject.optString(TDPresetUtils.KEY_DEVICE_ID);
        }
        if (!list.contains(TDPresetUtils.KEY_DEVICE_MODEL)) {
            this.deviceModel = jSONObject.optString(TDPresetUtils.KEY_DEVICE_MODEL);
        }
        if (!list.contains(TDPresetUtils.KEY_MANUFACTURER)) {
            this.manufacture = jSONObject.optString(TDPresetUtils.KEY_MANUFACTURER);
        }
        if (!list.contains(TDPresetUtils.KEY_NETWORK_TYPE)) {
            this.networkType = jSONObject.optString(TDPresetUtils.KEY_NETWORK_TYPE);
        }
        if (!list.contains(TDPresetUtils.KEY_OS)) {
            this.os = jSONObject.optString(TDPresetUtils.KEY_OS);
        }
        if (!list.contains(TDPresetUtils.KEY_OS_VERSION)) {
            this.osVersion = jSONObject.optString(TDPresetUtils.KEY_OS_VERSION);
        }
        if (!list.contains(TDPresetUtils.KEY_SCREEN_HEIGHT)) {
            this.screenHeight = jSONObject.optInt(TDPresetUtils.KEY_SCREEN_HEIGHT);
        }
        if (!list.contains(TDPresetUtils.KEY_SCREEN_WIDTH)) {
            this.screenWidth = jSONObject.optInt(TDPresetUtils.KEY_SCREEN_WIDTH);
        }
        if (!list.contains(TDPresetUtils.KEY_SYSTEM_LANGUAGE)) {
            this.systemLanguage = jSONObject.optString(TDPresetUtils.KEY_SYSTEM_LANGUAGE);
        }
        this.zoneOffset = jSONObject.optDouble("#zone_offset");
        if (!list.contains(TDPresetUtils.KEY_APP_VERSION)) {
            this.appVersion = jSONObject.optString(TDPresetUtils.KEY_APP_VERSION);
        }
        if (!list.contains("#install_time")) {
            this.installTime = jSONObject.optString("#install_time");
        }
        if (!list.contains(TDPresetUtils.KEY_SIMULATOR)) {
            this.isSimulator = jSONObject.optBoolean(TDPresetUtils.KEY_SIMULATOR);
        }
        if (!list.contains("#ram")) {
            this.ram = jSONObject.optString("#ram");
        }
        if (!list.contains("#disk")) {
            this.disk = jSONObject.optString("#disk");
        }
        if (!list.contains("#fps")) {
            this.fps = jSONObject.optInt("#fps");
        }
        if (list.contains(TDPresetUtils.KEY_DEVICE_TYPE)) {
            return;
        }
        this.deviceType = jSONObject.optString(TDPresetUtils.KEY_DEVICE_TYPE);
    }

    public static void initDisableList(Context context) {
        List<String> list = disableList;
        synchronized (list) {
            if (list.isEmpty()) {
                try {
                    Resources resources = context.getResources();
                    list.addAll(Arrays.asList(resources.getStringArray(resources.getIdentifier("TDDisPresetProperties", "array", context.getPackageName()))));
                } catch (Exception | NoClassDefFoundError unused) {
                }
            }
        }
    }

    static void initDisableList(String[] strArr) {
        List<String> list = disableList;
        synchronized (list) {
            list.clear();
            list.addAll(Arrays.asList(strArr));
        }
    }

    public JSONObject toEventPresetProperties() {
        return this.presetProperties;
    }
}
