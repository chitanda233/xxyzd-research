package com.sigmob.sdk.base.models;

import com.sigmob.sdk.base.utils.v;

/* JADX INFO: loaded from: classes3.dex */
public class SensorEntity {
    public int level;
    public int shakeTimeThreshold;
    public int shakeTriggerType;
    public int widgetIntervalTime;

    private SensorEntity() {
    }

    public SensorEntity(int level) {
        this.level = level;
    }

    public SensorEntity(int level, int shakeTriggerType, int widgetIntervalTime, int shakeTimeThreshold) {
        this.level = level;
        this.shakeTriggerType = shakeTriggerType;
        this.widgetIntervalTime = widgetIntervalTime;
        this.shakeTimeThreshold = shakeTimeThreshold;
    }

    public static SensorEntity format(BaseAdUnit adUnit) {
        SensorEntity sensorEntity = new SensorEntity();
        if (v.b(adUnit)) {
            sensorEntity.level = adUnit.getSensitivity();
            sensorEntity.shakeTriggerType = adUnit.getShakeTriggerType();
            sensorEntity.widgetIntervalTime = adUnit.getWidgetIntervalTime();
            sensorEntity.shakeTimeThreshold = adUnit.getShakeTimeThreshold();
        }
        return sensorEntity;
    }
}
