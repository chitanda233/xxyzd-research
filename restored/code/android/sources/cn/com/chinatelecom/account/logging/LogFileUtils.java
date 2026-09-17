package cn.com.chinatelecom.account.logging;

import android.content.Context;
import android.text.TextUtils;
import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileWriter;
import java.io.InputStreamReader;

/* JADX INFO: loaded from: classes.dex */
public class LogFileUtils {
    private static final String FILE_NAME = "ipa_ol.ds";
    private static final String FILE_PATH = "/eAccount/Log/";

    private static File createLogFile(Context context) {
        if (context == null) {
            return null;
        }
        try {
            File file = new File(context.getFilesDir() + FILE_PATH);
            if (!file.exists()) {
                file.mkdirs();
            }
            File file2 = new File(file, FILE_NAME);
            if (file2.exists()) {
                file2.delete();
            }
            file2.createNewFile();
            return file2;
        } catch (Exception e) {
            e.printStackTrace();
            return null;
        }
    }

    private static File getLogFile(Context context) {
        if (context != null) {
            try {
                File file = new File(context.getFilesDir() + FILE_PATH);
                if (!file.exists()) {
                    return null;
                }
                File file2 = new File(file, FILE_NAME);
                if (file2.exists()) {
                    return file2;
                }
                return null;
            } catch (Exception e) {
                e.printStackTrace();
            }
        }
        return null;
    }

    /* JADX INFO: Removed unreachable split cross block B:66:0x006d */
    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r0v1 */
    /* JADX WARN: Type inference failed for: r0v11 */
    /* JADX WARN: Type inference failed for: r0v12 */
    /* JADX WARN: Type inference failed for: r0v5, types: [java.io.BufferedWriter] */
    /* JADX WARN: Type inference failed for: r0v7 */
    /* JADX WARN: Type inference failed for: r0v8, types: [boolean] */
    private static void saveToFile(File file, String str) throws Throwable {
        FileWriter fileWriter;
        if (file == null || !file.exists()) {
            return;
        }
        BufferedWriter bufferedWriterIsEmpty = 0;
        bufferedWriterIsEmpty = 0;
        bufferedWriterIsEmpty = 0;
        bufferedWriterIsEmpty = 0;
        bufferedWriterIsEmpty = 0;
        try {
            try {
                try {
                    fileWriter = new FileWriter(file, false);
                    try {
                        BufferedWriter bufferedWriter = new BufferedWriter(fileWriter);
                        try {
                            bufferedWriterIsEmpty = TextUtils.isEmpty(str);
                            if (bufferedWriterIsEmpty != 0) {
                                bufferedWriter.write("");
                            } else {
                                bufferedWriter.write(str);
                            }
                            bufferedWriter.flush();
                            try {
                                bufferedWriter.close();
                            } catch (Exception e) {
                                e.printStackTrace();
                            }
                            fileWriter.close();
                        } catch (Exception e2) {
                            e = e2;
                            bufferedWriterIsEmpty = bufferedWriter;
                            e.printStackTrace();
                            if (bufferedWriterIsEmpty != 0) {
                                try {
                                    bufferedWriterIsEmpty.close();
                                } catch (Exception e3) {
                                    e3.printStackTrace();
                                }
                            }
                            if (fileWriter != null) {
                                fileWriter.close();
                            }
                        } catch (Throwable th) {
                            th = th;
                            bufferedWriterIsEmpty = bufferedWriter;
                            if (bufferedWriterIsEmpty != 0) {
                                try {
                                    bufferedWriterIsEmpty.close();
                                } catch (Exception e4) {
                                    e4.printStackTrace();
                                }
                            }
                            if (fileWriter != null) {
                                try {
                                    fileWriter.close();
                                    throw th;
                                } catch (Exception e5) {
                                    e5.printStackTrace();
                                    throw th;
                                }
                            }
                            throw th;
                        }
                    } catch (Exception e6) {
                        e = e6;
                    }
                } catch (Throwable th2) {
                    th = th2;
                }
            } catch (Exception e7) {
                e = e7;
                fileWriter = null;
            } catch (Throwable th3) {
                th = th3;
                fileWriter = null;
            }
        } catch (Exception e8) {
            e8.printStackTrace();
        }
    }

    public static void saveLogToFile(Context context, String str) throws Throwable {
        File logFile = getLogFile(context);
        if (logFile != null && logFile.exists()) {
            saveToFile(logFile, str);
        } else {
            saveToFile(createLogFile(context), str);
        }
    }

    /* JADX WARN: Code duplicated, block: B:46:0x0069 A[Catch: Exception -> 0x006d, DONT_GENERATE, TRY_ENTER, TRY_LEAVE, TryCatch #2 {Exception -> 0x006d, blocks: (B:23:0x003d, B:46:0x0069), top: B:76:0x0014 }] */
    /* JADX WARN: Code duplicated, block: B:82:0x0055 A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:91:0x005f A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Multi-variable type inference failed */
    public static String getLogString(Context context) {
        FileInputStream fileInputStream;
        BufferedReader bufferedReader;
        Throwable th;
        InputStreamReader inputStreamReader;
        File logFile = getLogFile(context);
        StringBuilder sb = new StringBuilder();
        if (logFile == null || !logFile.exists()) {
            return "";
        }
        try {
            try {
                fileInputStream = new FileInputStream(logFile);
                try {
                    inputStreamReader = new InputStreamReader(fileInputStream);
                    try {
                        bufferedReader = new BufferedReader(inputStreamReader);
                        while (true) {
                            try {
                                String line = bufferedReader.readLine();
                                if (line != null) {
                                    sb.append(line);
                                } else {
                                    try {
                                        break;
                                    } catch (Exception e) {
                                        e.printStackTrace();
                                    }
                                }
                            } catch (Throwable th2) {
                                th = th2;
                                try {
                                    th.printStackTrace();
                                    if (bufferedReader != null) {
                                        try {
                                            bufferedReader.close();
                                        } catch (Exception e2) {
                                            e2.printStackTrace();
                                        }
                                    }
                                    if (inputStreamReader != 0) {
                                        try {
                                            inputStreamReader.close();
                                        } catch (Exception e3) {
                                            e3.printStackTrace();
                                        }
                                    }
                                    if (fileInputStream != null) {
                                    }
                                    return sb.toString();
                                } finally {
                                    if (bufferedReader != null) {
                                        try {
                                            bufferedReader.close();
                                        } catch (Exception e4) {
                                            e4.printStackTrace();
                                        }
                                    }
                                    if (inputStreamReader != 0) {
                                        try {
                                            inputStreamReader.close();
                                        } catch (Exception e5) {
                                            e5.printStackTrace();
                                        }
                                    }
                                    if (fileInputStream != null) {
                                        try {
                                            fileInputStream.close();
                                        } catch (Exception e6) {
                                            e6.printStackTrace();
                                        }
                                    }
                                }
                            }
                        }
                        bufferedReader.close();
                        try {
                            inputStreamReader.close();
                        } catch (Exception e7) {
                            e7.printStackTrace();
                        }
                        fileInputStream.close();
                    } catch (Throwable th3) {
                        bufferedReader = null;
                        th = th3;
                    }
                } catch (Throwable th4) {
                    th = th4;
                    bufferedReader = null;
                    th = th;
                    inputStreamReader = bufferedReader;
                    th.printStackTrace();
                    if (bufferedReader != null) {
                        bufferedReader.close();
                    }
                    if (inputStreamReader != 0) {
                        inputStreamReader.close();
                    }
                    if (fileInputStream != null) {
                    }
                    return sb.toString();
                }
            } catch (Exception e8) {
            }
        } catch (Throwable th5) {
            th = th5;
            fileInputStream = null;
            bufferedReader = null;
        }
        return sb.toString();
    }
}
